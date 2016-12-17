using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["id"] != null)
            {
                string id = Request.QueryString["id"].ToString();
                var datasource = data.DataTable("select * from advertisement where id =" + id);
                txtArticle.InnerText = datasource.Rows[0]["adcontent"].ToString();
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
            if (txtArticle.InnerText.Length <= 7)
            {
                string goodsPicName = uploadGoodsPic();
                string id = Request.QueryString["id"].ToString();
                string update;
                if (txtArticle.InnerText != "")
                {
                    if (goodsPicName != null)
                        update = "update advertisement set adcontent=N'" + txtArticle.InnerText + "',picture=N'" + goodsPicName + "' where id =" + id;
                    else
                        update = "update advertisement set adcontent=N'" + txtArticle.InnerText + "' where id =" + id;
                    data.OperateLine(update);
                }
                else
                    ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('请完善内容');</script>");
                Response.Redirect("advertisement.aspx");
            }
            else
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('内容过长');</script>");
        }
        else
        {
            if (txtArticle.InnerText.Length <= 7)
            {
                string goodsPicName = uploadGoodsPic();
                string addtime = DateTime.Now.ToString();
                if (goodsPicName != null && txtArticle.InnerText!="")
                {
                    string insert = "insert into advertisement (adcontent,picture) values(N'" + txtArticle.InnerText + "',N'" + goodsPicName + "')";
                    data.OperateLine(insert);
                }
                else
                    ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('请完善内容');</script>");
                Response.Redirect("advertisement.aspx");
            }
            else
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('内容过长');</script>");
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

}