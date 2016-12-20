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
            var datasource=data.DataTable("select * from advertisement order by id desc");
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
        }
    }
    protected void lbtfind_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin/index.aspx");
    }
    protected void lbtAdd_Click(object sender, EventArgs e)
    {
        txtFoodNum.Value = (Convert.ToInt32(txtFoodNum.Value)+1).ToString();
        string id = spanID.InnerText;
        var datasource = data.DataTable("select * from food where id ='" + id+"'");
        Order order = new Order();
        order.Id = id;
        order.Name = datasource.Rows[0]["name"].ToString();
        order.Price = Convert.ToInt32(datasource.Rows[0]["price"]);
        order.Num = Convert.ToInt32(txtFoodNum.Value);
        if (Session["order"] == null)
        {
            List<Order> orders = new List<Order>();
            orders.Add(order);
            Session["order"] = orders;
        }
        else
        {
            List<Order> orders = (List<Order>)Session["order"];
            Order orderResult = orders.Find(
            (o)=>
            {
                return o.Id == id;
            });
            if (orderResult != null)
                orderResult.Num++;
            else
                orders.Add(order);
        }
        
    }
    protected void lbtMinus_Click(object sender, EventArgs e)
    {
        if (Convert.ToInt32(txtFoodNum.Value) > 1)
        {
            txtFoodNum.Value = (Convert.ToInt32(txtFoodNum.Value) - 1).ToString();
            string id = spanID.InnerText;
            var datasource = data.DataTable("select * from food where id =" + id);
            Order order = new Order();
            order.Id = id;
            order.Name = datasource.Rows[0]["name"].ToString();
            order.Price = Convert.ToInt32(datasource.Rows[0]["price"]);
            order.Num = Convert.ToInt32(txtFoodNum.Value);
            if (Session["order"] == null)
            {
                List<Order> orders = new List<Order>();
                orders.Add(order);
                Session["order"] = orders;
            }
            else
            {
                List<Order> orders = (List<Order>)Session["order"];
                Order orderResult = orders.Find(
                (o) =>
                {
                    return o.Id == id;
                });
                if (orderResult != null)
                    orderResult.Num--;
                else
                    orders.Add(order);
            }
        }
    }
}