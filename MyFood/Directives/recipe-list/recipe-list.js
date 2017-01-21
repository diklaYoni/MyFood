app.directive('recipeList', function () {
    return {
        restrict: 'E',
        templateUrl: 'Directives/recipe-list/recipe-list.html',
        scope: {
            data: '='
        },
        link: function (scope) {
            scope.listItems = [];
            scope.HoveredItem = -1;

            scope.addItem = function () {

                if (scope.newItem && scope.newItem.replace(" ", "") != "") {
                    scope.listItems.push(scope.newItem);
                    scope.newItem = "";
                }
            }

            scope.removeItem = function (p_item) {
                scope.listItems.splice(scope.listItems.indexOf(p_item), 1);
            }

            scope.mouseEnterItem = function (p_index) {
                scope.HoveredItem = p_index;
            }

            scope.mouseLeaveItem = function () {
                scope.HoveredItem = -1;
            }
        }
    };
});