var $ = document;
//  Button
var nextBtn = $.getElementById("next");
var prevBtn = $.getElementById("prev");
//  Content
var content = $.getElementById("content");
//  Tab Title
var architecture = $.getElementById("architecture");
var layer = $.getElementById("layer");
var identity = $.getElementById("identity");
var report = $.getElementById("report");
var logic = $.getElementById("logic");
var infrastructure = $.getElementById("infrastructure");

// JavaScript source code

const Next = () => {
    content.innerHTML = "صفحه بعدی";
}
const Prev = () => {
    content.innerHTML = "صفحه قبلی";
}
architecture.addEventListener("click", () => {
    content.innerHTML = "معماری";
})
layer.addEventListener("click", () => {
    content.innerHTML = "لایه بندی";
})
identity.addEventListener("click", () => {
    content.innerHTML = "اجراز هویت";
})
report.addEventListener("click", () => {
    content.innerHTML = "گزارشات";
})
logic.addEventListener("click", () => {
    content.innerHTML = "منطق";
})
infrastructure.addEventListener("click", () => {
    content.innerHTML = "زیر ساخت";
})