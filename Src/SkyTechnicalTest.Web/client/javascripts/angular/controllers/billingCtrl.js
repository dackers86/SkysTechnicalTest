angular.module('skyBillingApp.controllers', []).
controller('billingCtrl', ['$scope', '$filter', 'billingService', function ($scope, $filter, billingService) {

   $scope.currentBill = null;
    billingService.Get().then(function(response) {
        $scope.currentBill = response;
    });

}]);