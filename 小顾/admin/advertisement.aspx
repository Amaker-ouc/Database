<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="advertisement.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
            
<div class="btn-toolbar list-toolbar">
    <a href="advertisementedit.aspx" class="btn btn-primary"><i class="fa fa-plus"></i> 发布公告</a>
  <div class="btn-group">
  </div>
</div>
     <asp:Repeater ID="rptNotice" runat="server" OnItemCommand="rptNotice_ItemCommand">
                     
          <HeaderTemplate>
             <table class="table">
                    <tr>
                      <th>内容</th>
                      <th style="width: 3.5em;"></th>
                    </tr>
             
          </HeaderTemplate>
          <ItemTemplate>
               <tr>
                <td><%#Eval("adcontent")%></td> 
                  <td><asp:LinkButton ID="lbtNoticeEdit" runat="server" CommandArgument='<%#Eval("id") %>' CommandName="edit"><i class="fa fa-pencil"></i></asp:LinkButton>
                      <asp:LinkButton ID="lbtNoticeDel" runat="server" CommandArgument='<%#Eval("id") %>' CommandName="delete" OnClientClick="del()"><i class="fa fa-trash-o"></i></asp:LinkButton></td>
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

