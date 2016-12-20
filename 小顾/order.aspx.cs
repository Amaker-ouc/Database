using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class order : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            OrderBind();
            double sum = 0;
            List<Order> orders = (List<Order>)Session["orders"];
            for (int i = 0; i < orders.Count; i++)
            {
                sum +=orders[i].Price*orders[i].Num;
            }
            sumPrice.InnerText = sum.ToString();
            ddlRoom.DataSource = data.DataTable("select * from room");
            ddlRoom.DataValueField = "id";
            ddlRoom.DataTextField = "name";
            ddlRoom.DataBind();
            ddlTable.DataSource = data.DataTable("select * from dining_table where room_id=" + ddlRoom.SelectedValue+"and isUse=0");
            ddlTable.DataValueField = "id";
            ddlTable.DataTextField = "id";
            ddlTable.DataBind();

        }
    }
    public void OrderBind()
    {
        if (Session["orders"] != null)
        {
            List<Order> orders = (List<Order>)Session["orders"];
            rptOrder.DataSource = orders;
            rptOrder.DataBind();
        }
    }

    protected void lbtOrder_Click(object sender, EventArgs e)
    {
        List<Order> orders = (List<Order>)Session["orders"];
        for (int i = 0; i < orders.Count; i++)
        {
            DateTime date=DateTime.Now;
            string insert="insert into orders values('"+ddlTable.SelectedValue+"',N'"+date+"')";
            data.OperateLine(insert);
            string order_id=data.DataTable("select * from orders order by id desc").Rows[0]["id"].ToString();
            string cook_id=data.DataTable("select * from cook where food_type_id='" + orders[i].Type_id + "'order by allocation").Rows[0]["id"].ToString();
            string insert2 = "insert into food_orders (food_id,orders_id,cook_id) values('" + orders[i].Id + "','" + order_id + "','" + cook_id + "')";
            data.OperateLine(insert2);
        }
    }
}