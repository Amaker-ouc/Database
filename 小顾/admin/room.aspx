<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="room.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <div class="new-button">
      <asp:LinkButton ID="lbtAddRoom" runat="server" CssClass="btn btn-primary" OnClick="lbtAddRoom_Click" ><i class="fa fa-plus" ></i> 新增房间</asp:LinkButton>
    </div>
    <br />

      <asp:Repeater ID="rptRoom" runat="server" OnItemCommand="rptRoom_ItemCommand" >
                     
          <HeaderTemplate>
             <table class="table">
                    <tr>
                      <th>房间号</th>
                      <th>房间名</th>
                      <th>容纳量</th>
                      <th>类型</th>
                      <th style="width: 3.5em;"></th>
                    </tr>
             
          </HeaderTemplate>
          <ItemTemplate>
               <tr>
                <td><%#Eval("id")%></td> 
                <td><%#Eval("name")%></td> 
                <td><%#Eval("size")%></td> 
                <td><%#RoomType(Eval("room_type"))%></td>
              
                <td><asp:LinkButton ID="btnChange" runat="server" Text="修改信息" CommandName="edit"
                    CommandArgument='<%#Eval("id") %>'><i class="fa fa-pencil"></i></asp:LinkButton></td>
                <td><asp:LinkButton ID="btnDelete" runat="server" Text="删除" CommandName="delete" 
                    CommandArgument='<%#Eval("id") %>' OnClientClick='<%# "return confirm(\x27确定删除房间 "+Eval("name")+" 的信息吗？\x27)" %>'><i class="fa fa-trash-o"></i></asp:LinkButton></td>
               
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

