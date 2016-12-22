using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaxyToAir_TestHarness.BusinessModel;
using GalaxyToAir_TestHarness.Model;
using GalaxyToAir_TestHarness.Util;
using Newtonsoft.Json;
/****************************** Module Header ******************************\
Module Name     :   InsuranceService.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas

Class contains business logic to construct insurance search object, call the 
insurance search service, parse the response and return data in business model.
\***************************************************************************/
namespace GalaxyToAir_TestHarness.Services
{
    public class InsuranceService : IInsuranceService
    {

        public InsuranceSearchResponseModel GetInsuranceDetails(InsuranceSearchModel request)
        {
            var insuranceObj = new Model.InsuranceSearchRequest.InsuranceSearchRequestModel();
            var insuranceSearchResponse = new InsuranceSearchResponseModel();

            try
            {
                insuranceObj.dnsinsuranceQuoteRQ = new Model.InsuranceSearchRequest.DnsInsurancequoterq();
                insuranceObj.dnsinsuranceQuoteRQ.policySpecification = new Model.InsuranceSearchRequest.Policyspecification();
                insuranceObj.dnsinsuranceQuoteRQ.policySpecification.policy = new Model.InsuranceSearchRequest.Policy();
                insuranceObj.dnsinsuranceQuoteRQ.policySpecification.policy.product = new Model.InsuranceSearchRequest.Product();
                insuranceObj.dnsinsuranceQuoteRQ.policySpecification.policy.product.planId = request.planID;
                insuranceObj.dnsinsuranceQuoteRQ.policySpecification.policy.product.productCode = request.productCode;
                insuranceObj.dnsinsuranceQuoteRQ.policySpecification.policy.product.transactionType = "QUOTE";

                insuranceObj.dnsinsuranceQuoteRQ.policySpecification.policy.travelers = new Model.InsuranceSearchRequest.Travelers();
                insuranceObj.dnsinsuranceQuoteRQ.policySpecification.policy.travelers.traveler = new Model.InsuranceSearchRequest.Traveler[1];
                insuranceObj.dnsinsuranceQuoteRQ.policySpecification.policy.travelers.traveler[0] = new Model.InsuranceSearchRequest.Traveler();
                insuranceObj.dnsinsuranceQuoteRQ.policySpecification.policy.travelers.traveler[0].birthDate = request.birthDate;
                insuranceObj.dnsinsuranceQuoteRQ.policySpecification.policy.travelers.traveler[0].address = new Model.InsuranceSearchRequest.Address();
                insuranceObj.dnsinsuranceQuoteRQ.policySpecification.policy.travelers.traveler[0].address.city = request.city;
                insuranceObj.dnsinsuranceQuoteRQ.policySpecification.policy.travelers.traveler[0].address.country = request.country;
                insuranceObj.dnsinsuranceQuoteRQ.policySpecification.policy.travelers.traveler[0].address.state = request.state;
                insuranceObj.dnsinsuranceQuoteRQ.policySpecification.policy.travelers.traveler[0].address.street = request.street;
                insuranceObj.dnsinsuranceQuoteRQ.policySpecification.policy.travelers.traveler[0].address.zip = request.zip;
                insuranceObj.dnsinsuranceQuoteRQ.policySpecification.policy.travelers.traveler[0].gender = request.gender;
                insuranceObj.dnsinsuranceQuoteRQ.policySpecification.policy.travelers.traveler[0].travelerName = new Model.InsuranceSearchRequest.Travelername();
                insuranceObj.dnsinsuranceQuoteRQ.policySpecification.policy.travelers.traveler[0].travelerName.first= request.firstName;
                insuranceObj.dnsinsuranceQuoteRQ.policySpecification.policy.travelers.traveler[0].travelerName.last = request.lastName;
                insuranceObj.dnsinsuranceQuoteRQ.policySpecification.policy.travelers.traveler[0].tripCost = request.tripCost;
                insuranceObj.dnsinsuranceQuoteRQ.policySpecification.policy.trip= new Model.InsuranceSearchRequest.Trip();
                insuranceObj.dnsinsuranceQuoteRQ.policySpecification.policy.trip.departureDate = request.departureDate;
                insuranceObj.dnsinsuranceQuoteRQ.policySpecification.policy.trip.destinations = new Model.InsuranceSearchRequest.Destinations();
                insuranceObj.dnsinsuranceQuoteRQ.policySpecification.policy.trip.destinations.destination = new Model.InsuranceSearchRequest.Destination();
                insuranceObj.dnsinsuranceQuoteRQ.policySpecification.policy.trip.destinations.destination.country=request.destinationCountry;
                insuranceObj.dnsinsuranceQuoteRQ.policySpecification.policy.trip.destinations.destination.state = request.destinationState;
                insuranceObj.dnsinsuranceQuoteRQ.policySpecification.policy.trip.finalPaymentDate = request.finalPaymentDate;
                insuranceObj.dnsinsuranceQuoteRQ.policySpecification.policy.trip.initialTripDepositDate = request.initialDepositDate;
                insuranceObj.dnsinsuranceQuoteRQ.policySpecification.policy.trip.returnDate=request.returnDate;

                Model.InsuranceSearchResponse.InsuranceSearchResponseModel response;
                var output = Util.ServiceBridge<Model.InsuranceSearchRequest.InsuranceSearchRequestModel>.Run(insuranceObj, ServiceTypes.InsuranceSearch, HttpMethod.Post);

                insuranceSearchResponse.insuranceSearchRquest = JsonConvert.SerializeObject(insuranceObj);
                insuranceSearchResponse.insuranceSearchResponse = output;

                InsuranceData obj;

                response = JsonConvert.DeserializeObject<Model.InsuranceSearchResponse.InsuranceSearchResponseModel>(output);

                if (response != null)
                {
                    if(response.ns10InsuranceQuoteResponseVO.transactionStatus.ToUpper() == "SUCCESS")
                    {
                        obj = new InsuranceData();

                        var policyInfo = response.ns10InsuranceQuoteResponseVO.getQuoteResponse.getQuoteResult.policyQuoteDetails.policyInformation;

                        obj.planID = policyInfo.planID;
                        obj.productCode = request.productCode;
                        obj.extendedPremium = policyInfo.premium.extendedPremium;
                        obj.extendedTax = policyInfo.premium.extendedTax;
                        obj.feesPremium = policyInfo.premium.feesPremium;
                        obj.feesTax = policyInfo.premium.feesTax;
                        obj.optionalFeesPremium = policyInfo.premium.optionalFeesPremium;
                        obj.optionalPremium = policyInfo.premium.optionalPremium;
                        obj.optionalTax = policyInfo.premium.optionalTax;
                        obj.promotionalPremium = policyInfo.premium.promotionalPremium;
                        obj.standardFeesPremium = policyInfo.premium.standardFeesPremium;
                        obj.standardPremium = policyInfo.premium.standardPremium;
                        obj.standardTax = policyInfo.premium.standardTax;
                        obj.tax = policyInfo.premium.tax;
                        obj.totalPremiumAmount=policyInfo.premium.totalPremiumAmount;
                        obj.departureDate = request.departureDate;
                        obj.destinationCity = request.destinationState;
                        obj.destinationCountry = request.destinationCountry;
                        obj.initialTripDepositDate = request.initialDepositDate;
                        obj.finalPaymentDate = request.finalPaymentDate;
                        obj.returnDate = request.returnDate;
                        obj.tripCost = request.tripCost;

                        insuranceSearchResponse.insuranceData = obj;
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return insuranceSearchResponse;
        }
    }
}
