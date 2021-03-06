﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cook : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CookBind();
            FoodBind();
            cookid.InnerText = ddlCook.SelectedValue;           
        }
    }
    public void CookBind()
    {
        ddlCook.DataSource = data.DataTable("select * from cook where position<>1");
        ddlCook.DataTextField = "name";
        ddlCook.DataValueField = "id";
        ddlCook.DataBind();
    }
    public void FoodBind()
    {
        rptFinish.DataSource = data.DataTable("select * from food_orders,food where cook_id=" + ddlCook.SelectedValue + " and state=1 and food_orders.food_id=food.id");
        rptFinish.DataBind();
    }
    protected void ddlCook_SelectedIndexChanged(object sender, EventArgs e)
    {
        FoodBind();
        cookid.InnerText = ddlCook.SelectedValue;
    }
    protected void rptFinish_ItemCommand(object source, RepeaterCommandEventArgs e)
    {

    }
    protected void btnSin_Click(object sender, EventArgs e)
    {
        string id = ddlCook.SelectedValue;
        string update = "update cook set sign_in=1 where id=" + id;
        data.OperateLine(update);
        ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('签到成功');</script>");        
    }
}