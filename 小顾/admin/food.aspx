<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="food.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="new-button">
      <asp:DropDownList ID="ddlFoodType" runat="server" CssClass="form-control" Width="450px" OnSelectedIndexChanged="ddlFoodType_SelectedIndexChanged" AutoPostBack="true" /> 
        <span style="width:40px"></span>
      <asp:LinkButton ID="lbtAddFood" runat="server" CssClass="btn btn-primary" OnClick="lbtAddFood_Click"><i class="fa fa-plus" ></i> 新增食品</asp:LinkButton>
    </div>
    <br>

      <asp:Repeater ID="rptGoods" runat="server" OnItemCommand="rptGoods_ItemCommand" >
                     
          <HeaderTemplate>
             <table class="table">
                    <tr>
                      <th>菜名</th>
                      <th>价格</th>
                      <th>图片</th>
                      <th style="width: 3.5em;"></th>
                    </tr>
             
          </HeaderTemplate>
          <ItemTemplate>
               <tr>
                <td><%#Eval("name")%></td> 
                <td><%#Eval("price")%></td> 
                <td><asp:ImageMap ID="impGoods" runat="server" ImageUrl='<%# "../upload/foodPicture/"+Eval("picture") %>' Width="8em" Height="6em"></asp:ImageMap></td> 
                <td><asp:LinkButton ID="btnChange" runat="server" Text="修改信息" CommandName="edit"
                    CommandArgument='<%#Eval("id") %>'><i class="fa fa-pencil"></i></asp:LinkButton></td>
                <td><asp:LinkButton ID="btnDelete" runat="server" Text="删除" CommandName="delete" 
                    CommandArgument='<%#Eval("id") %>' OnClientClick='<%# "return confirm(\x27确定删除商品 "+Eval("name")+" 吗？\x27)" %>'><i class="fa fa-trash-o"></i></asp:LinkButton></td>
               
              </tr>

          </ItemTemplate>                 
          <FooterTemplate>
              </table>
          </FooterTemplate>
      </asp:Repeater>

      
<script type="text/javascript">
    function del() {
        if (!confirm("确认要删除？")) {
            window.event.returnValue = false;
        }
    }
</script>
</asp:Content>

