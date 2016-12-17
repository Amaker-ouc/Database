$(document).ready(function () {
    $(".ui-body-d").css({
        "border": "0",
        "background": "none",
    })
    $("input.ui-body-d").css({
        "background": "#ffffff",
    })
    $(".ui-page").css({
        "padding-top": "50px",
        "padding-bottom": "50px",
    })
    $(".ui-body-a").css({
        "border":"0",
    })
    var h = window.screen.height
    h=0.3*h
    $(".swiper-container").css({
        "height":h.toString(),
    })
    $(".swiper-slide img").css({
        "height": h.toString(),
    })
    $(".ui-bar-a").css({
        "background": "none",
        "border": "0",
    })
    $("body").css({
        "background": "#dbdbdb",
        "font-family": "Arial,Microsoft YaHei,黑体,宋体,sans-serif",
    })
    $(".col-xs-4").css({
        "padding": "0.5px 0.5px 0.5px 0.5px",
    })
    $(".col-xs-12").css({
        "padding": "0.5px 2px 0.5px 2px",
    })
    $(".thumbnail").css({
        "padding": "0",
        "margin":"0"
    })
    $(".caption").css({
        "padding": "5px 5px 0px 5px",
        "margin": "0"
    })
    $(".caption span").css({
        "color":"#ff0000"
    })
    $(".recommend-box p").css({
        "margin": "0 0 2px",
        "font-size":"14px"
    })
    $(".row").css({
        "margin-left": "-0.5px",
        "margin-right": "-0.5px",
    })
    $("div.nav-top a").removeClass("ui-btn uibtn-up-d ui-btn-inline")
    
});


window.onload = function () {
    var swiper = new Swiper('.swiper-container', {
        pagination: '.swiper-pagination',
        paginationClickable: true,
        spaceBetween:10,
        centeredSlides: true,
        autoplay: 2500,
        autoplayDisableOnInteraction: false
    });
}