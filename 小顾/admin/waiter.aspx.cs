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
            waiterBind();
        }
    }
    protected void rptWaiter_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        string id = e.CommandArgument.ToString().Trim();
        if (e.CommandName == "delete")
        {
            string delete = "delete from waiter where id =" + id;
            data.OperateLine(delete);
            waiterBind();

        }
        else if (e.CommandName == "edit")
        {
            Response.Redirect("waiteredit.aspx?id=" + id);
        }
    }
    public void waiterBind()
    {
        var datasource = data.DataTable("select * from waiter order by id desc");
        rptWaiter.DataSource = datasource;
        rptWaiter.DataBind();
    }
    protected void lbtAddWaiter_Click(object sender, EventArgs e)
    {
        Response.Redirect("waiteredit.aspx");
    }
    public string Position(object p)
    {
        string position = p.ToString();
        if (position == "1")
            return "服务员";
        else if (position == "2")
            return "主管";
        else
            return "出错";
    }
}