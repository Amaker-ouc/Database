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
            typeBind();
            if (Request.QueryString["id"] != null)
            {
                string cookid = Request.QueryString["id"].ToString();
                string cookSelect = "select * from cook where id =" + cookid;
                var datasource = data.DataTable(cookSelect);
                txtName.Text = datasource.Rows[0]["name"].ToString();
                ddlPosition.SelectedValue = datasource.Rows[0]["position"].ToString();
            }
        }
    }
    protected void lbtSave_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] != null)
        {
            string id = Request.QueryString["id"].ToString();
            string food_type_id = ddlFoodType.SelectedValue.ToString();
            string position = ddlPosition.SelectedValue;
            if (food_type_id != "" && txtName.Text != "" && position != "")
            {
                string update = "update cook set name=N'" + txtName.Text + "',food_type_id=N'" + food_type_id + "',position=N'" + position + "' where id =" + id;
                data.OperateLine(update);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('请完善人员信息');</script>");
                return;
            }
            Response.Redirect("cook.aspx");
        }
        else
        {
            string position = ddlPosition.SelectedValue;
            string food_type_id = ddlFoodType.SelectedValue.ToString();
            if (food_type_id != "" && txtName.Text != "" && position != "")
            {
                string insert = "insert into cook(name,position,food_type_id) values(N'" + txtName.Text + "',N'" + position+ "',N'"+ food_type_id + "')";
                data.OperateLine(insert);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('请完善食品信息');</script>");
                return;
            }
            Response.Redirect("cook.aspx");
        }
    }
    protected void lbtReturn_Click(object sender, EventArgs e)
    {
        Response.Write("<script language=javascript>history.go(-2);</script>");
    }
    public void typeBind()
    {
        var dataSource = data.DataTable("select * from food_type");
        ddlFoodType.DataSource = dataSource;
        ddlFoodType.DataValueField = "id";
        ddlFoodType.DataTextField = "name";
        ddlFoodType.DataBind();
    }
}