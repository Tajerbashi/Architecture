// JavaScript source code
var $ = document;
var nextBtn = $.getElementById("next");
var prevBtn = $.getElementById("prev");
var content = $.getElementById("content");
const Next = () => {
    content.innerHTML = "Next";
}
const Prev = () => {
    content.innerHTML = "Back";
}
