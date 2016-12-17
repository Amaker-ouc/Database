<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="cookedit.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="row">
  <div class="col-md-4">
    <br>
    <div id="myTabContent" class="tab-content">
      <div class="tab-pane active in" id="home" >
        <div class="form-group">
        <label>姓名</label>
            <asp:TextBox ID="txtName" runat="server" CssClass="form-control" Width="450px"></asp:TextBox>
        </div>
        <div class="form-group">
        <label>职位</label>
           <asp:DropDownList ID="ddlPosition" runat="server" CssClass="form-control" Width="450px">
                <asp:ListItem Value="1">杂物与清洁</asp:ListItem>
                <asp:ListItem Value="2">厨师</asp:ListItem>
                <asp:ListItem Value="3">主管</asp:ListItem>
          </asp:DropDownList>
        </div>
        <div class="form-group">
        <label>负责菜系</label>
            <asp:DropDownList ID="ddlFoodType" runat="server" CssClass="form-control" Width="450px"></asp:DropDownList>
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

