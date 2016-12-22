$(document).on("pagecreate", "#page-cook", function () {
    $(document).on("click", ".li-box", function () {
        var li_box=$(this);
        var state = $(this).find(".state").text();
        if (state == "等待") {
            $(this).parent().addClass("confirm-active")
            var foodName = $(this).find(".food-name").text();
            $("#food-name").text(foodName);
            $("#confirm").popup("open")
            $("#yes").on("click", function () {
                li_box.find("p.state").text("完成");
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
    $(document).on("click", "#cook", function () {
        $(this).text("烹饪中...");
        setTimeout(function () {
            $("#cook").addClass("hide");
            $("#finish").removeClass("hide");
        }, 5000)
    })
    $(document).on("click", "#finish", function () {
        $("#cook").text("烹饪");
        $("#cook").removeClass("hide");
        $("#finish").addClass("hide");
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
                var li = "<li class=\"ui-li-has-alt ui-li-static ui-body-inherit ui-first-child ui-last-child\"><div class=\"li-box\"><p class=\"food-name\">"+ $("#newfood-name").text() +"</p><p class=\"state\">完成</p></div></li>"
                $("#list").append(li)          
            }
        }
        xmlhttp.open("POST", "finish.aspx", true);
        xmlhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
        xmlhttp.send("cookid=" + $("#cookid").text());
    })
    $("#ddlCook-button").removeClass("ui-corner-all ui-shadow");
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
            var foodName = xmlhttp.responseText;
            if (foodName != "none") {
                $("#newfood-name").text(foodName)
                $("#newfood").popup("open")
            }
        }
    }
    xmlhttp.open("POST", "loadfood.aspx", true);
    xmlhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
    xmlhttp.send("cookid=" + $("#cookid").text());
}