using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            cookBind();
        }
    }
    protected void rptCook_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        string id = e.CommandArgument.ToString().Trim();
        if (e.CommandName == "delete")
        {
            string delete = "delete from cook where id =" + id;
            data.OperateLine(delete);
            cookBind();

        }
        else if (e.CommandName == "edit")
        {
            Response.Redirect("cookedit.aspx?id=" + id);
        }
    }
    public void cookBind()
    {
        var datasource = data.DataTable("select * from cook order by id desc");
        rptCook.DataSource = datasource;
        rptCook.DataBind();
    }

    protected void lbtAddCook_Click(object sender, EventArgs e)
    {
        Response.Redirect("cookedit.aspx");
    }
    public string Position(object p)
    {
        string position = p.ToString();
        if (position == "1")
            return "杂物与清洁";
        else if (position == "2")
            return "厨师";
        else if (position == "3")
            return "主管";
        else
            return "出错";
    }
}