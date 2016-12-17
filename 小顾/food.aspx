<%@ Page Language="C#" AutoEventWireup="true" CodeFile="food.aspx.cs" Inherits="food" %>

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
    <title>小顾</title>
</head>
<body>
    <form runat="server">
    <div data-role="page" id="page-food">
        <div data-role="navbar" class="nav-top">
            <div class="nav-top-1">
                <p><strong>小顾</strong></p>
            </div>
            <div class="nav-top-2">
                <input type="search" placeholder="搜索喜欢的美食吧" />
            </div>
            <div class="nav-top-3">
                <a href="#classify" data-icon="bars" data-iconpos="notext"></a>
            </div>
        </div>
        <div data-role="panel" data-display="push" id="classify" data-position="right">
            <ul id="classify-ul" data-role="listview">
                <li id="classify-choose"><a>选择菜式</a></li>
                <asp:Repeater runat="server" ID="rptType">
                    <HeaderTemplate><table></HeaderTemplate>
                    <ItemTemplate>
                        <li><asp:LinkButton runat="server" CommandArgument="type" CommandName="type"><%#Eval("name") %><a runat="server" data-rel="close"></a></asp:LinkButton></li>
                    </ItemTemplate>
                    <FooterTemplate></table></FooterTemplate>
                </asp:Repeater>
            </ul>
        </div>
        <!-- /panel -->
        <div class="row clearfix">
            <div class="col-xs-12 column">
                <div class="row">
                    <div class="col-xs-4 col-sm-3 col-lg-2 recommend-box">
                        <div class="thumbnail">
                            <a href="#recommend1" data-rel="popup" data-position-to="window" data-transition="fade">
                                <img src="img/recommend.jpg" alt="recommend" />
                                <div class="caption">
                                    <p>描述</p>
                                    <p>
                                        <span>￥</span>
                                    </p>
                                </div>
                            </a>
                        </div>
                    </div>
                    <div class="col-xs-4 col-sm-3 col-lg-2 recommend-box">
                        <div class="thumbnail">
                            <a href="#recommend1" data-rel="popup" data-position-to="window" data-transition="fade">
                                <img src="img/recommend.jpg" alt="recommend" />
                                <div class="caption">
                                    <p>描述</p>
                                    <p>
                                        <span>￥</span>
                                    </p>
                                </div>
                            </a>
                        </div>
                    </div>
                    <div class="col-xs-4 col-sm-3 col-lg-2 recommend-box">
                        <div class="thumbnail">
                            <a href="#recommend1" data-rel="popup" data-position-to="window" data-transition="fade">
                                <img src="img/recommend.jpg" alt="recommend" />
                                <div class="caption">
                                    <p>描述</p>
                                    <p>
                                        <span>￥</span>
                                    </p>
                                </div>
                            </a>
                        </div>
                    </div>
                    <div class="col-xs-4 col-sm-3 col-lg-2 recommend-box">
                        <div class="thumbnail">
                            <a href="#recommend1" data-rel="popup" data-position-to="window" data-transition="fade">
                                <img src="img/recommend.jpg" alt="recommend" />
                                <div class="caption">
                                    <p>描述</p>
                                    <p>
                                        <span>￥</span>
                                    </p>
                                </div>
                            </a>
                        </div>
                    </div>
                    <div class="col-xs-4 col-sm-3 col-lg-2 recommend-box">
                        <div class="thumbnail">
                            <a href="#recommend1" data-rel="popup" data-position-to="window" data-transition="fade">
                                <img src="img/recommend.jpg" alt="recommend" />
                                <div class="caption">
                                    <p>描述</p>
                                    <p>
                                        <span>￥</span>
                                    </p>
                                </div>
                            </a>
                        </div>
                    </div>
                    <div class="col-xs-4 col-sm-3 col-lg-2 recommend-box">
                        <div class="thumbnail">
                            <a href="#recommend1" data-rel="popup" data-position-to="window" data-transition="fade">
                                <img src="img/recommend.jpg" alt="recommend" />
                                <div class="caption">
                                    <p>描述</p>
                                    <p>
                                        <span>￥</span>
                                    </p>
                                </div>
                            </a>
                        </div>
                    </div>
                    <div class="col-xs-4 col-sm-3 col-lg-2 recommend-box">
                        <div class="thumbnail">
                            <a href="#recommend1" data-rel="popup" data-position-to="window" data-transition="fade">
                                <img src="img/recommend.jpg" alt="recommend" />
                                <div class="caption">
                                    <p>描述</p>
                                    <p>
                                        <span>￥</span>
                                    </p>
                                </div>
                            </a>
                        </div>
                    </div>
                    <div class="col-xs-4 col-sm-3 col-lg-2 recommend-box">
                        <div class="thumbnail">
                            <a href="#recommend1" data-rel="popup" data-position-to="window" data-transition="fade">
                                <img src="img/recommend.jpg" alt="recommend" />
                                <div class="caption">
                                    <p>描述</p>
                                    <p>
                                        <span>￥</span>
                                    </p>
                                </div>
                            </a>
                        </div>
                    </div>
                    <div class="col-xs-4 col-sm-3 col-lg-2 recommend-box">
                        <div class="thumbnail">
                            <a href="#recommend1" data-rel="popup" data-position-to="window" data-transition="fade">
                                <img src="img/recommend.jpg" alt="recommend" />
                                <div class="caption">
                                    <p>描述</p>
                                    <p>
                                        <span>￥</span>
                                    </p>
                                </div>
                            </a>
                        </div>
                    </div>
                    <div class="col-xs-4 col-sm-3 col-lg-2 recommend-box">
                        <div class="thumbnail">
                            <a href="#recommend1" data-rel="popup" data-position-to="window" data-transition="fade">
                                <img src="img/recommend.jpg" alt="recommend" />
                                <div class="caption">
                                    <p>描述</p>
                                    <p>
                                        <span>￥</span>
                                    </p>
                                </div>
                            </a>
                        </div>
                    </div>
                    <div class="col-xs-4 col-sm-3 col-lg-2 recommend-box">
                        <div class="thumbnail">
                            <a href="#recommend1" data-rel="popup" data-position-to="window" data-transition="fade">
                                <img src="img/recommend.jpg" alt="recommend" />
                                <div class="caption">
                                    <p>描述</p>
                                    <p>
                                        <span>￥</span>
                                    </p>
                                </div>
                            </a>
                        </div>
                    </div>
                    <div class="col-xs-4 col-sm-3 col-lg-2 recommend-box">
                        <div class="thumbnail">
                            <a href="#recommend1" data-rel="popup" data-position-to="window" data-transition="fade">
                                <img src="img/recommend.jpg" alt="recommend" />
                                <div class="caption">
                                    <p>描述</p>
                                    <p>
                                        <span>￥</span>
                                    </p>
                                </div>
                            </a>
                        </div>
                    </div>
                    <div data-role="popup" id="recommend1" data-overlay-theme="d" data-theme="d" data-corners="false">
                        <a href="#" data-rel="back" class="ui-btn ui-corner-all ui-btn-a ui-icon-delete ui-btn-icon-notext ui-btn-right">Close</a>
                        <img class="popphoto" src="img/recommend.jpg" style="max-height: 512px;" />
                        <div class="caption">
                            <p>描述</p>
                            <p>
                                <span>￥</span>
                            </p>
                            <div class="buy-bar">
                                <div class="buy-add">
                                    <a href="#" class="ui-btn ui-corner-all ui-icon-plus ui-btn-icon-notext ui-btn-inline">Plus</a>
                                </div>
                                <div class="buy-num">
                                    <input type="text" readonly="true" />
                                </div>
                                <div class="buy-minus">
                                    <a href="#" class="ui-btn ui-corner-all ui-icon-minus ui-btn-icon-notext ui-btn-inline">Minus</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="row nav-bottom clearfix text-center">
            <div class="col-xs-4 nav-item">
                <div class="nav-item-up ">
                    <a href="default.aspx"  data-ajax="false">
                        <img src="img/home.png" />
                    </a>
                </div>
                <div class="nav-item-bottom">小顾</div>
            </div>
            <div class="col-xs-4 nav-item  nav-bottom-active">
                <div class="nav-item-up">
                    <a href="#">
                        <img src="img/cutlery-active.png" />
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
