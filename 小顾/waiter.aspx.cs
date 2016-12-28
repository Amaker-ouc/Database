using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class waiter : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            WaiterBind();
            ServiceBind();
            waiterid.InnerText = ddlWaiter.SelectedValue;
        }
    }
    public void WaiterBind()
    {
        ddlWaiter.DataSource = data.DataTable("select * from waiter where position=1");
        ddlWaiter.DataTextField = "name";
        ddlWaiter.DataValueField = "id";
        ddlWaiter.DataBind();
    }
    public void ServiceBind()
    {
        if (ddlWaiter.SelectedValue != "")
        {
            rptService.DataSource = data.DataTable("select room.name,dining_table.id,orders.id as order_id from orders,dining_table,room where waiter_id=" + ddlWaiter.SelectedValue + " and state = 1 and orders.dining_table_id=dining_table.id and dining_table.room_id=room.id");
            rptService.DataBind();
        }
    }
    protected void ddlWaiter_SelectedIndexChanged(object sender, EventArgs e)
    {
        ServiceBind();
        waiterid.InnerText = ddlWaiter.SelectedValue;
    }
    protected void rptService_ItemCommand(object source, RepeaterCommandEventArgs e)
    {

    }
    protected void btnSin_Click(object sender, EventArgs e)
    {
        string id = ddlWaiter.SelectedValue;
        string update = "update waiter set sign_in=1 where id=" + id;
        data.OperateLine(update);
    }
}