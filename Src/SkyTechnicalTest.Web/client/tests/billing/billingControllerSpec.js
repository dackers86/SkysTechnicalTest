describe('BillingController', function() {

		var scope, billingService;

		beforeEach(module('skyBillingApp'));

		beforeEach(inject(function ($rootScope, $controller, _billingService_) {
		  scope = $rootScope.$new();
		  billingService = _billingService_;

  		  billingService.Get = function(response) {
			return { data: "SkyBill" };
		  };

		  $controller('billingCtrl',
                {$scope: scope, billingService: billingService });

		  $rootScope.$apply();
  		  scope.$digest();

		}));


		it('Should get the bill on Initialise', function() {
			expect(scope.currentBill).toEqual({ data: "SkyBill" });
		});
});