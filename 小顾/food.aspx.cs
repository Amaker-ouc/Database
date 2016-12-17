using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class food : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            var datasource = data.DataTable("select * from food_type");
            rptType.DataSource = datasource;
            rptType.DataBind();
            var datasource2 = data.DataTable("select * from food");
        }
    }
}