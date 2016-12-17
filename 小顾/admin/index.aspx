<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        
  <div class="row">
    <div class="col-sm-6 col-md-6">
        <div class="panel panel-default">
            <div class="panel-heading no-collapse">
            <span class="panel-icon pull-right">
                    
                    <asp:LinkButton ID="refresh" runat="server" OnClick="refresh_Click"><i class="fa fa-refresh"></i></asp:LinkButton>
                </span>
         厨师
        </div> 
      <asp:Repeater ID="rptCook" runat="server" OnItemCommand="rptUsers_ItemCommand">
                     
          <HeaderTemplate>
                <table class="table table-bordered table-striped">
                    <tr>
                      <th>姓名</th>
                      <th>签到</th>
                      <th>状态</th>
                    </tr>
             
          </HeaderTemplate>
          <ItemTemplate>
               <tr>
                <td><%#Eval("name")%></td> 
                <td><%#Eval("sign_in")%></td> 
                <td><%#Eval("allocation")%></td> 
              </tr>
          </ItemTemplate>                 
          <FooterTemplate>
              </table>
          </FooterTemplate>
      </asp:Repeater>
        </div>

</div>

<div class="row">
    <div class="col-sm-6 col-md-6">
        <div class="panel panel-default"> 
            <div class="panel-heading no-collapse">
                <span class="panel-icon pull-right">
                    
                    <asp:LinkButton ID="refresh2" runat="server" OnClick="refresh2_Click"><i class="fa fa-refresh"></i></asp:LinkButton>
                </span>

                服务员
            </div>
         
              <asp:Repeater ID="rptWaiter" runat="server" OnItemCommand="rptOrder_ItemCommand">
                     
          <HeaderTemplate>
                  <table class="table list">
                    <tr>
                      <th>姓名</th>
                      <th>签到</th>
                      <th>状态</th>
                    </tr>
             
          </HeaderTemplate>
          <ItemTemplate>
               <tr>
                <td><%#Eval("name")%></td> 
                <td><%#Eval("sign_in")%></td> 
                <td><%#Eval("allocation")%></td> 
              </tr>
          </ItemTemplate>                 
          <FooterTemplate>
              </table>
          </FooterTemplate>
      </asp:Repeater>
          </div>
</div>
</div>
     </div>
</asp:Content>

