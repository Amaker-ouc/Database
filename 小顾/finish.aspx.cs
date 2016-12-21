using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class finish : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string cookidStr = Request.Form["cookid"];
        string update = "update food_orders set state =1 where id=(select top 1 id from food_orders where cook_id=" + cookidStr + " and state =0)";
        data.OperateLine(update);
        Response.Write("success");
    }
}