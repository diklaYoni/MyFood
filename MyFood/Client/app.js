var app = angular.module('myFoodApp', ['ngRoute','ngResource']); 
app.config(function ($routeProvider) {

    $routeProvider.when('/Add', {
        templateUrl: 'Partials/AddView.html'
    })
    $routeProvider.when('/Recipe', {
        templateUrl: 'Partials/RecipeView.html'
    })
    .otherwise({
        templateUrl: 'Partials/MainView.html'
    })
});