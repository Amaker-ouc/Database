<%@ Page Language="C#" AutoEventWireup="true" CodeFile="waiter.aspx.cs" Inherits="waiter" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no" />
    <link rel="stylesheet" href="https://apps.bdimg.com/libs/jquerymobile/1.4.5/jquery.mobile-1.4.5.min.css" />
    <script src="https://apps.bdimg.com/libs/jquery/1.10.2/jquery.min.js"></script>
    <script src="https://apps.bdimg.com/libs/jquerymobile/1.4.5/jquery.mobile-1.4.5.min.js"></script>
    <link rel="stylesheet" href="//cdn.static.runoob.com/libs/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="//cdn.static.runoob.com/libs/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <script src="//fast.eager.io/7EYceZSwNz.js"></script>
    <link rel="stylesheet" href="css/waiter.css" />
    <title>小顾</title>
</head>
<body>
    <form runat="server">
    <div data-role="page" id="page-cook">
        <div data-role="navbar" class="nav-top">
            <div class="nav-top-1">
                <p><strong>服务员</strong></p>
            </div>
            <div class="nav-top-2">
                <asp:DropDownList runat="server" ID="ddlWaiter" OnSelectedIndexChanged="ddlWaiter_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                <span id="waiterid" runat="server" style="display:none"></span>
            </div>
            <div class="nav-top-3">
            </div>
        </div>
        <div id="list-all" role="main" class="ui-content list">
            <ul id="list" class="touch ui-listview order-list-ul" data-role="listview" data-icon="false" data-split-icon="delete">
                <asp:Repeater runat="server" ID="rptService">
                    <HeaderTemplate></HeaderTemplate>
                    <ItemTemplate>
                        <li class="ui-li-has-alt ui-first-child">
                            <div class="li-box">
                                <span runat="server" id="order_id" style="display:none"><%#Eval("order_id")%></span>
                                <p class="room-table"><%#Eval("name")%>-----第<%#Eval("id")%>号餐桌</p>
                                <p class="state">服务中</p>
                            </div>
                        </li>
                    </ItemTemplate>
                    <FooterTemplate></FooterTemplate>
                </asp:Repeater>
            </ul>
        </div>
        <!-- /popup -->
        <div class="ui-screen-hidden ui-popup-screen ui-overlay-inherit" id="confirm-screen"></div>
        <div class="ui-popup-container ui-popup-hidden ui-popup-truncate" id="confirm-popup">
            <div id="confirm" class="ui-content ui-popup ui-body-a ui-overlay-shadow ui-corner-all" data-role="popup" data-theme="a">
                <p id="room_table"></p>
                <p id="question">确定完成？</p>
                <div class="ui-grid-a">
                    <div class="ui-block-a">
                        <a id="finish" class="ui-btn ui-corner-all ui-mini ui-btn-a" data-rel="back">确定</a>
                    </div>
                    <div class="ui-block-b">
                        <a id="cancel" class="ui-btn ui-corner-all ui-mini ui-btn-a" data-rel="back">取消</a>
                    </div>
                </div>
            </div>
        </div>
        <!-- new food -->
        <div class="ui-popup-container ui-popup-hidden ui-popup-truncate">
            <div id="newServicePop" class="ui-content ui-popup ui-body-a ui-overlay-shadow ui-corner-all" data-role="popup" data-theme="a">
                <p id="newService"></p>
                <p id="tip">客人已到，请服务</p>
                <div class="ui-grid-a">
                    <a id="confirm_id" class="ui-btn ui-corner-all ui-mini ui-btn-a" data-rel="back">确定</a>
                    <span runat="server" id="orderid" style="display:none"></span>
                </div>
            </div>
        </div>
        <script src="js/waiter.js"></script>
    </div>
</form>
</body>
</html>
