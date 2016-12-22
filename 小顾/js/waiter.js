$(document).on("pagecreate", "#page-cook", function () {
    $(document).on("click", ".li-box", function () {
        var li_box = $(this);
        var state = $(this).find(".state").text();
        if (state == "服务中") {
            $(this).parent().addClass("confirm-active");
            var room_table = $(this).find(".room-table").text();
            $("#room_table").text(room_table);
            $("#confirm").popup("open")
            $("#finish").on("click", function () {
                var order_id = li_box.find("span").text();
                finishService(order_id);
                li_box.remove();
                li_box.parent().removeClass("confirm-active");
                $("#list").listview("refresh");
            });
            $("#cancel").on("click", function () {
                li_box.parent().removeClass("confirm-active");
                $("#confirm #yes").off();
            });
        }
    })
    setInterval("loadfood()", "3000");
    
    $("#ddlCook-button").removeClass("ui-corner-all ui-shadow");
    $(document).on("click", "#confirm_id", function () {
        confirmService();
    })
    $(document).on("")
})

function loadfood() {
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
            if (data != "none") {
                $("#newService").text(str[0]);
                $("#orderid").text(str[1]);
                $("#newServicePop").popup("open")
            }
        }
    }
    xmlhttp.open("POST", "loadservice.aspx", true);
    xmlhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
    xmlhttp.send("waiterid=" + $("#waiterid").text());
}

function confirmService() {
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
            if (data != "success") {
                alert("确认失败");
            }
            else {
                var li = "<li class=\"ui-li-has-alt ui-li-static ui-body-inherit ui-first-child ui-last-child\"><div class=\"li-box\"><p class=\"room-table\">" + $("#newService").text() + "</p><p class=\"state\">服务中</p></div></li>"
                $("#list").append(li)
            }
        }
    }
    xmlhttp.open("POST", "confirmService.aspx", true);
    xmlhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
    xmlhttp.send("orderid=" + $("#orderid").text());
}

function finishService(order_id) {
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
            if (data != "success") {
                alert("确认失败");
            }
            else {
            }
        }
    }
    xmlhttp.open("POST", "finishService.aspx", true);
    xmlhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
    xmlhttp.send("order_id=" + order_id);
}