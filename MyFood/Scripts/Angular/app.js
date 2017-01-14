var app = angular.module('myFoodApp', ['ngRoute' /*הייתי צריכה להוסיף קישור כדי שיעבוד*/]); //, 'ngResource']); מחקתי כי זה עשה לי בעיות כנראה צריך להוסיף script 
app.config(function ($routeProvider) {

    $routeProvider.when('/Add', {
        templateUrl: 'Partials/AddView.html'
    })
    .otherwise({
        templateUrl: 'Partials/MainView.html'
    })
});