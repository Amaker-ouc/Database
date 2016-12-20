<%@ Page Language="C#" AutoEventWireup="true" CodeFile="default.aspx.cs" Inherits="Default2" %>

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
    <link rel="stylesheet" href="css/newstyle3.css" />
    <link rel="stylesheet" href="Swiper-3.4.0/dist/css/swiper.min.css" />
    <title>小顾</title>
</head>
<body>
    <form runat="server">
        <div data-role="page" id="page-default">
            <div data-role="navbar" class="nav-top" id="nav-top">
                <div class="nav-top-1">
                    <p><strong>小顾</strong></p>
                </div>
                <div class="nav-top-2">
                    <input type="search" placeholder="搜索喜欢的美食吧" />
                </div>
                <div class="nav-top-3">
                    <asp:LinkButton runat="server" ID="lbtfind" OnClick="lbtfind_Click"><img src="img/search-ico.png" /></asp:LinkButton>
                </div>
            </div>
            <div class="swiper-container" id="swiper-container">
                <div class="swiper-wrapper">
                    <asp:Repeater runat="server" ID="rptSwiper">
                        <HeaderTemplate>
                            <table>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <div class="swiper-slide">
                                <img src="upload/foodPicture/<%#Eval("picture") %>" />
                            </div>
                        </ItemTemplate>
                        <FooterTemplate></table></FooterTemplate>
                    </asp:Repeater>
                </div>
                <div class="swiper-pagination"></div>
            </div>
            <div class="ui-grid-b introduce">


                <div class="ui-block-a ">
                    <div class="ui-bar ui-bar-a">
                        <div class="introduce-item">
                            <img alt="Free Shipping" runat="server" id="imgAd1" src="#" />
                            <p>
                                <asp:Label runat="server" ID="lblAd1"></asp:Label>
                            </p>
                        </div>
                    </div>
                </div>
                <div class="ui-block-b">
                    <div class="ui-bar ui-bar-a ">
                        <div class="introduce-item">
                            <img alt="Free Shipping" runat="server" id="imgAd2" src="#" />
                            <p>
                                <asp:Label runat="server" ID="lblAd2"></asp:Label>
                            </p>
                        </div>
                    </div>
                </div>
                <div class="ui-block-c ">
                    <div class="ui-bar ui-bar-a">
                        <div class="introduce-item">
                            <img alt="Free Shipping" runat="server" id="imgAd3" src="#" />
                            <p>
                                <asp:Label runat="server" ID="lblAd3"></asp:Label>
                            </p>
                        </div>
                    </div>
                </div>

            </div>
            <div class="row clearfix">
                <div class="col-xs-12 column">
                    <div class="row">
                        <asp:Repeater runat="server" ID="rptRecomend">
                            <HeaderTemplate>
                                <table>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <div class="col-xs-4 col-sm-3 col-lg-2 recommend-box">
                                    <div class="thumbnail">
                                        <a href="#recommend" data-rel="popup" data-position-to="window" data-transition="fade" class="pic-box">
                                            <span class="id_hide" runat="server"><%#Eval("id") %></span>
                                            <img src="upload/foodPicture/<%#Eval("picture") %>" alt="recommend" />
                                            <div class="caption">
                                                <p class="discribe"><%#Eval("name") %></p>
                                                <p>
                                                    <span>￥</span><span class="price"><%#Eval("price") %></span>
                                                </p>
                                            </div>
                                        </a>
                                    </div>
                                </div>
                            </ItemTemplate>
                            <FooterTemplate></table></FooterTemplate>
                        </asp:Repeater>


                        <div data-role="popup" id="recommend" data-overlay-theme="d" data-theme="d" data-corners="false">
                            <a data-rel="back" class="ui-btn ui-corner-all ui-icon-delete ui-btn-icon-notext ui-btn-right"></a>
                            <span class="id_hide" runat="server" id="spanID"></span>
                            <img class="popphoto" src="img/recommend.jpg" style="max-height: 512px;" />
                            <p class="discribe">描述</p>
                            <div class="pop-discribe">
                                <p><span>￥</span><span id="price" class="price"></span>
                                </p>
                                <div class="buy-bar">
                                    <div class="buy-add">
                                        <a id="lbtAdd" class="ui-btn ui-icon-plus ui-btn-icon-notext ui-corner-all" ></a>
                                    </div>
                                    <div class="buy-num">
                                        <input type="text" readonly="true" runat="server" id="txtFoodNum" value="1" />
                                    </div>
                                    <div class="buy-minus">

                                        <a  id="lbtMinus" class="ui-btn ui-icon-minus ui-btn-icon-notext ui-corner-all" ></a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row nav-bottom clearfix text-center">
                <div class="col-xs-4 nav-item nav-bottom-active">
                    <div class="nav-item-up ">
                        <a href="#">
                            <img src="img/home-active.png" />
                        </a>
                    </div>
                    <div class="nav-item-bottom">小顾</div>
                </div>
                <div class="col-xs-4 nav-item  ">
                    <div class="nav-item-up">
                        <a href="food.aspx" data-ajax="false">
                            <img src="img/cutlery.png" />
                        </a>
                    </div>
                    <div class="nav-item-bottom">美食</div>
                </div>
                <div class="col-xs-4 nav-item">
                    <div class="nav-item-up">
                        <a href="order.aspx" data-ajax="false">
                            <img src="img/list.png" />
                        </a>
                    </div>
                    <div class="nav-item-bottom">订单</div>
                </div>
            </div>
            <script src="Swiper-3.4.0/dist/js/swiper.min.js"></script>
            <script src="js/newjs3.js"></script>

        </div>
    </form>
</body>
</html>

