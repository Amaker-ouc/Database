<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="table.aspx.cs" Inherits="admin_Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <div class="new-button">
      <asp:LinkButton ID="lbtAddTable" runat="server" CssClass="btn btn-primary" OnClick="lbtAddTable_Click" ><i class="fa fa-plus" ></i> 新增餐桌</asp:LinkButton>
    </div>
    <br />

      <asp:Repeater ID="rptTable" runat="server" OnItemCommand="rptTable_ItemCommand" >
                     
          <HeaderTemplate>
             <table class="table">
                    <tr>
                      <th>餐桌号</th>
                      <th>大小</th>
                      <th>房间号</th>
                      <th style="width: 3.5em;"></th>
                    </tr>
             
          </HeaderTemplate>
          <ItemTemplate>
               <tr>
                <td><%#Eval("id")%></td> 
                <td><%#Eval("size")%></td> 
                <td><%#Eval("room_id")%></td> 
              
                <td><asp:LinkButton ID="btnChange" runat="server" Text="修改信息" CommandName="edit"
                    CommandArgument='<%#Eval("id") %>'><i class="fa fa-pencil"></i></asp:LinkButton></td>
                <td><asp:LinkButton ID="btnDelete" runat="server" Text="删除" CommandName="delete" 
                    CommandArgument='<%#Eval("id") %>' OnClientClick='<%# "return confirm(\x27确定删除餐桌" + Eval("id")+"的信息吗？\x27)" %>'><i class="fa fa-trash-o"></i></asp:LinkButton></td>
               
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

