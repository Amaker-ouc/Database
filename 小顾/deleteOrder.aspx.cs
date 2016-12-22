using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class deleteOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string foodId = Request.Form["foodId"].ToString();
        List<Order> orders=(List<Order>)Session["orders"];
        for (int i = 0; i<orders.Count; i++)
        {
            if(orders[i].Id==foodId)
            {
                orders.Remove(orders[i]);
                Response.Write("success");
                return;
                
            }
        }
        Response.Write("fail");
    }
}