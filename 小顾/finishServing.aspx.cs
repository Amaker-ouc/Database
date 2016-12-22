using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class finishServing : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string food_order_id = Request.Form["food_order_id"];
        string update = "update food_orders set state=2 where id="+food_order_id;
        data.OperateLine(update);
        Response.Write("success");
    }
}