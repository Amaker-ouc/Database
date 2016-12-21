using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            var datasource = data.DataTable("select * from advertisement order by id desc");
            imgAd1.Src = "upload/foodPicture/" + datasource.Rows[0]["picture"].ToString();
            imgAd2.Src = "upload/foodPicture/" + datasource.Rows[1]["picture"].ToString();
            imgAd3.Src = "upload/foodPicture/" + datasource.Rows[2]["picture"].ToString();
            lblAd1.Text = datasource.Rows[0]["adcontent"].ToString();
            lblAd2.Text = datasource.Rows[1]["adcontent"].ToString();
            lblAd3.Text = datasource.Rows[2]["adcontent"].ToString();
            var datasource2 = data.DataTable("select * from food where recomend =1 order by id desc");
            rptRecomend.DataSource = datasource2;
            rptRecomend.DataBind();
            var datasource3 = data.DataTable("select * from food where recomend =2 order by id desc");
            rptSwiper.DataSource = datasource3;
            rptSwiper.DataBind();
            if (Session["orders"] == null)
            {
                List<Order> orders = new List<Order>();
                Session["orders"] = orders;
            }
        }

    }
    protected void lbtfind_Click(object sender, EventArgs e)
    {
        Response.Redirect("cook.aspx");
    }


}