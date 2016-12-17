<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="advertisementedit.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="row">
  <div class="col-md-4">
    <br>
    <div id="myTabContent" class="tab-content">
      <div class="tab-pane active in" id="home">
        <div class="form-group">
          <label>内容</label>
          <textarea id="txtArticle" runat="server" rows="15" name="content" class="form-control"></textarea>
        </div>     
          <div class="form-group">
            <label>商品图片</label>
            <asp:FileUpload ID="fulPicture" runat="server" CssClass="form-control" Width="450px" />
            <asp:Label ID="labState" runat="server"> </asp:Label>
              <asp:ImageMap ID="impGoods" runat="server" Width="20em" Height="16em" Visible="false"></asp:ImageMap>
        </div>
      </div>
    </div>
    <div class="btn-toolbar list-toolbar">
        <asp:LinkButton ID="lbtSave" runat="server" CssClass="btn btn-primary" OnClick="lbtSave_Click"><i class="fa fa-save"></i>保存</asp:LinkButton>
       <a class="btn btn-primary" href="javascript:history.go(-1);">返回</a>
    </div>
  </div>
</div>


</asp:Content>

