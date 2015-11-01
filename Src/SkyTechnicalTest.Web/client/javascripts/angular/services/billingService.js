angular.module('skyBillingApp.services', [])
.service('billingService', ['$http', '$rootScope', function ($http, $rootScope) {

    this.Get = function() {
        return $http({
            method: 'GET',
            url: "http://safe-plains-5453.herokuapp.com/bill.json",
            params: '',
            headers: {}
         });
    };
}]);
