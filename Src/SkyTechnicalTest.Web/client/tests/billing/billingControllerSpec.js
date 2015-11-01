describe('BillingController', function() {

		var scope, billingService;

		beforeEach(module('skyBillingApp'));

		beforeEach(function() {
	        billingService = {
	            Get: function () {
	                deferred = $q.defer();
	                deferred.resolve({data: "SkyBill"});
	                return deferred.promise;
	            }
	        };
		});

		beforeEach(inject(function ($rootScope, $controller, _billingService_) {
		  scope = $rootScope.$new();
		  billingService = _billingService_;


		  $controller('billingCtrl',
                {$scope: scope, billingService: billingService });

		  $rootScope.$apply();
  		  scope.$digest();

		}));


		it('Should get the bill on Initialise', function() {
			expect(scope.currentBill).toEqual({ data: "SkyBill" });
		});
});