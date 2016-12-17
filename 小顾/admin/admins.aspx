<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="admins.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
          
<div class="btn-toolbar list-toolbar">
    <a href="addadmins.aspx" class="btn btn-primary"><i class="fa fa-plus"></i> 新增管理员</a>
  <div class="btn-group">
  </div>
</div>

      <asp:Repeater ID="rptAdmins" runat="server" OnItemCommand="rptAdmins_ItemCommand1">
                     
          <HeaderTemplate>
             <table class="table">
                    <tr>
                      <th>帐号</th>
                      <th>权限</th>
                      <th style="width: 3.5em;"></th>
                    </tr>
             
          </HeaderTemplate>
          <ItemTemplate>
               <tr>
                <td><%#Eval("account")%></td> 
                <td><%#Eval("power")%></td> 
                <td><asp:LinkButton ID="BtnChange" runat="server" Text="修改密码" CommandName="edit"
                    CommandArgument='<%#Eval("id") %>' OnClientClick='<%# "return confirm(\x27确定修改管理员 "+Eval("account")+" 吗？\x27)" %>'><i class="fa fa-pencil"></i></asp:LinkButton></td>
                <td><asp:LinkButton ID="BtnDelete" runat="server" Text="删除" CommandName="delete" 
                    CommandArgument='<%#Eval("id") %>' OnClientClick='<%# "return confirm(\x27确定删除管理员 "+Eval("account")+" 吗？\x27)" %>'><i class="fa fa-trash-o"></i></asp:LinkButton></td>
               
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


<div class="modal small fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
  <div class="modal-dialog">
    <div class="modal-content">
        <div class="modal-header">
            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">×</button>
            <h3 id="myModalLabel">Delete Confirmation</h3>
        </div>
        <div class="modal-body">
            <p class="error-text"><i class="fa fa-warning modal-icon"></i>Are you sure you want to delete the user?<br>This cannot be undone.</p>
        </div>
        <div class="modal-footer">
            <button class="btn btn-default" data-dismiss="modal" aria-hidden="true">Cancel</button>
            <button class="btn btn-danger" data-dismiss="modal">Delete</button>
        </div>
      </div>
    </div>
</div>



</asp:Content>

