using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string select = "select * from food_type where id<>1";
            ddlFoodType.DataSource = data.DataTable(select);
            ddlFoodType.DataValueField = "id";
            ddlFoodType.DataTextField = "name";
            ddlFoodType.DataBind();
            if (Request.QueryString["typeid"] != null)
                ddlFoodType.SelectedValue = Request.QueryString["typeid"].ToString();
            if (Request.QueryString["id"]!=null)
            {
                string goodsid = Request.QueryString["id"].ToString();
                string goodsSelect = "select * from food where id =" + goodsid;
                var datasource=data.DataTable(goodsSelect);
                ddlFoodType.SelectedValue = datasource.Rows[0]["food_type_id"].ToString();
                txtName.Text = datasource.Rows[0]["name"].ToString();
                txtPrice.Text = datasource.Rows[0]["price"].ToString();
                ddlRecomend.SelectedValue = datasource.Rows[0]["recomend"].ToString();
                string goodsPic = datasource.Rows[0]["picture"].ToString();
                impGoods.ImageUrl = "../upload/foodPicture/" + goodsPic;
                impGoods.Visible = true;
            }
        }
    }
    protected void lbtSave_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] != null)
        {
            string id = Request.QueryString["id"].ToString();     
            string food_type_id = ddlFoodType.SelectedValue.ToString();
            string show = ddlRecomend.SelectedValue.ToString();
            if (food_type_id != "" && txtName.Text != "" && txtPrice.Text != "")
            {
                string goodsPicName = uploadGoodsPic();
                string update;
                if (goodsPicName != null)
                    update = "update food set name=N'" + txtName.Text + "',price=N'" + txtPrice.Text + "',food_type_id=N'" + food_type_id + 
                        "',picture=N'" + goodsPicName + "',recomend='" + show + "' where id =" + id;
                else
                    update = "update food set name=N'" + txtName.Text + "',price=N'" + txtPrice.Text + "',food_type_id=N'" + food_type_id +
                        "',recomend='" + show + "' where id =" + id;
                data.OperateLine(update);
                Session["type"] = food_type_id;
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('请完善食品信息');</script>");
                return;
            }
            Response.Redirect("food.aspx");
        }
        else
        {
            string show = ddlRecomend.SelectedValue.ToString();
            string food_type_id = ddlFoodType.SelectedValue.ToString();
            if (food_type_id != "" && txtName.Text != "" && txtPrice.Text != "")
            {
                string goodsPicName = uploadGoodsPic();
                if (goodsPicName != "")
                {
                    string insert = "insert into food(name,price,food_type_id,picture,recomend) values(N'" + txtName.Text + "',N'" + txtPrice.Text + "',N'"
                                    + food_type_id + "',N'" + goodsPicName + "',N'" + show + "')";
                    data.OperateLine(insert);
                    Session["type"] = food_type_id;
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('请完善食品信息');</script>");
                    return;
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('请完善食品信息');</script>");
                return;
            }
            Response.Redirect("food.aspx");
        }
        
    }
    string uploadGoodsPic() //上传封面图片，返回文件名。
    {
        string picSaveName = null;
        int maxFileSize = 3145728; // 限制为3MiB以下
        if (fulPicture.HasFile)
        {
            //取得文件MIME内容类型 
            string uploadFileType = this.fulPicture.PostedFile.ContentType.ToLower();
            if (!uploadFileType.Contains("image"))    //图片的MIME类型为"image/xxx"，这里只判断是否图片。 
            {
                labState.Text = "只能上传图片类型文件！";
                labState.Visible = true;
                return null;
            }

            if (fulPicture.FileContent.Length > maxFileSize) // 限制为3MiB以下
            {
                labState.Text = "图片文件大小不可超过 3 MB";
                labState.Visible = true;
                return null;
            }

            string picPath = fulPicture.PostedFile.FileName;
            string picFileName = fulPicture.FileName;
            string picFileExtension = picFileName.Substring(picFileName.LastIndexOf('.')); //带.的扩展名
            Random rdm = new Random();
            string random = rdm.Next(0, 999999).ToString("D6"); //6位随机数
            picSaveName = DateTime.Now.ToString("yyyyMMddHHmmssffff") + random + picFileExtension; //当前时间


            string serverpath = Server.MapPath("../upload/foodPicture/") + picSaveName;
            try
            {
                fulPicture.PostedFile.SaveAs(serverpath);//将上传的文件另存为 
                labState.Text = "上传成功";
                labState.Visible = true;
                return picSaveName;
            }
            catch (Exception error)
            {
                labState.Text = "上传失败，原因为： " + error.ToString();
                labState.Visible = true;
                return null;
            }
        }
        else
        {
            labState.Text = "请选择文件";
            return null;
        }
    }

    protected void lbtReturn_Click(object sender, EventArgs e)
    {
        Response.Write("<script language=javascript>history.go(-2);</script>");
    }
}