angular.module('skyBillingApp.controllers', []).
controller('billingCtrl', ['$scope', 'billingService', function ($scope, billingService) {

	$scope.currentBill = null;

	$scope.init = function () {
		$scope.GetSkyBill();
	};

    $scope.GetSkyBill = function(){

    	billingService.Get().then(function(response) {
        	$scope.currentBill = response.data;
    	});
	};

    $scope.init();


}]);