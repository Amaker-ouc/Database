using System;
using System.Activities.Statements;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class order : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            OrderBind();
            double sum = 0;
            if (Session["orders"] == null)
            {
                List<Order> orders2 = new List<Order>();
                Session["orders"] = orders2;
            }

            else
            {

                List<Order> orders = (List<Order>)Session["orders"];
                for (int i = 0; i < orders.Count; i++)
                {
                    sum += orders[i].Price * orders[i].Num;
                }
                sumPrice.InnerText = sum.ToString();
                RoomBind();
                TableBind();
                
            }
        }
       
    }
    public void OrderBind()
    {
        if (Session["orders"] != null)
        {
            List<Order> orders = (List<Order>)Session["orders"];
            rptOrder.DataSource = orders;
            rptOrder.DataBind();
        }
    }
    public void RoomBind()
    {
        ddlRoom.DataSource = data.DataTable("select * from room");
        ddlRoom.DataValueField = "id";
        ddlRoom.DataTextField = "name";
        ddlRoom.DataBind();
    }
    public void TableBind()
    {
        ddlTable.DataSource = data.DataTable("select *,cast(id as varchar(50))+N'号桌------' +cast(size as varchar(50))+N'人' as idsize from dining_table where room_id=" + ddlRoom.SelectedValue + "and isUse=0");
        ddlTable.DataValueField = "id";
        ddlTable.DataTextField = "idsize";
        ddlTable.DataBind();
    }
    protected void lbtOrder_Click(object sender, EventArgs e)
    {
        List<Order> orders = (List<Order>)Session["orders"];
        if (orders.Count!=0)
        {
            if (ddlTable.SelectedValue != "")
            {
                if (data.DataTable("select isUse from dining_table where id=" + ddlTable.SelectedValue).Rows[0][0].ToString() == "0")
                {
                    DateTime date = DateTime.Now;
                    string waiter_id = data.DataTable("select * from waiter where position=1 and sign_in=1 order by allocation").Rows[0]["id"].ToString();
                    string insert = "insert into orders(dining_table_id,order_time,waiter_id) values('" + ddlTable.SelectedValue + "',N'" + date +"',N'" + waiter_id + "')";
                    data.OperateLine(insert);
                    string update = "update dining_table set isUse=1 where id=" + ddlTable.SelectedValue;
                    data.OperateLine(update);
                    string update2 = "update waiter set allocation=allocation+1 where id=" + waiter_id;
                    data.OperateLine(update2);
                    for (int i = 0; i < orders.Count; i++)
                    {
                        string order_id = data.DataTable("select * from orders order by id desc").Rows[0]["id"].ToString();
                        string cook_id = data.DataTable("select * from cook where food_type_id='" + orders[i].Type_id + "' and sign_in=1 order by allocation").Rows[0]["id"].ToString();
                        string insert2 = "insert into food_orders (food_id,orders_id,cook_id) values('" + orders[i].Id + "','" + order_id + "','" + cook_id + "')";
                        for (int j = 0; j < orders[i].Num; j++)
                        {
                            data.OperateLine(insert2);
                        }
                        string update3 = "update cook set allocation=allocation+" + orders[i].Num.ToString() + " where id =" + cook_id;
                        data.OperateLine(update3);
                    }
                    List<Order> orders2 = new List<Order>();
                    Session["orders"] = orders2;
                    ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('下单成功');</script>");
                    OrderBind();
                    TableBind();
                }
                else
                    ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('餐桌已用');</script>");
            }
            else
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('请选择餐桌');</script>");        

        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('请点菜');</script>");
        }
    }
    protected void ddlRoom_SelectedIndexChanged(object sender, EventArgs e)
    {
        TableBind();
    }
}