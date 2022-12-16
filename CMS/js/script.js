const $=document;
let navItems=$.getElementById("sidebar");
let header_nav=$.getElementById("header-nav");

navItems.addEventListener("click",(event)=>{
    DeleteActiveClass();
    if(event.target.tagName === "A"){
        event.target.classList.add("active");
    }
});

header_nav.addEventListener("click",(event)=>{
    DeleteTopBorder();
    if(event.target.tagName === "A"){
        event.target.classList.add("b-top");
    }
});

function DeleteActiveClass(){
    let list=Array.from(navItems.children);
    (list).forEach(element => {
        element.firstElementChild.classList.remove("active");
        element.firstElementChild.classList.add("text-white");
    });
}

function DeleteTopBorder(){
    let list= Array.from(header_nav.children);
    list.forEach(item => {
        item.firstElementChild.classList.remove("b-top");
    });
}