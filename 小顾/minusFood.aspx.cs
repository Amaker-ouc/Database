﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class minusFood : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string foodId = Request.Form["foodId"].ToString();
        List<Order> orders = (List<Order>)Session["orders"];
        for (int i = 0; i < orders.Count; i++)
        {
            if (orders[i].Id == foodId)
            {
                if(orders[i].Num==1){
                    orders.Remove(orders[i]);
                    Response.Write("0|0");
                    return;
                }
                else
                {
                    orders[i].Num--;
                    double price = orders[i].Price * orders[i].Num;
                    Response.Write(orders[i].Num.ToString() + "|" + price.ToString());
                    return;
                }
                
            }
        }
        Response.Write("0|0");
    }
}