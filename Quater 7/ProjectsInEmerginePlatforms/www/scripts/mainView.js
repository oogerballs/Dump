document.getElementById("ProfileImgClick").addEventListener("click", profile);
document.getElementById("DropClick").addEventListener("click", CollapsibleToggle);

function profile() {
    window.location.replace("profile.html");
}

var CollapsibleButton = document.getElementsByClassName('CollapsibleButton');
var CollapsibleContent = document.getElementsByClassName("CollapsibleContent");

function CollapsibleToggle() {
    i = 0;
    if (window.getComputedStyle(CollapsibleContent[i]).maxHeight == "0px") {
        CollapsibleContent[i].style.maxHeight = CollapsibleContent[i].scrollHeight + "px";
        CollapsibleContent[i].style.padding = "5%";
    } else {
        CollapsibleContent[i].style.maxHeight = null;
        CollapsibleContent[i].style.padding = "0%";
    }
};