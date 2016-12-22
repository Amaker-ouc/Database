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
            else
            {
                string power = data.DataTable("select * from admins where account=N'" + Session["adminAccount"].ToString() + "'").Rows[0]["power"].ToString();
                if (power != "1")
                {
                    aAdmins.Visible = false;
                    aAdmins2.Visible = false;
                }
            }
        }
        labAdminName.InnerText = Session["adminAccount"].ToString();
    }
}
