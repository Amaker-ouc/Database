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
    setInterval("loadfood()", "1000");
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
            $("#newfood-name").text(foodName)
            $("#newfood").popup("open")
        }
    }
    xmlhttp.open("POST", "loadfood.aspx", true);
    xmlhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
    xmlhttp.send("cookid=1");
}