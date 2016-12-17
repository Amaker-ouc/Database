using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            tableBind();
        }
    }
    protected void rptTable_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        string id = e.CommandArgument.ToString().Trim();
        if (e.CommandName == "delete")
        {
            string delete = "delete from dining_table where id =" + id;
            data.OperateLine(delete);
            tableBind();

        }
        else if (e.CommandName == "edit")
        {
            Response.Redirect("tableedit.aspx?id=" + id);
        }
    }
    public void tableBind()
    {
        var datasource = data.DataTable("select * from dining_table order by id desc");
        rptTable.DataSource = datasource;
        rptTable.DataBind();
    }
    protected void lbtAddTable_Click(object sender, EventArgs e)
    {
        Response.Redirect("tableedit.aspx");
    }
}