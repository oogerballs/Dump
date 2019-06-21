var app = angular.module('myApp', ['ngRoute']);
let LastBut = document.getElementById("Last");
let NextBut = document.getElementById("Next");
let stepButtons = document.getElementsByClassName("StepButton");
let PageUrl;
let stepIndex = 0;


app.config($routeProvider => {
  $routeProvider
    .when('/', {
      templateUrl: 'pages/StepLayoutPage.html',
      controller: 'mainController'
    })

    .when('/Step1', {
      templateUrl: 'pages/StepLayoutPage.html',
      controller: 'Step1Controller'
    })

    .when('/Step2', {
      templateUrl: 'pages/StepLayoutPage.html',
      controller: 'Step2Controller'
    })

    .when('/Step3', {
      templateUrl: 'pages/StepLayoutPage.html',
      controller: 'Step3Controller'
    })

    .when('/Step4', {
      templateUrl: 'pages/StepLayoutPage.html',
      controller: 'Step4Controller'
    })

    .when('/Step5', {
      templateUrl: 'pages/StepLayoutPage.html',
      controller: 'Step5Controller'
    })

    .when('/Step6', {
      templateUrl: 'pages/StepLayoutPage.html',
      controller: 'Step6Controller'
    })

    .when('/Step7', {
      templateUrl: 'pages/StepLayoutPage.html',
      controller: 'Step7Controller'
    })

    .when('/Step8', {
      templateUrl: 'pages/StepLayoutPage.html',
      controller: 'Step8Controller'
    })

    .when('/Step9', {
      templateUrl: 'pages/StepLayoutPage.html',
      controller: 'Step9Controller'
    })

    .when('/Step10', {
      templateUrl: 'pages/StepLayoutPage.html',
      controller: 'Step10Controller'
    })

    .when('/Step11', {
      templateUrl: 'pages/StepLayoutPage.html',
      controller: 'Step11Controller'
    });
});

//Controllers

app.controller('mainController', function ($scope, $location) {
  stepIndex = 0;
  $scope.StepTitle = 'Bearing Cleaning Tutorial';
  $scope.ImageSrc1 = "./Images/Intro.jpg"
  $scope.Content1 = "Welcome to my Tutorial";
  resetStepButtons();
  PageUrl = $location.$$url;
});

app.controller('Step1Controller', function ($scope, $location) {
  stepIndex = 1;
  $scope.RotateImg = "RotateImg";
  $scope.StepTitle = 'Step 1';
  $scope.ImageSrc1 = "./Images/Step1.jpg"
  $scope.Content1 = "Get the esstential items needed for cleaning the bearings. The first and most essetial is the Skate tool which lets you unsrew the nut of the wheel. After that, a citrus cleaner is good to get off all the dirt a grime from the bearing.";
  $scope.Content2 = "Next, Speed gell to lube up the ball bearings will be required. I typically use Bones Speed Cream.";
  $scope.Content3 = "After all that, the you'll need bottle or tuber ware. While the best option is a dedicated bearing cleaning bottle, tuber ware will work just fine.";
  PageUrl = $location.$$url;
  resetStepButtons();
  stepButtons[1].style.backgroundColor = "#BF7463";
});

app.controller('Step2Controller', function ($scope, $location) {
  stepIndex = 2;
  $scope.RotateImg = "RotateImg";
  SiteLocation = $location;
  $scope.StepTitle = 'Step 2';
  $scope.ImageSrc1 = "./Images/Step2_1.jpg"
  $scope.Content1 = "Using the medium bit on the skate tool, screw off the nuts holding in the wheels to the trucks.";
  $scope.ImageSrc2 = "./Images/Step2_2.jpg"
  $scope.Content2 = "Make sure to take off the washers. Washers usually stick to the nut or the bearing.";
  $scope.ImageSrc3 = "./Images/Step2_3.jpg"
  $scope.Content3 = "There are two washers on every wheel. The first washer must be removed but the second one can stay on.";
  $scope.ImageSrc4 = "./Images/Step2_4.jpg"
  PageUrl = $location.$$url;
  resetStepButtons();
  stepButtons[2].style.backgroundColor = "#BF7463";
});

