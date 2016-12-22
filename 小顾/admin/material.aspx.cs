using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Default3 : System.Web.UI.Page
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
        var dataSource = data.DataTable("select * from food where food_type_id=" + ddlFoodType.SelectedValue.ToString() + "order by id desc");
        rptMaterial.DataSource = dataSource;
        rptMaterial.DataBind();
    }
    public void typeBind()
    {
        var dataSource = data.DataTable("select * from food_type where id<>1 order by id desc");
        ddlFoodType.DataSource = dataSource;
        ddlFoodType.DataValueField = "id";
        ddlFoodType.DataTextField = "name";
        ddlFoodType.DataBind();
    }
    protected void ddlFoodType_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlFoodType.SelectedValue == "1000")
            Response.Redirect("addtype.aspx");
        else
            foodBind();
    }
    protected void lbtAddMaterial_Click(object sender, EventArgs e)
    {
        foreach (RepeaterItem item in rptMaterial.Items)   //循环repeater中的项  
        {
            TextBox txtid = (TextBox)item.FindControl("txtID");
            string id = txtid.Text;
            TextBox mNum = (TextBox)item.FindControl("txtNum"); //查找ID为“tradeID”的服务器控件  
            string num = mNum.Text;
            string select = "select * from material where food_id=" + id;
            if (data.DataTable(select).Rows.Count == 0)
                data.OperateLine("insert into material values('" + id + "','" + num + "')");
            else
                data.OperateLine("update material set rest_num=rest_num+" + num + " where food_id=" + id);
        }
        Session["type"] = ddlFoodType.SelectedValue;
        Response.Redirect("food.aspx");

    }
}