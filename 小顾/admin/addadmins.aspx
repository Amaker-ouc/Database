<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="addadmins.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <script>
        function checkUser() {
            var name = document.getElementById("name").value;
            var account = document.getElementById("account").value;
            var password = document.getElementById("password").value;
            if (name == "") {
                alert("用户名不能为空");
                return false;
            }
            if (account == "") {
                alert("帐号不能为空");
                return false;
            }
            if (password == "") {
                alert("密码不能为空");
                return false;
            } else {
                return true;
            }
        }
</script>

<div class="row">
  <div class="col-md-4">
    <br>
    <div id="myTabContent" class="tab-content">
      <div class="tab-pane active in" id="home" >

        <div class="form-group">
        <label>帐号</label>
            <asp:TextBox ID="txtAccount" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
        <label>密码</label>
            <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
        </div>
      </div>
        <div class="form-group">
        <label>确认密码</label>
            <asp:TextBox ID="txtPasswordConfirm" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
        </div>
    <div class="btn-toolbar list-toolbar">
        <asp:LinkButton ID="lbtSave" runat="server" CssClass="btn btn-primary" OnClick="lbtSave_Click"><i class="fa fa-save" ></i> 保存</asp:LinkButton>
         <span style="width:30px"></span>
         <asp:LinkButton ID="lbtReturn" runat="server" CssClass="btn btn-primary" OnClick="lbtReturn_Click"> 返回</asp:LinkButton>
    </div>
  </div>
      </div>
    </div>
</asp:Content>

