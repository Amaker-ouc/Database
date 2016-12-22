using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Text; 

public partial class admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["id"] != null)
            {
                string select = "select * from admins where id =" + Request.QueryString["id"].ToString();
                var dataSource = data.DataTable(select);
                txtAccount.Text = dataSource.Rows[0]["account"].ToString();
            }
        }
    }
    protected void lbtSave_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] == null)
        {
            string accountSelect = "select * from admins where account =N'" + txtAccount.Text + "'";
            int isAccount = data.DataTable(accountSelect).Rows.Count;

            if (isAccount == 0&&txtPassword.Text!=""&&txtPassword.Text==txtPasswordConfirm.Text)
            {
                string password = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text, "MD5");
                string insert = "insert into admins (account,password,power) values (N'" + txtAccount.Text + "',N'" + password + "','2')";
                data.OperateLine(insert);
                Server.Transfer("admins.aspx");
            }
            else if(txtPassword.Text=="")
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('密码不能为空');</script>");
            else if (txtPassword.Text != txtPasswordConfirm.Text)
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('两次密码输入不一致');</script>");
            else
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('账户已存在');</script>");
            

        }
        else
        {
            string id = Request.QueryString["id"].ToString();
            string select = "select * from admins where id<>" + id + "and account=N'" + txtAccount.Text+"'";
            if (data.DataTable(select).Rows.Count == 0)
            {
                string password = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text, "MD5");
                string update = "update admins set account=N'" + txtAccount.Text + "',password=N'" + password + "' where id=" + id;
                data.OperateLine(update);
                Server.Transfer("admins.aspx");
            }
            else
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('账户已存在');</script>");
        }
    }

    protected void lbtReturn_Click(object sender, EventArgs e)
    {
        Response.Write("<script language=javascript>history.go(-2);</script>");
    }
}