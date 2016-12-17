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
            roomBind();
        }
    }

    protected void rptRoom_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        string id = e.CommandArgument.ToString().Trim();
        if (e.CommandName == "delete")
        {
            string delete = "delete from room where id =" + id;
            data.OperateLine(delete);
            roomBind();

        }
        else if (e.CommandName == "edit")
        {
            Response.Redirect("roomedit.aspx?id=" + id);
        }
    }
    public void roomBind()
    {
        var datasource = data.DataTable("select * from room order by id desc");
        rptRoom.DataSource = datasource;
        rptRoom.DataBind();
    }
    protected void lbtAddRoom_Click(object sender, EventArgs e)
    {
        Response.Redirect("roomedit.aspx");
    }
    public string RoomType(object s)
    {
        string type = s.ToString();
        if (type == "1")
            return "小包";
        else if (type == "2")
            return "大包";
        else if (type == "3")
            return "大厅";
        else
            return "信息错误";
    }
}