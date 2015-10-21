angular.module('skyBillingApp.services', [])
.service('billingService', ['$http', '$rootScope', function ($http, $rootScope) {

    this.Get = function() {
        return $http({
            method: 'GET',
            url: "http://api.skytechnicaltest.com/billing/1",
            params: '',
            headers: {}
         });
    };
}]);
