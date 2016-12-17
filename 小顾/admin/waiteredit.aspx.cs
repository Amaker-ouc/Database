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
                string waiterid = Request.QueryString["id"].ToString();
                string waiterSelect = "select * from waiter where id =" + waiterid;
                var datasource = data.DataTable(waiterSelect);
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
            string position = ddlPosition.SelectedValue;
            if (txtName.Text != "" && position != "")
            {
                string update = "update waiter set name=N'" + txtName.Text + "',position=N'" + position + "' where id =" + id;
                data.OperateLine(update);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('请完善人员信息');</script>");
                return;
            }
            Response.Redirect("waiter.aspx");
        }
        else
        {
            string position = ddlPosition.SelectedValue;
            if ( txtName.Text != "" && position != "")
            {
                string insert = "insert into waiter(name,position) values(N'" + txtName.Text + "',N'" + position + "')";
                data.OperateLine(insert);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('请完善食品信息');</script>");
                return;
            }
            Response.Redirect("waiter.aspx");
        }
    }
    protected void lbtReturn_Click(object sender, EventArgs e)
    {
        Response.Write("<script language=javascript>history.go(-2);</script>");
    }
}