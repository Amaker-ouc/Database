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
            cookBind();
            waiterBind();
        }
    }

    public void waiterBind()
    {
        var dataSource = data.DataTable("select * from waiter");
        rptWaiter.DataSource = dataSource;
        rptWaiter.DataBind();
    }
    public void cookBind()
    {
        var dataSource = data.DataTable("select * from cook");
        rptCook.DataSource = dataSource;
        rptCook.DataBind();
    }
   
    protected void refresh_Click(object sender, EventArgs e)
    {
        cookBind();
    }
    protected void refresh2_Click(object sender, EventArgs e)
    {
        waiterBind();
    }
    protected void rptUsers_ItemCommand(object source, RepeaterCommandEventArgs e)
    {

    }
    protected void rptOrder_ItemCommand(object source, RepeaterCommandEventArgs e)
    {

    }
}