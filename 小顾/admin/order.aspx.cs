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
            ordersBind();
        }
    }
    public void ordersBind()
    {
        var datasource = data.DataTable("select * from orders order by id desc,state asc");
        rptRoom.DataSource = datasource;
        rptRoom.DataBind();
    }
    protected void lbtAddRoom_Click(object sender, EventArgs e)
    {
        Response.Redirect("roomedit.aspx");
    }
    public string OrdersState(object s)
    {
        string state = s.ToString();
        if (state == "0")
            return "未受理";
        else if (state == "1")
            return "已有服务员受理";
        else if (state == "2")
            return "菜已上齐";
        else if (state == "3")
            return "订单完结";
        else
            return "信息错误";
    }
    public string OrdersWaiter(object i)
    {
        string id = i.ToString();
        if (i != null)
        {
            return "无";
        }
        else
        {
            string name = data.DataTable("select name from waiter where id=" + id).Rows[0]["name"].ToString();
            return name;
        }
    }
    protected void rptRoom_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        string id = e.CommandArgument.ToString().Trim();
        if (e.CommandName == "delete")
        {
            string delete = "delete from orders where id =" + id;
            data.OperateLine(delete);
            ordersBind();
        }
        else if (e.CommandName == "edit")
        {
            string update = "update orders set state=3 where id =" + id;
            data.OperateLine(update);
            ordersBind();
        }
    }
}