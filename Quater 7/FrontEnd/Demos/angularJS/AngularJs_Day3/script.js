var app = angular.module('myApp', ['ngRoute']);

app.config($routeProvider => {
  $routeProvider

    .when('/', {
      templateUrl: 'pages/home.html',
      controller: 'mainController'
    })

    .when('/vampires', {
      templateUrl: 'pages/vampires.html',
      controller: 'vampController'
    })

    .when('/werewolves', {
      templateUrl: 'pages/werewolves.html',
      controller: 'wereController'
    })

    .when('/zombies', {
      templateUrl: 'pages/zombies.html',
      controller: 'zombController'
    });
});

app.controller('mainController', $scope => {
  $scope.message = 'Monsters!';
  //$scope.heading  = "Monsters!";
  //$scope.message = "";
});

app.controller('vampController', $scope => {
  $scope.message = 'Vampires';
});

app.controller('wereController', $scope => {
  $scope.message = 'Werewolves';
});

app.controller('zombController', $scope => {
  $scope.message = 'Zombies';
});


