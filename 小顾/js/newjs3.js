﻿function swiper() {
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
        var imgsrc = $(this).find("img").attr("src");
        var discribe = $(this).find("div.caption p.discribe").text();
        $("img.popphoto").attr("src", imgsrc);
        $("#recommend p.discribe").text(discribe);
    })
})
$(document).on("pagecreate", "#page-food", function () {
    $(".nav-top a").removeClass("ui-btn uibtn-up-d ui-btn-inline")
    $(".nav-top div.ui-input-search").removeClass("ui-shadow-inset ui-input-has-clear ")
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
            // Remove with a transition

            listitem.remove();
            $("#list").listview("refresh");
        });
        // Remove active state and unbind when the cancel button is clicked
        $("#confirm #cancel").on("click", function () {
            listitem.removeClass("delete-active");
            $("#confirm #yes").off();
        });
    }


});