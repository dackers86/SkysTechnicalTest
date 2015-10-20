angular.module('skyBillingApp.services', [])
.service('billingService', ['$http', '$rootScope', function ($http, $rootScope) {

    this.Get = function() {
        return $http({
            method: 'GET',
            url: "http://techtest.local/billing/1",
            params: '',
            headers: {}
         });
    };
}]);
