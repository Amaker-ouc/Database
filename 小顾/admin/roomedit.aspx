<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="roomedit.aspx.cs" Inherits="admin_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="row">
  <div class="col-md-4">
    <br>
    <div id="myTabContent" class="tab-content">
      <div class="tab-pane active in" id="home" >
        <div class="form-group">
        <label>房间号</label>
            <asp:TextBox ID="txtID" runat="server" CssClass="form-control" Width="450px"></asp:TextBox>
        </div>
        <div class="form-group">
        <label>房间名</label>
            <asp:TextBox ID="txtName" runat="server" CssClass="form-control" Width="450px"></asp:TextBox>
        </div>
        <div class="form-group">
        <label>类型</label>
           <asp:DropDownList ID="ddlType" runat="server" CssClass="form-control" Width="450px">
                <asp:ListItem Value="1">小包</asp:ListItem>
                <asp:ListItem Value="2">大包</asp:ListItem>
                <asp:ListItem Value="3">大厅</asp:ListItem>
          </asp:DropDownList>
        </div>
    
        <br />
    <div class="btn-toolbar list-toolbar">
        <asp:LinkButton ID="lbtSave" runat="server" CssClass="btn btn-primary" OnClick="lbtSave_Click" ><i class="fa fa-save" ></i> 保存</asp:LinkButton>
        <span style="width:30px"></span>
         <asp:LinkButton ID="lbtReturn" runat="server" CssClass="btn btn-primary" OnClick="lbtReturn_Click" > 返回</asp:LinkButton>
    </div>
  </div>
      </div>
      </div>
</div>
</asp:Content>

