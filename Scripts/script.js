﻿

$('li').each(function () {
    if (window.location.href.indexOf($(this).find('a:first').attr('href')) > -1) {
        $(this).addClass('active').siblings().removeClass('active');
        $(this).parent().parent().addClass('active').siblings().removeClass('active');
    }
});

