using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Serving : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string waiter_id = Request.Form["waiterid"];
        string select = "select food_orders.id as food_order_id, food.name as food_name,room.name as room_name,dining_table.id as dining_table_id from orders,food_orders,food,room,dining_table where orders.waiter_id="
            +waiter_id+" and food_orders.orders_id=orders.id and food_orders.food_id=food.id and orders.dining_table_id=dining_table.id and dining_table.room_id=room.id and food_orders.state=1";
        DataTable dt= data.DataTable(select);
        if (dt.Rows[0]["food_name"].ToString() != "")
        {
            string food_name = dt.Rows[0]["food_name"].ToString();
            string room_name = dt.Rows[0]["room_name"].ToString();
            string dining_table_id = dt.Rows[0]["dining_table_id"].ToString();
            string food_order_id = dt.Rows[0]["food_order_id"].ToString();
            Response.Write(room_name + "-----第" + dining_table_id + "号餐桌" + "|" + food_name + "|" + food_order_id);
        }
    }
}