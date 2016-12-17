using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["id"] != null)
            {
                string roomid = Request.QueryString["id"].ToString();
                string roomSelect = "select * from room where id =" + roomid;
                var datasource = data.DataTable(roomSelect);
                txtID.Text = datasource.Rows[0]["id"].ToString();
                txtName.Text = datasource.Rows[0]["name"].ToString();
                ddlType.SelectedValue = datasource.Rows[0]["room_type"].ToString();
            }
        }
    }
    protected void lbtSave_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] != null)
        {
            string id = Request.QueryString["id"].ToString();
            string type = ddlType.SelectedValue;
            if (txtID.Text == id && txtName.Text != "" && type != "")
            {
                string update = "update room set name=N'" + txtName.Text + "',room_type=N'" + type + "' where id =" + id;
                data.OperateLine(update);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('请完善房间信息');</script>");
                return;
            }
            Response.Redirect("room.aspx");
        }
        else
        {
            string type = ddlType.SelectedValue;
            if (txtID.Text != "" && txtName.Text != "" && type != "")
            {
                if (data.DataTable("select * from room where id =" + txtID.Text).Rows.Count == 0)
                {
                    string insert = "insert into room(id,name,room_type) values(N'" + txtID.Text + "',N'" + txtName.Text + "',N'" + type + "')";
                    data.OperateLine(insert);
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('房间号已存在');</script>");
                    return;
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('请完善房间信息');</script>");
                return;
            }
            Response.Redirect("room.aspx");
        }
    }
    protected void lbtReturn_Click(object sender, EventArgs e)
    {
        Response.Write("<script language=javascript>history.go(-2);</script>");
    }
   
}