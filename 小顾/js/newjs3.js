function swiper() {
    var swiper = new Swiper('.swiper-container', {
        pagination: '.swiper-pagination',
        paginationClickable: true,
        spaceBetween: 10,
        centeredSlides: true,
        autoplay: 2500,
        autoplayDisableOnInteraction: false
    });
}
function loadpage() {
    $(".nav-top a").removeClass("ui-btn uibtn-up-d ui-btn-inline")
    $(".nav-top div.ui-input-search").removeClass("ui-shadow-inset ui-input-has-clear ")
    var h = window.screen.height
    h = 0.3 * h
    $(".swiper-container").css({
        "height": h.toString(),
    })
    $(".swiper-slide img").css({
        "height": h.toString(),
    })
    swiper();
}

$(document).on("pagecreate", "#page-default", function () {
    var h = window.screen.height
    h = 0.3 * h
    $(".swiper-container").css({
        "height": h.toString(),
    })
    $(".swiper-slide img").css({
        "height": h.toString(),
    })
    $(".nav-top a").removeClass("ui-btn uibtn-up-d ui-btn-inline")
    $(".nav-top div.ui-input-search").removeClass("ui-shadow-inset ui-input-has-clear ")
    setTimeout("swiper()", 1000)
    $(".ui-popup").removeClass("ui-overlay-shadow")
    $(".swiper-pagination-bullet-active").css({
        "color":"red !important"
    })
    $(document).on("click", "div.thumbnail a", function () {
        var id_hide = $(this).find("span.id_hide").text();
        var imgsrc = $(this).find("img").attr("src");
        var discribe = $(this).find("div.caption p.discribe").text();
        $("img.popphoto").attr("src", imgsrc);
        $("#recommend p.discribe").text(discribe);
        $("#recommend span.id_hide").text(id_hide);
        $(".id_hide").hide();
        var xmlhttp;
        if (window.XMLHttpRequest) {
            // IE7+, Firefox, Chrome, Opera, Safari 浏览器执行代码
            xmlhttp = new XMLHttpRequest();
        }
        else {
            // IE6, IE5 浏览器执行代码
            xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
        }
        xmlhttp.onreadystatechange = function () {
            if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                var data = xmlhttp.responseText;
                var str = data.split("|");
                //var num = data.find("num").text;
                //var price = data.find("price").text;
                $("#txtFoodNum").val(str[0]);
                $("#price").text(str[1]);
            }
        }
        var foodId = $(this).find("span.id_hide").text();
        xmlhttp.open("POST", "foodNum.aspx", true);
        xmlhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
        xmlhttp.send("foodId=" + foodId);
    })
    $(document).on("click", "div.buy-add", function () {
        var xmlhttp;
        if (window.XMLHttpRequest) {
            // IE7+, Firefox, Chrome, Opera, Safari 浏览器执行代码
            xmlhttp = new XMLHttpRequest();
        }
        else {
            // IE6, IE5 浏览器执行代码
            xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
        }
        xmlhttp.onreadystatechange = function () {
            if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                var data = xmlhttp.responseText;
                var str = data.split("|");
                //var num = data.find("num").text;
                //var price = data.find("price").text;
                $("#txtFoodNum").val(str[0]);
                $("#price").text(str[1]);
            }
        }
        var foodId = $("#recommend span.id_hide").text();
        xmlhttp.open("POST", "addFood.aspx", true);
        xmlhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
        xmlhttp.send("foodId=" + foodId);
    })

    $(document).on("click", "div.buy-minus", function () {
        var xmlhttp;
        if (window.XMLHttpRequest) {
            // IE7+, Firefox, Chrome, Opera, Safari 浏览器执行代码
            xmlhttp = new XMLHttpRequest();
        }
        else {
            // IE6, IE5 浏览器执行代码
            xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
        }
        xmlhttp.onreadystatechange = function () {
            if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                var data = xmlhttp.responseText;
                var str = data.split("|");
                //var num = data.find("num").text;
                //var price = data.find("price").text;
                $("#txtFoodNum").val(str[0]);
                $("#price").text(str[1]);
            }
        }
        var foodId = $("#recommend span.id_hide").text();
        xmlhttp.open("POST", "minusFood.aspx", true);
        xmlhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
        xmlhttp.send("foodId=" + foodId);
    })
})
$(document).on("pagecreate", "#page-food", function () {
    $(".nav-top a").removeClass("ui-btn uibtn-up-d ui-btn-inline")
    $(".nav-top div.ui-input-search").removeClass("ui-shadow-inset ui-input-has-clear ")
    $(".ui-popup").removeClass("ui-overlay-shadow")

    $(document).on("click", "div.thumbnail a", function () {
        var id_hide = $(this).find("span.id_hide").text();
        var imgsrc = $(this).find("img").attr("src");
        var discribe = $(this).find("div.caption p.discribe").text();
        $("img.popphoto").attr("src", imgsrc);
        $("#recommend p.discribe").text(discribe);
        $("#recommend span.id_hide").text(id_hide);
        $(".id_hide").hide();
        var xmlhttp;
        if (window.XMLHttpRequest) {
            // IE7+, Firefox, Chrome, Opera, Safari 浏览器执行代码
            xmlhttp = new XMLHttpRequest();
        }
        else {
            // IE6, IE5 浏览器执行代码
            xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
        }
        xmlhttp.onreadystatechange = function () {
            if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                var data = xmlhttp.responseText;
                var str = data.split("|");
                //var num = data.find("num").text;
                //var price = data.find("price").text;
                $("#txtFoodNum").val(str[0]);
                $("#price").text(str[1]);
            }
        }
        var foodId = $(this).find("span.id_hide").text();
        xmlhttp.open("POST", "foodNum.aspx", true);
        xmlhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
        xmlhttp.send("foodId=" + foodId);
    })
    $(document).on("click", "div.buy-add", function () {
        var xmlhttp;
        if (window.XMLHttpRequest) {
            // IE7+, Firefox, Chrome, Opera, Safari 浏览器执行代码
            xmlhttp = new XMLHttpRequest();
        }
        else {
            // IE6, IE5 浏览器执行代码
            xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
        }
        xmlhttp.onreadystatechange = function () {
            if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                var data = xmlhttp.responseText;
                var str = data.split("|");
                //var num = data.find("num").text;
                //var price = data.find("price").text;
                $("#txtFoodNum").val(str[0]);
                $("#price").text(str[1]);
            }
        }
        var foodId = $("#recommend span.id_hide").text();
        xmlhttp.open("POST", "addFood.aspx", true);
        xmlhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
        xmlhttp.send("foodId=" + foodId);
    })

    $(document).on("click", "div.buy-minus", function () {
        var xmlhttp;
        if (window.XMLHttpRequest) {
            // IE7+, Firefox, Chrome, Opera, Safari 浏览器执行代码
            xmlhttp = new XMLHttpRequest();
        }
        else {
            // IE6, IE5 浏览器执行代码
            xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
        }
        xmlhttp.onreadystatechange = function () {
            if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                var data = xmlhttp.responseText;
                var str = data.split("|");
                //var num = data.find("num").text;
                //var price = data.find("price").text;
                $("#txtFoodNum").val(str[0]);
                $("#price").text(str[1]);
            }
        }
        var foodId = $("#recommend span.id_hide").text();
        xmlhttp.open("POST", "minusFood.aspx", true);
        xmlhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
        xmlhttp.send("foodId=" + foodId);
    })

})
$(document).on("pagecreate", "#page-order", function () {
    $(".nav-top a").removeClass("ui-btn uibtn-up-d ui-btn-inline")
    $(".nav-top div.ui-input-search").removeClass("ui-shadow-inset ui-input-has-clear ")
    // Swipe to remove list item
    $(document).on("swipeleft swiperight", "#list li", function (event) {
        var listitem = $(this),
            // These are the classnames used for the CSS transition
            dir = event.type === "swipeleft" ? "left" : "right",
            // Check if the browser supports the transform (3D) CSS transition
            transition = $.support.cssTransform3d ? dir : false;
        confirmAndDelete(listitem, transition);
    });
    $(document).on("click", "#delete-all", function () {
        var list = $("#list-all");
        confirmAndDelete(list);
    })
    // If it's not a touch device...
    if (!$.mobile.support.touch) {
        $(".delete").on("click", function () {
            var listitem = $(this).parent("div").parent("li");
            confirmAndDelete(listitem);
        });
    }
    else {
        $(".order-list-li-delete-box").remove();
    }

    function confirmAndDelete(listitem, transition) {
        // Highlight the list item that will be removed
        listitem.addClass("delete-active");
        // Inject topic in confirmation popup after removing any previous injected topics
        $("#confirm .topic").remove();
        listitem.find(".topic").clone().insertAfter("#question");
        // Show the confirmation popup
        $("#confirm").popup("open");
        // Proceed when the user confirms
        $("#confirm #yes").on("click", function () {
            var xmlhttp;
            if (window.XMLHttpRequest) {
                // IE7+, Firefox, Chrome, Opera, Safari 浏览器执行代码
                xmlhttp = new XMLHttpRequest();
            }
            else {
                // IE6, IE5 浏览器执行代码
                xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
            }
            xmlhttp.onreadystatechange = function () {
                if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                //响应
                }
            }
            var foodId = $(listitem).find("span.id_hide").text();
            xmlhttp.this = this;
            xmlhttp.open("POST", "deleteOrder.aspx", true);
            xmlhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
            xmlhttp.send("foodId=" + foodId);
            listitem.remove();
            $("#list").listview("refresh");
        });
        // Remove active state and unbind when the cancel button is clicked
        $("#confirm #cancel").on("click", function () {
            listitem.removeClass("delete-active");
            $("#confirm #yes").off();
        });
    }

    $(document).on("click", "a.ui-icon-plus", function () {
        var xmlhttp;
        if (window.XMLHttpRequest) {
            // IE7+, Firefox, Chrome, Opera, Safari 浏览器执行代码
            xmlhttp = new XMLHttpRequest();
        }
        else {
            // IE6, IE5 浏览器执行代码
            xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
        }
        xmlhttp.onreadystatechange = function () {
            if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                var data = xmlhttp.responseText;
                var str = data.split("|");
                //var num = data.find("num").text;
                //var price = data.find("price").text;
                $(xmlhttp.this).parent().find("input.foodnum").val(str[0]);
                $(xmlhttp.this).parent().parent().find("span.price").text(str[1]);
                var unitPrice = parseFloat(str[1]) / parseFloat(str[0]);
                var frontPrice = parseFloat($("#sumPrice").text());
                $("#sumPrice").text((unitPrice + frontPrice).toString());
            }
        }
        var foodId = $(this).parent().find("span.id_hide").text();
        xmlhttp.this = this;
        xmlhttp.open("POST", "addFood.aspx", true);
        xmlhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
        xmlhttp.send("foodId=" + foodId);
    })

    $(document).on("click", "a.ui-icon-minus", function () {
        var xmlhttp;
        if (window.XMLHttpRequest) {
            // IE7+, Firefox, Chrome, Opera, Safari 浏览器执行代码
            xmlhttp = new XMLHttpRequest();
        }
        else {
            // IE6, IE5 浏览器执行代码
            xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
        }
        xmlhttp.onreadystatechange = function () {
            if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                var data = xmlhttp.responseText;
                var str = data.split("|");
                //var num = data.find("num").text;
                //var price = data.find("price").text;
                $(xmlhttp.this).parent().find("input.foodnum").val(str[0]);
                $(xmlhttp.this).parent().parent().find("span.price").text(str[1]);
                var unitPrice = parseFloat(str[2]);
                var frontPrice = parseFloat($("#sumPrice").text());
                $("#sumPrice").text((frontPrice-unitPrice).toString());
            }
        }
        var foodId = $(this).parent().find("span.id_hide").text();
        xmlhttp.this = this;
        xmlhttp.open("POST", "minusFood.aspx", true);
        xmlhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
        xmlhttp.send("foodId=" + foodId);
    })
    $("#ddlRoom-button").removeClass("ui-shadow"); 
    $("#ddlTable-button").removeClass("ui-shadow");
    if (!$("li").length > 0) {
        $("#list-all").remove();
        $("#tips").text("这里空空如也~");
        $("#tips").css({
            "margin": "5px auto 5px auto",
            "text-align":"center",
            "display":"block"
        });
    }
});
