using System;
using System.Collections.Generic;
using System.IO;
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
            typeBind();
            ddlFoodType.Items.Add(new ListItem("-添加新菜系-", "1000"));
            if (Session["type"] != null)
                ddlFoodType.SelectedValue = Session["type"].ToString();
            foodBind();
        }
        

    }
    public void foodBind()
    {
        var dataSource = data.DataTable("select food.id,name,price,picture,food_type_id,recomend,food_id,rest_num from food,material where food_type_id=" + ddlFoodType.SelectedValue.ToString()+" and food.id=material.food_id order by id desc");
        rptGoods.DataSource = dataSource;
        rptGoods.DataBind();
    }
    public void typeBind()
    {
        var dataSource = data.DataTable("select * from food_type where id<>1 order by id desc");
        ddlFoodType.DataSource = dataSource;
        ddlFoodType.DataValueField = "id";
        ddlFoodType.DataTextField = "name";
        ddlFoodType.DataBind();
    }
    protected void rptGoods_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        string id = e.CommandArgument.ToString().Trim();
        if (e.CommandName == "delete")
        {
            string pic = data.DataTable("select * from food where id=" + id).Rows[0]["picture"].ToString();
            //判断文件是不是存在
            if (File.Exists(Server.MapPath(@"../upload/foodPicture/" + pic)))
            {
                //如果存在则删除
                File.Delete(Server.MapPath(@"../upload/foodPicture/" + pic));
            }
            string delete = "delete from food where id =" + id;
            data.OperateLine(delete);
            string delete2 = "delete from material where food_id =" + id;
            data.OperateLine(delete2);
            foodBind();
           
        }
        else if (e.CommandName == "edit")
        {
            Response.Redirect("foodedit.aspx?id="+id);
        }
    }
    protected void ddlFoodType_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlFoodType.SelectedValue == "1000")
            Response.Redirect("addtype.aspx");
        else
            foodBind();
    }
    protected void lbtAddFood_Click(object sender, EventArgs e)
    {
        Response.Redirect("foodedit.aspx?typeid=" + ddlFoodType.SelectedValue);
    }
}