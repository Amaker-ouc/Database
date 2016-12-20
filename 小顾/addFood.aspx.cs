using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class addFood : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string foodId=Request.Form["foodId"].ToString();
        var datasource = data.DataTable("select * from food where id=" + foodId);
        Order order = new Order();
        order.Id = foodId;
        order.Num = 1;
        order.Price = Convert.ToDouble(datasource.Rows[0]["price"]);
        order.Name = datasource.Rows[0]["name"].ToString();
        List<Order> orders = (List<Order>)Session["orders"];
        for (int i = 0; i < orders.Count; i++)
        {
            if (orders[i].Id == foodId)
            {
                orders[i].Num++;
                double price = orders[i].Price * orders[i].Num;
                Response.Write(orders[i].Num.ToString()+"|"+price.ToString());
                //Response.Write("<num>"+orders[i].Num.ToString()+"</num><price>"+price.ToString()+"</price>");
                return;
            }
        }
        orders.Add(order);
        Response.Write(order.Num.ToString() + "|" + order.Price.ToString());
    }
}