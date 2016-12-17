<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="foodedit.aspx.cs" Inherits="admin_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="row">
  <div class="col-md-4">
    <br>
    <div id="myTabContent" class="tab-content">
      <div class="tab-pane active in" id="home" >
        <div class="form-group">
        <label>名称</label>
            <asp:TextBox ID="txtName" runat="server" CssClass="form-control" Width="450px"></asp:TextBox>
        </div>
        <div class="form-group">
        <label>价格</label>
            <asp:TextBox ID="txtPrice" runat="server" CssClass="form-control" Width="450px"></asp:TextBox>
        </div>
        <div class="form-group">
        <label>菜系</label>
            <asp:DropDownList ID="ddlFoodType" runat="server" CssClass="form-control" Width="450px"></asp:DropDownList>
        </div>

          <div class="form-group">
        <label>商品图片</label>
            <asp:FileUpload ID="fulPicture" runat="server" CssClass="form-control" Width="450px" />
            <asp:Label ID="labState" runat="server"> </asp:Label>
              <asp:ImageMap ID="impGoods" runat="server" Width="20em" Height="16em" Visible="false"></asp:ImageMap>
        </div>
        <label>类型</label>
            <asp:DropDownList ID="ddlRecomend" runat="server" CssClass="form-control" Width="450px">
                <asp:ListItem Value="0">普通</asp:ListItem>
                <asp:ListItem Value="1">推荐</asp:ListItem>
                <asp:ListItem Value="2">轮播</asp:ListItem>
          </asp:DropDownList>
        </div>
        <br />
    <div class="btn-toolbar list-toolbar">
        <asp:LinkButton ID="lbtSave" runat="server" CssClass="btn btn-primary" OnClick="lbtSave_Click"><i class="fa fa-save" ></i> 保存</asp:LinkButton>
        <span style="width:30px"></span>
         <asp:LinkButton ID="lbtReturn" runat="server" CssClass="btn btn-primary" OnClick="lbtReturn_Click"> 返回</asp:LinkButton>
    </div>
  </div>
      </div>
      </div>

</asp:Content>

