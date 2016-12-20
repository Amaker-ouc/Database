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
        if (Session["orders"] == null)
        {
            List<Order> orders = new List<Order>();
            Session["orders"] = orders;
        }
        var datasource = data.DataTable("select * from food_type where id<>1 order by id desc");
        rptType.DataSource = datasource;
        rptType.DataBind();
        if (Request.QueryString["type_id"] != null)
        {
            string id = Request.QueryString["type_id"].ToString();
            var datasource2 = data.DataTable("select * from food where recomend<>2 and food_type_id=" + id);
            rptFood.DataSource = datasource2;
            rptFood.DataBind();
        }
        else
        {
            var datasource2 = data.DataTable("select * from food where recomend<>2");
            rptFood.DataSource = datasource2;
            rptFood.DataBind();
        }

    }
    protected void rptType_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName.ToString() == "type")
        {
            var datasource = data.DataTable("select * from food where recomend<>2 and food_type_id=" + e.CommandArgument.ToString());
            rptFood.DataSource = datasource;
            rptFood.DataBind();
        }
    }
}