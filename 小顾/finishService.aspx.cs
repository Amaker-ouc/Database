using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class finishService : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string order_id = Request.Form["order_id"];
        string update = "update orders set state=2 where id=" + order_id;
        data.OperateLine(update);
        Response.Write("success");
    }
}