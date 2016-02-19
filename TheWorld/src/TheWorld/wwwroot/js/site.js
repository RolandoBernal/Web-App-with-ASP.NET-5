// site.js

var ele = document.getElementById("username");
ele.innerHTML = "Bruce Wayne";

var main = document.getElementById("main");
main.onmouseenter = function () {
    main.style["background-color"] = "#888;"
};
main.onmouseleave = function () {
    main.style["background-color"] = "";
};