$(function () {

    function isSmallScreen() {
        return window.parent.document.documentElement.clientWidth < 768;
    }

    function checkViewport() {
        if (isSmallScreen() && !$(".sidebar-wrapper").hasClass("toggled")) {
            $(".sidebar-wrapper").addClass("toggled");
        }
        if (!isSmallScreen() && $(".sidebar-wrapper").hasClass("toggled")) {
            $(".sidebar-wrapper").removeClass("toggled");
        }
    }

    $(window).resize(checkViewport);
    checkViewport();

    $("#menu-toggle").click(function (e) {
        e.preventDefault();
        $(".sidebar-wrapper").toggleClass("toggled");
    });
});