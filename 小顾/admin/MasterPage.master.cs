using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["adminAccount"] == null)
            {
                Response.Redirect("login.aspx");
            }
        }
        labAdminName.InnerText = Session["adminAccount"].ToString();
    }
}
