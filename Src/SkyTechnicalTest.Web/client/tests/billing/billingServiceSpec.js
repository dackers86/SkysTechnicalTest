describe('BillingService', function() {

	var _billingService, _httpBackend;

		beforeEach(module('skyBillingApp'));

		beforeEach(inject(function (billingService, $httpBackend) {
		    _billingService = billingService;
		    _httpBackend = $httpBackend;
	  	}));

		afterEach(function() {
		    _httpBackend.verifyNoOutstandingExpectation();                                                                                                                             
		    _httpBackend.verifyNoOutstandingRequest();                                                                                                                                 
		}); 

		it('Should successfully get data from the billing Api', function() {

			var expected = { "statement": {
				"generated": "2015-01-11",
				"due": "2015-01-25",
				"period": {
					"from": "2015-01-26",
					"to": "2015-02-25"	
					}
				}
			}
						
			_httpBackend.whenGET('http://safe-plains-5453.herokuapp.com/bill.json')
			.respond(200, expected);

			_billingService.Get().then(function(data){
				expect(expected.generated).toBe(data.generated);
			});

			_httpBackend.flush();

		});
});