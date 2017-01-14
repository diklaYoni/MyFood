var angular;
var myFoodApp = angular.module('myFoodApp', []);

myFoodApp.controller('MainController', ['$scope', function ($scope) {
    
    $scope.greeting = 'Hola!';
    alert("Hey");
}]);