app.controller('Step3Controller', function ($scope, $location) {
  stepIndex = 3;
  $scope.RotateImg = "RotateImg";
  SiteLocation = $location;
  $scope.StepTitle = 'Step 3';
  $scope.ImageSrc1 = "./Images/Step3.jpg"
  $scope.Content1 = "Once the nut has been removed, you'll have to remove the bearing from the wheel.";
  $scope.Content2 = "This can be done using the skate tool but I find it to be easer to use the truck bar to pop the bearing out of the wheel as shown in the image above.";
  PageUrl = $location.$$url;
  resetStepButtons();
  stepButtons[3].style.backgroundColor = "#BF7463";
});

app.controller('Step4Controller', function ($scope, $location) {
  stepIndex = 4;
  SiteLocation = $location;
  $scope.StepTitle = 'Step 4';
  $scope.ImageSrc1 = "./Images/Step4_1.jpg"
  $scope.Content1 = "Repeat the last two steps on all other 3 wheels";
  $scope.ImageSrc2 = "./Images/Step4_2.jpg"
  $scope.Content2 = "Make sure to separate all your wheels, nuts,bearings, and washer into sections so that putting them back together is easier.";
  PageUrl = $location.$$url;
  resetStepButtons();
  stepButtons[4].style.backgroundColor = "#BF7463";
});

app.controller('Step5Controller', function ($scope, $location) {
  stepIndex = 5;
  SiteLocation = $location;
  $scope.StepTitle = 'Step 5';
  $scope.ImageSrc1 = "./Images/Step5.jpg"
  $scope.Content1 = "Remove the bearing shield by inserting the razor blade into the little space between the shield and the actual bearing.";
  $scope.Content2 = "It might feel like your messing up the sheild but it should be fine and should easily pop back in later.";
  PageUrl = $location.$$url;
  resetStepButtons();
  stepButtons[5].style.backgroundColor = "#BF7463";
});

app.controller('Step6Controller', function ($scope, $location) {
  stepIndex = 6;
  SiteLocation = $location;
  $scope.StepTitle = 'Step 6';
  $scope.ImageSrc1 = "./Images/Step6.jpg"
  $scope.Content1 = "Place the bearings and shields into the bottle or tuber ware and fill them up with the citrus cleaner.";
  $scope.Content2 = "Once the cleaner has been added, close the bottle or put the lid on the tuber ware and shake it for a minute or two.";
  PageUrl = $location.$$url;
  resetStepButtons();
  stepButtons[6].style.backgroundColor = "#BF7463";
});

app.controller('Step7Controller', function ($scope, $location) {
  stepIndex = 7;
  SiteLocation = $location;
  $scope.StepTitle = 'Step 7';
  $scope.ImageSrc1 = "./Images/Step7_1.jpg"
  $scope.Content1 = "Drain the cleaner but keep the bearings and shields inside.";
  $scope.ImageSrc1 = "./Images/Step7_2.jpg"
  $scope.Content2 = "after that, add more cleaner and let the bearings sit for 30 - 40 minutes. Once time is up, drain them again and set the bearings on a paper towel for 5 to 10 minutes.";
  PageUrl = $location.$$url;
  resetStepButtons();
  stepButtons[7].style.backgroundColor = "#BF7463";
});

app.controller('Step8Controller', function ($scope, $location) {
  stepIndex = 8;
  SiteLocation = $location;
  $scope.StepTitle = 'Step 8';
  $scope.ImageSrc1 = "./Images/Step8.jpg"
  $scope.Content1 = " Once the bearings are dry, app speed jell to the bearings.";
  $scope.Content2 = "It's typically best to use 3 drops on each side and then spin the bearing around to make sure that every ball bearing is covered.";
  PageUrl = $location.$$url;
  resetStepButtons();
  stepButtons[8].style.backgroundColor = "#BF7463";
});

