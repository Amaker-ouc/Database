using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            adminsBind();
        }
    }
    public void adminsBind()
    {
        var dataSource= data.DataTable("select * from admins");
        rptAdmins.DataSource = dataSource;
        rptAdmins.DataBind();
    }

    protected void rptAdmins_ItemCommand1(object source, RepeaterCommandEventArgs e)
    { 
        string id = e.CommandArgument.ToString().Trim();
        if (e.CommandName == "delete")
        {         
            string delete = "delete from admins where id ="+id;
            data.OperateLine(delete);
            adminsBind();
        }
        else if(e.CommandName=="edit")
        {
            Server.Transfer("addadmins.aspx?id=" + id);
        }
    }
}