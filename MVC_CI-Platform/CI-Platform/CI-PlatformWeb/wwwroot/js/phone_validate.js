﻿document.querySelector(".phone").addEventListener("keypress", function (evt) {
    if (evt.which != 8 && evt.which != 0 && evt.which != 13 && evt.which == 109 && evt.which != 16 && evt.which < 48 || evt.which > 57) {
        evt.preventDefault();
    }
});