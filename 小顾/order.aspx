﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="order.aspx.cs" Inherits="order" %>

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
    <div data-role="page" id="page-order">
        <div data-role="navbar" class="nav-top">
            <div class="nav-top-1">
                <p><strong>订单</strong></p>
            </div>
            <div class="nav-top-2">
            </div>
            <div class="nav-top-3">
            </div>
        </div>
        <!-- !-->
        <div style="position: relative">
            <div data-role="collapsible">
                <h4>选菜</h4>
                <div role="banner" class="ui-header ui-bar-a  slidedown">
                    <h1 class="ui-title" role="heading" aria-level="1">全选</h1>
                    <a id="delete-all" href="#" data-icon="delete" data-iconpos="notext" class="ui-link ui-btn-right ui-btn ui-icon-delete ui-btn-icon-notext ui-shadow ui-corner-all" data-role="button" role="button"></a>
                </div>
                <div id="list-all" role="main" class="ui-content order-list">
                    <ul id="list" class="touch ui-listview order-list-ul" data-role="listview" data-icon="false" data-split-icon="delete">
                        <li class="ui-li-has-alt ui-first-child">
                            <div class="order-list-li-box">
                                <div class="order-list-pic-box">
                                    <div class="thumbnail">
                                        <img src="img/recommend.jpg" alt="recommend" />
                                    </div>
                                </div>
                                <div class="order-list-content-box">
                                    <p>扬州炒饭</p>
                                    <div class="order-list-content-changenum">
                                        <div class="order-list-content-changenum-price">
                                            <p><span>￥</span><span>25.00</span></p>
                                        </div>
                                        <div class="order-list-content-changenum-btn">
                                            <a data-role="button" class="ui-btn ui-icon-plus ui-btn-icon-notext ui-corner-all"></a>
                                            <input type="text" disabled="disabled" />
                                            <a data-role="button" class="ui-btn ui-icon-minus ui-btn-icon-notext ui-corner-all"></a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="order-list-li-delete-box">
                                <a href="#" class="delete ui-btn ui-btn-icon-notext ui-icon-delete" title="Delete"></a>
                            </div>
                        </li>
                        <li class="ui-li-has-alt ui-first-child">
                            <div class="order-list-li-box">
                                <div class="order-list-pic-box">
                                    <div class="thumbnail">
                                        <img src="img/recommend.jpg" alt="recommend" />
                                    </div>
                                </div>
                                <div class="order-list-content-box">
                                    <p>扬州炒饭</p>
                                    <div class="order-list-content-changenum">
                                        <div class="order-list-content-changenum-price">
                                            <p><span>￥</span><span>25.00</span></p>
                                        </div>
                                        <div class="order-list-content-changenum-btn">
                                            <a data-role="button" class="ui-btn ui-icon-plus ui-btn-icon-notext ui-corner-all"></a>
                                            <input type="text" disabled="disabled" />
                                            <a data-role="button" class="ui-btn ui-icon-minus ui-btn-icon-notext ui-corner-all"></a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="order-list-li-delete-box">
                                <a href="#" class="delete ui-btn ui-btn-icon-notext ui-icon-delete" title="Delete"></a>
                            </div>
                        </li>
                        <li class="ui-li-has-alt ui-first-child">
                            <div class="order-list-li-box">
                                <div class="order-list-pic-box">
                                    <div class="thumbnail">
                                        <img src="img/recommend.jpg" alt="recommend" />
                                    </div>
                                </div>
                                <div class="order-list-content-box">
                                    <p>扬州炒饭</p>
                                    <div class="order-list-content-changenum">
                                        <div class="order-list-content-changenum-price">
                                            <p><span>￥</span><span>25.00</span></p>
                                        </div>
                                        <div class="order-list-content-changenum-btn">
                                            <a data-role="button" class="ui-btn ui-icon-plus ui-btn-icon-notext ui-corner-all"></a>
                                            <input type="text" disabled="disabled" />
                                            <a data-role="button" class="ui-btn ui-icon-minus ui-btn-icon-notext ui-corner-all"></a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="order-list-li-delete-box">
                                <a href="#" class="delete ui-btn ui-btn-icon-notext ui-icon-delete" title="Delete"></a>
                            </div>
                        </li>
                        <li class="ui-li-has-alt ui-first-child">
                            <div class="order-list-li-box">
                                <div class="order-list-pic-box">
                                    <div class="thumbnail">
                                        <img src="img/recommend.jpg" alt="recommend" />
                                    </div>
                                </div>
                                <div class="order-list-content-box">
                                    <p>扬州炒饭</p>
                                    <div class="order-list-content-changenum">
                                        <div class="order-list-content-changenum-price">
                                            <p><span>￥</span><span>25.00</span></p>
                                        </div>
                                        <div class="order-list-content-changenum-btn">
                                            <a data-role="button" class="ui-btn ui-icon-plus ui-btn-icon-notext ui-corner-all"></a>
                                            <input type="text" disabled="disabled" />
                                            <a data-role="button" class="ui-btn ui-icon-minus ui-btn-icon-notext ui-corner-all"></a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="order-list-li-delete-box">
                                <a href="#" class="delete ui-btn ui-btn-icon-notext ui-icon-delete" title="Delete"></a>
                            </div>
                        </li>
                        <li class="ui-li-has-alt ui-first-child">
                            <div class="order-list-li-box">
                                <div class="order-list-pic-box">
                                    <div class="thumbnail">
                                        <img src="img/recommend.jpg" alt="recommend" />
                                    </div>
                                </div>
                                <div class="order-list-content-box">
                                    <p>扬州炒饭</p>
                                    <div class="order-list-content-changenum">
                                        <div class="order-list-content-changenum-price">
                                            <p><span>￥</span><span>25.00</span></p>
                                        </div>
                                        <div class="order-list-content-changenum-btn">
                                            <a data-role="button" class="ui-btn ui-icon-plus ui-btn-icon-notext ui-corner-all"></a>
                                            <input type="text" disabled="disabled" />
                                            <a data-role="button" class="ui-btn ui-icon-minus ui-btn-icon-notext ui-corner-all"></a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="order-list-li-delete-box">
                                <a href="#" class="delete ui-btn ui-btn-icon-notext ui-icon-delete" title="Delete"></a>
                            </div>
                        </li>

                    </ul>
                </div>
            </div>
            <!-- /content -->
            <div style="display: none;" id="confirm-placeholder">
                <!-- placeholder for confirm -->
            </div>
            <!-- /popup -->
            <div class="ui-screen-hidden ui-popup-screen ui-overlay-inherit" id="confirm-screen"></div>
            <div class="ui-popup-container ui-popup-hidden ui-popup-truncate" id="confirm-popup">
                <div id="confirm" class="ui-content ui-popup ui-body-a ui-overlay-shadow ui-corner-all" data-role="popup" data-theme="a">
                    <p id="question">确定删除？</p>
                    <div class="ui-grid-a">
                        <div class="ui-block-a">
                            <a id="yes" class="ui-btn ui-corner-all ui-mini ui-btn-a" data-rel="back">确定</a>
                        </div>
                        <div class="ui-block-b">
                            <a id="cancel" class="ui-btn ui-corner-all ui-mini ui-btn-a" data-rel="back">取消</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!--order-list !-->
        <div style="position: relative">
            <div data-role="collapsible">
                <h4>选座</h4>
            </div>
        </div>
        <!--table !-->
        <div style="position: relative">
            <div data-role="collapsible">
                <h4>联系信息</h4>
                <div class="information">
                    <span>尊姓:</span>
                    <input placeholder="尊姓" value="" type="text" />
                    <span>称呼：</span>
                    <select name="call">
                        <option value="sir">先生</option>
                        <option value="lady">女士</option>
                    </select>
                    <span>联系手机:</span>
                    <input placeholder="手机号码" value="" type="text" />
                </div>
            </div>
        </div>
    <div class="confirm-buy">
        <p class="sum-price"><span>￥</span><span>100.00</span></p>
        <a class="ui-btn ui-btn-a buy">下单</a>
    </div>
    <div class="row nav-bottom clearfix text-center">
        <div class="col-xs-4 nav-item">
            <div class="nav-item-up ">
                <a href="default.aspx" data-ajax="false">
                    <img src="img/home.png" />
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
        <div class="col-xs-4 nav-item nav-bottom-active">
            <div class="nav-item-up">
                <a href="#">
                    <img src="img/list-active.png" />
                </a>
            </div>
            <div class="nav-item-bottom">订单</div>
        </div>
    </div>
    <script src="Swiper-3.4.0/dist/js/swiper.min.js"></script>
    <script src="js/newjs3.js"></script>
    </div>
</body>
</html>
