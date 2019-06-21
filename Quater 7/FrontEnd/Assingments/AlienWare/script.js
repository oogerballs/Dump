$(function(){
    $('body').popover({ selector: '[data-toggle="popover"]' });
});

$('#myModal').on('shown.bs.modal', function () {
    $('#myInput').trigger('focus')
  })

function HotHardWare(){
    document.getElementById("reviewText").innerHTML = '"The Alienware Alpha is everything we have come to expect from an Alienware flagship product."';
    document.getElementById('ReviewImage').src='https://i.dell.com/sites/imagecontent/products/PublishingImages/Expert%20Reviews/Hot-Hardware-Recommended-award-500x500.png'
}

function DigitalTrends(){
    document.getElementById("reviewText").innerHTML = '"You get your money’s worth with this top-tier gaming product."';
    document.getElementById('ReviewImage').src='https://i.dell.com/sites/imagecontent/products/PublishingImages/Expert%20Reviews/Digital-Trends-Best-Gaming-Desktops-logo-500x500.png'
}

function TomsGuids(){
    document.getElementById("reviewText").innerHTML = '"Serious Power for Serious Gamers."';
    document.getElementById('ReviewImage').src='https://i.dell.com/sites/imagecontent/products/PublishingImages/Expert%20Reviews/Toms-Guide-Editors-Choice-logo-500x500.png'
}