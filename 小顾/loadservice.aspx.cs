using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class loadservice : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string waiteridStr = Request.Form["waiterid"];
        string select = "select room.name,dining_table.id,orders.id as order_id from orders,dining_table,room where waiter_id=" + waiteridStr + " and state = 0 and orders.dining_table_id=dining_table.id and dining_table.room_id=room.id";
        if (data.DataTable(select).Rows.Count >= 1)
        {
            string roomName = data.DataTable(select).Rows[0]["name"].ToString();
            string table_id = data.DataTable(select).Rows[0]["id"].ToString();
            string order_id = data.DataTable(select).Rows[0]["order_id"].ToString();
            Response.Write(roomName + "-----" +"第"+ table_id +"号餐桌"+ "|" + order_id);
        }
        else
            Response.Write("none");
    }
}