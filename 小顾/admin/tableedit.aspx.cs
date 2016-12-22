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
            if (Request.QueryString["id"] != null)
            {
                string tabelid = Request.QueryString["id"].ToString();
                string tableSelect = "select * from dining_table where id =" + tabelid;
                var datasource = data.DataTable(tableSelect);
                txtID.Text = tabelid;
                txtSize.Text = datasource.Rows[0]["size"].ToString();
                ddlRoom.SelectedValue = datasource.Rows[0]["room_id"].ToString();
            }
        }
    }
    protected void lbtSave_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] != null)
        {
            string id = Request.QueryString["id"].ToString();
            if (txtID.Text == id && txtSize.Text != "" && ddlRoom.SelectedValue != "")
            {
                string update = "update dining_table set size=N'" + txtSize.Text + "',room_id=N'" + ddlRoom.SelectedValue + "' where id =" + id;
                data.OperateLine(update);
                roomSize(ddlRoom.SelectedValue);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('请完善餐桌信息');</script>");
                return;
            }
            Response.Redirect("table.aspx");
        }
        else
        {
            if (txtID.Text != "" && txtSize.Text != "" && ddlRoom.SelectedValue != "")
            {
                if (data.DataTable("select * from dining_table where id =" + txtID.Text).Rows.Count == 0)
                {
                    string insert = "insert into dining_table(id,size,room_id) values(N'" + txtID.Text + "',N'" + txtSize.Text + "',N'" + ddlRoom.SelectedValue + "')";
                    data.OperateLine(insert);
                    roomSize(ddlRoom.SelectedValue);
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('桌号已存在');</script>");
                    return;
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('请完善餐桌信息');</script>");
                return;
            }
            Response.Redirect("table.aspx");
        }
    }
    protected void lbtReturn_Click(object sender, EventArgs e)
    {
        Response.Write("<script language=javascript>history.go(-2);</script>");
    }
    public void roomBind()
    {
        var dataSource = data.DataTable("select * from room");
        ddlRoom.DataSource = dataSource;
        ddlRoom.DataValueField = "id";
        ddlRoom.DataTextField = "id";
        ddlRoom.DataBind();
    }
    public void roomSize(string room_id)
    {
        string size= data.DataTable("select SUM(size) from dining_table where room_id=" + room_id).Rows[0][0].ToString();
        string update = "update room set size=N'" + size + "' where id =" + room_id;
        data.OperateLine(update);
    }
}