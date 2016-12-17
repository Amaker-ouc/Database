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
            noticeBind();
        }
    }
    protected void rptNotice_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        string id = e.CommandArgument.ToString().Trim();
        if (e.CommandName == "delete")
        {
            string delete = "delete from advertisement where id =" + id;
            data.OperateLine(delete);
            noticeBind();
        }
        else if (e.CommandName == "edit")
        {
            Response.Redirect("advertisementedit.aspx?id=" + id);
        }
    }
    public void noticeBind()
    {
        var dataSource = data.DataTable("select * from advertisement");
        rptNotice.DataSource = dataSource;
        rptNotice.DataBind();
    }
}