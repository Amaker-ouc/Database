<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="cook.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div class="new-button">
      <asp:LinkButton ID="lbtAddCook" runat="server" CssClass="btn btn-primary" OnClick="lbtAddCook_Click"><i class="fa fa-plus" ></i> 新增厨师</asp:LinkButton>
    </div>
    <br />

      <asp:Repeater ID="rptCook" runat="server" OnItemCommand="rptCook_ItemCommand" >
                     
          <HeaderTemplate>
             <table class="table">
                    <tr>
                      <th>姓名</th>
                      <th>职位</th>
                      <th>签到</th>
                      <th>分配</th>
                      <th style="width: 3.5em;"></th>
                    </tr>
             
          </HeaderTemplate>
          <ItemTemplate>
               <tr>
                <td><%#Eval("name")%></td> 
                <td><%#Position(Eval("position"))%></td> 
                <td><%#Eval("sign_in")%></td> 
                <td><%#Eval("allocation")%></td>
              
                <td><asp:LinkButton ID="btnChange" runat="server" Text="修改信息" CommandName="edit"
                    CommandArgument='<%#Eval("id") %>'><i class="fa fa-pencil"></i></asp:LinkButton></td>
                <td><asp:LinkButton ID="btnDelete" runat="server" Text="删除" CommandName="delete" 
                    CommandArgument='<%#Eval("id") %>' OnClientClick='<%# "return confirm(\x27确定删除厨师 "+Eval("name")+" 的信息吗？\x27)" %>'><i class="fa fa-trash-o"></i></asp:LinkButton></td>
               
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

