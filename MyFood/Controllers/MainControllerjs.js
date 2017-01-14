app.controller('MainController', ['$scope', 'data-service', function ($scope, dataService) {

    $scope.name = "dikla";
    $scope.recepies = dataService.getRecipes();
}]);