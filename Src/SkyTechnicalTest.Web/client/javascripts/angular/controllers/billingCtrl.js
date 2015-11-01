angular.module('skyBillingApp.controllers', []).
controller('billingCtrl', ['$scope', 'billingService', function ($scope, billingService) {

	$scope.currentBill = null;

	$scope.init = function () {
		console.log("Starting init");
		$scope.GetSkyBill();
	};

    $scope.GetSkyBill = function(){
    	$scope.currentBill = billingService.Get();
	};

    $scope.init();


}]);