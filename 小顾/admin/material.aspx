<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="material.aspx.cs" Inherits="admin_Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="new-button">
        <asp:DropDownList ID="ddlFoodType" runat="server" CssClass="form-control" Width="450px" OnSelectedIndexChanged="ddlFoodType_SelectedIndexChanged" AutoPostBack="true" /> 
    </div>
    <br>
      <asp:Repeater ID="rptMaterial" runat="server" >                   
          <HeaderTemplate>
             <table class="table">
                    <tr>
                      <th>菜名</th>
                      <th>价格</th>
                      <th>图片</th>
                      <th>数量</th>
                      <th style="width: 3.5em;"></th>
                    </tr>
             
          </HeaderTemplate>
          <ItemTemplate>
               <tr>
                <td><%#Eval("name")%></td> 
                <td><%#Eval("price")%></td> 
                <td><asp:ImageMap ID="impGoods" runat="server" ImageUrl='<%# "../upload/foodPicture/"+Eval("picture") %>' Width="8em" Height="6em"></asp:ImageMap></td> 
                <td><asp:TextBox runat="server" ID="txtNum">30</asp:TextBox></td> 
                <td><asp:TextBox  runat="server" Visible="false" id="txtID" Text='<%#Eval("id")%>'></asp:TextBox></td>              
              </tr>

          </ItemTemplate>                 
          <FooterTemplate>
              </table>
          </FooterTemplate>
      </asp:Repeater>
    <asp:LinkButton ID="lbtAddMaterial" runat="server" CssClass="btn btn-primary" OnClick="lbtAddMaterial_Click"><i class="fa fa-plus" ></i> 添加原料</asp:LinkButton>
</asp:Content>

