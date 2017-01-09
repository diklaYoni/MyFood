var app = angular.module('myFoodApp', ['ngRoute', 'ngResource']);
app.config(function($routeProvider){

    $routeProvider.when('/Add', {
        templateUrl: 'Partials/AddView.html'
    })
    .otherwise({
        templateUrl: 'Partials/MainView.html'
    })
});