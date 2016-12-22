<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="order.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
      <asp:Repeater ID="rptRoom" runat="server" OnItemCommand="rptRoom_ItemCommand" >
                     
          <HeaderTemplate>
             <table class="table">
                    <tr>
                      <th>订单号</th>
                      <th>桌号</th>
                      <th>下单时间</th>
                      <th>状态</th>
                      <th style="width: 3.5em;"></th>
                    </tr>
             
          </HeaderTemplate>
          <ItemTemplate>
               <tr>
                <td><%#Eval("id")%></td> 
                <td><%#Eval("dining_table_id")%></td> 
                <td><%#Eval("order_time")%></td> 
                <td><%#OrdersState(Eval("room_type"))%></td>  
                <td><%#OrdersWaiter(Eval("waiter_id"))%></td>                           
                <td><asp:LinkButton ID="btnChange" runat="server" Text="修改信息" CommandName="edit"
                    CommandArgument='<%#Eval("id") %>' OnClientClick='<%# "return confirm(\x27确定订单 "+Eval("id")+" 已完结么？\x27)" %>'><i class="fa fa-pencil"></i></asp:LinkButton></td>
                <td><asp:LinkButton ID="btnDelete" runat="server" Text="删除" CommandName="delete" 
                    CommandArgument='<%#Eval("id") %>' OnClientClick='<%# "return confirm(\x27确定删除订单 "+Eval("id")+" 的信息吗？\x27)" %>'><i class="fa fa-trash-o"></i></asp:LinkButton></td>
               
              </tr>

          </ItemTemplate>                 
          <FooterTemplate>
              </table>
          </FooterTemplate>
      </asp:Repeater>

</asp:Content>

