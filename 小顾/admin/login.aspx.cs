using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            
        }
    }
    protected void lbtLogin_Click(object sender, EventArgs e)
    {
        string password = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text, "MD5");
        string select = "select * from admins where account='" + txtAccount.Text + "'and password='" + password +"'";
        if(data.DataTable(select).Rows.Count==0)
        {
            //Response.Write("<script>alert('帐号或密码不正确');</script>");
            ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('帐号或密码不正确');</script>"); 
        }
        else
        {
            Session["adminAccount"] = txtAccount.Text;
            ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('登陆成功');</script>");
            Response.Redirect("index.aspx");
        }
    }
}