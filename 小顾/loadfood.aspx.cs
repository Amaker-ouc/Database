using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;

public partial class loadfood : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string cookidStr = Request.Form["cookid"];
        string select = "select name from food_orders,food where cook_id=" + cookidStr +" and state=0 and food.id=food_orders.food_id";
        if (data.DataTable(select).Rows.Count >= 1)
        {
            string foodName = data.DataTable(select).Rows[0]["name"].ToString();
            Response.Write(foodName);
        }
        else
            Response.Write("none");
    }
}