app.controller('Step9Controller', function ($scope, $location) {
  stepIndex = 9;
  SiteLocation = $location;
  $scope.StepTitle = 'Step 9';
  $scope.ImageSrc1 = "./Images/Step9_1.jpg"
  $scope.Content1 = " Once the bearings have been oild up, now it's time to pop them back in. The best was to do this by poping the bearing in just a bit, and then using the truck bar to push them in fully.";
  $scope.ImageSrc1 = "./Images/Step9_2.jpg"
  $scope.Content2 = "Make sure to place the spacer in the between the bearings and then poping in the next bearing.";
  PageUrl = $location.$$url;
  resetStepButtons();
  stepButtons[9].style.backgroundColor = "#BF7463";
});

app.controller('Step10Controller', function ($scope, $location) {
  stepIndex = 10;
  SiteLocation = $location;
  $scope.StepTitle = 'Step 10';
  $scope.ImageSrc1 = "./Images/Step10.jpg"
  $scope.Content1 = " Once all the wheels are on the truck bar, place the washer in and tighten the wheel with the nut and skate tool. Make sure to leave a little wiggle space so that bearings are not being squished too much. Repeat the process on all 4 wheels and then, you are done cleaning your bearings.";
  $scope.ImageSrc1 = "./Images/Step10_2.jpg"
  $scope.Content2 = "At this point, all you'll need to do is skate around and break your bearings back in.";
  PageUrl = $location.$$url;
  resetStepButtons();
  stepButtons[10].style.backgroundColor = "#BF7463";
});

app.controller('Step11Controller', function ($scope, $location) {
  stepIndex = 11;
  SiteLocation = $location;
  $scope.StepTitle = 'Extras';
  $scope.ImageSrc1 = "./Images/Extra1.jpg"
  $scope.Conten1 = "While waiting for things to soak up or dry up, somethings that you could do are clean up other parts of your board.";
  $scope.ImageSrc2 = "./Images/Extra2.jpg"
  $scope.Conten2 = "Cleaning up your bearing with a simple wipe is a good idea to avoid having dirt in your bearings. Doing this every once and a while would go a long way.";
  $scope.ImageSrc3= "./Images/Extra3.jpg"
  $scope.Content3 = "Using the same method as above to clean your truck bars is also a good idea to avoid dirt a grime.";
  $scope.ImageSrc4 = "./Images/Extra4.jpg"
  PageUrl = $location.$$url;
  resetStepButtons();
  stepButtons[11].style.backgroundColor = "#BF7463";
});

app.controller('navController', function ($scope) {

  $scope.navLis = [
    { Href1: "#!/", Name1: "Home", Href2: "#!Step1", Name2: "Step 1" },
    { Href1: "#!Step2", Name1: "Step 2", Href2: "#!Step3", Name2: "Step 3" },
    { Href1: "#!Step4", Name1: "Step 4", Href2: "#!Step5", Name2: "Step 5" },
    { Href1: "#!Step6", Name1: "Step 6", Href2: "#!Step7", Name2: "Step 7" },
    { Href1: "#!Step8", Name1: "Step 8", Href2: "#!Step9", Name2: "Step 9" },
    { Href1: "#!Step10", Name1: "Step 10", Href2: "#!Step11", Name2: "Step 11" }
  ]
});

//Next and Last funtionality

// if(app.controller == ""){};

const resetStepButtons = () => {
  lastStep.onclick = "lastStep()";
  nextStep.onclick = "nextStep()";

  for (let i = 0; i < stepButtons.length; i++) {
    stepButtons[i].style.backgroundColor = "#F2F2F2";
  };

  if (stepIndex == 0) {
    LastBut.style = ""
  }

  if (stepButtons.length > 1) {
    if (stepIndex == 0) {
      stepButtons[0].style.backgroundColor = "#BF7463";
    }
  }

}


const lastStep = () => {
  stepIndex -= 1;
  if (PageUrl == "/") {
    stepIndex = 0;
    lastStep.onclick = "";
  } else if (PageUrl == "/Step1") {
    location.assign("/#!/");
  } else {
    location.assign("/#!/Step" + stepIndex);
  }
}

const nextStep = () => {
  console.log(stepButtons.length);
  stepIndex += 1;
  if (stepIndex > stepButtons.length - 1) {
    stepIndex = stepButtons.length - 1;
    nextStep.onclick = "";
  } else {
    location.assign("/#!Step" + stepIndex);
  }
}