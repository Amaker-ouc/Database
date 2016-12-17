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
        int cookid = Convert.ToInt16(cookidStr);
        Response.Write("hello");
    }
}