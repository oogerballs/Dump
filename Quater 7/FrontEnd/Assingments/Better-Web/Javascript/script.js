//Modal code
window.onload = function () {
    var ModalBtn = document.getElementById("ModalBtn");
    var Modal = document.getElementById("Modal");
    var ModalClose = document.getElementsByClassName("Close")[0];


    ModalBtn.onclick = function () {
        Modal.style.display = "block";
    }

    ModalClose.onclick = function () {
        Modal.style.display = "none";
    }

    window.onclick = function (event) {
        if (event.target == Modal) {
            Modal.style.display = "none";
        }
    }
}

//Notification
var Notification = document.getElementsByClassName("Notification");
function showNotification(index) {
    index -= 1;
    Notification[index].id = "NotifVisible";
    setTimeout(function () { Notification[index].id = Notification[index].id.replace("NotifVisible", ""); }, 3000);
}

// Slide show code
var slideindex = 0;
showSlides(slideindex);

function cycleSlide(num) {
    showSlides(slideindex += num);
}
function showSlides(SlideNum) {
    var slides = document.getElementsByClassName("slide");
    var imageNum = document.getElementsByClassName("slideNum");
    if (SlideNum > slides.length - 1) {
        slideindex = 0;
    };

    if (SlideNum < 0) {
        slideindex = slides.length - 1;
    }

    for (var i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
        imageNum[i].innerHTML = i + 1 + "/" + slides.length;
    }

    slides[slideindex].style.display = 'block';
}

//Collapsible code
var CollapsibleButton = document.getElementsByClassName('CollapsibleButton');
console.log(CollapsibleButton);
var CollapsibleContent = document.getElementsByClassName("CollapsibleContent");
console.log(CollapsibleContent);

function CollapsibleToggle(i) {
    i -= 1;
    console.log(CollapsibleContent[i].display);
    if (window.getComputedStyle(CollapsibleContent[i]).maxHeight == "0px") {
        CollapsibleContent[i].style.maxHeight = CollapsibleContent[i].scrollHeight + "px";
        CollapsibleContent[i].style.padding = "5%";
    } else {
        CollapsibleContent[i].style.maxHeight = null;
        CollapsibleContent[i].style.padding = "0%";
    }
};

//Scrollable
var ScrollSection = document.getElementsByClassName("Scrollable");
var ScrollBody = document.getElementsByClassName("ScrollBody");
var ScrollHeader = document.getElementsByClassName("ScrollHeader");

for (var i = 0; i < ScrollSection.length; i++) {
    ScrollSection[i].onscroll = function () { scroll(i) };
}

function scroll(scrollIndex) {
    scrollIndex -= 1;
    if (ScrollSection[scrollIndex].scrollTop > 51) {
        ScrollHeader[scrollIndex].style.padding = "1% 0%";
    } else if (ScrollSection[scrollIndex].scrollTop < 50) {
        ScrollHeader[scrollIndex].style.padding = "8% 0%";
    }
};

//Quote of the day
var link = "https://thesimpsonsquoteapi.glitch.me/quotes";
var request = new XMLHttpRequest();

request.onreadystatechange = function () {
    if (this.readyState == 4 && this.status == 200) {
        var quote = JSON.parse(this.responseText);
        document.getElementById("quoteName").innerHTML = quote[0].character+"-";
        document.getElementById("quoteText").innerHTML = quote[0].quote;
    }
}
request.open('GET', link);
request.send();

function loadComplete() {
    var data = JSON.parse(request.responseText);
    for (var i = 0; i < data.results.length; i++) {
        quote.push(data.results[i]);
    }
    console.log(quote);
    // setUp();
}