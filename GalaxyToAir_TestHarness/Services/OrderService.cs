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
Module Name     :   OrderService.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas

Class contains business logic to construct order object, call the 
add to order service, parse the response and return data in business model.
\***************************************************************************/
namespace GalaxyToAir_TestHarness.Services
{
    public class OrderService : IOrderService
    {
        public AddToOrderResponseModel AddToOrder(AddToOrderRequestModel request)
        {
            var addToOrderResponse = new AddToOrderResponseModel();
            var orderObj = new Model.AddToCartRequest.AddToCartRequestModel();

            try
            {
                Random rnd = new Random();
                var OrderId = rnd.Next(00000, 99999);

                orderObj.oOrderVO = new Model.AddToCartRequest.OOrdervo();
                orderObj.oOrderVO.oexternalOrderId = OrderId.ToString();
                orderObj.oOrderVO.oexternalOrderHash = "5555";

                if (request.offerData != null)
                { 
                    orderObj.oOrderVO.oairQuotes = new Model.AddToCartRequest.OAirquotes();
                    orderObj.oOrderVO.oairQuotes.oairQuoteRQVO = new Model.AddToCartRequest.OAirquoterqvo();
                    orderObj.oOrderVO.oairQuotes.oairQuoteRQVO.ocurrencyCode = request.offerData.currencyCode;
                    orderObj.oOrderVO.oairQuotes.oairQuoteRQVO.oowner = request.offerData.Owner;
                    orderObj.oOrderVO.oairQuotes.oairQuoteRQVO.orequesterID = "AFF23FC90A07643B7855BD434A4B328F";
                    orderObj.oOrderVO.oairQuotes.oairQuoteRQVO.ototalPrice = request.offerData.totalPrice.ToString();
                    orderObj.oOrderVO.oairQuotes.oairQuoteRQVO.oflightOriginDestVOs = new Model.AddToCartRequest.OFlightorigindestvos[1];
                    orderObj.oOrderVO.oairQuotes.oairQuoteRQVO.oflightSegmentVOs = new Model.AddToCartRequest.OFlightsegmentvos[request.offerData.flightData.Count];

                    int i = 0;
                    string flightReference = string.Empty;
                    foreach(var flight in request.offerData.flightData)
                    {
                        //orderObj.oOrderVO.oairQuotes.oairQuoteRQVO.oflightOriginDestVOs[i] = new Model.AddToCartRequest.OFlightorigindestvos();
                        //orderObj.oOrderVO.oairQuotes.oairQuoteRQVO.oflightOriginDestVOs[i].oarrivalCode = flight.ArrivalAirport;
                        //orderObj.oOrderVO.oairQuotes.oairQuoteRQVO.oflightOriginDestVOs[i].odepartureCode = flight.DepAirport;
                        //orderObj.oOrderVO.oairQuotes.oairQuoteRQVO.oflightOriginDestVOs[i].oflightReferences = flight.flightReferences;
                        //orderObj.oOrderVO.oairQuotes.oairQuoteRQVO.oflightOriginDestVOs[i].ooriginDestKey = "OD" + (i+1).ToString();

                        orderObj.oOrderVO.oairQuotes.oairQuoteRQVO.oflightSegmentVOs[i] = new Model.AddToCartRequest.OFlightsegmentvos();
                        orderObj.oOrderVO.oairQuotes.oairQuoteRQVO.oflightSegmentVOs[i].oarrivalAirportCode = flight.ArrivalAirport;
                        orderObj.oOrderVO.oairQuotes.oairQuoteRQVO.oflightSegmentVOs[i].oarrivalDate = flight.ArrivalDate.ToString("yyyy-MM-dd");
                        orderObj.oOrderVO.oairQuotes.oairQuoteRQVO.oflightSegmentVOs[i].oarrivalTime = flight.ArrivalTime;
                        orderObj.oOrderVO.oairQuotes.oairQuoteRQVO.oflightSegmentVOs[i].oclassCode = flight.classCode;
                        orderObj.oOrderVO.oairQuotes.oairQuoteRQVO.oflightSegmentVOs[i].oclassMarketingName = flight.classMarketingName;
                        orderObj.oOrderVO.oairQuotes.oairQuoteRQVO.oflightSegmentVOs[i].odepAirportCode = flight.DepAirport;
                        orderObj.oOrderVO.oairQuotes.oairQuoteRQVO.oflightSegmentVOs[i].odepDate = flight.DepDate.ToString("yyyy-MM-dd");
                        orderObj.oOrderVO.oairQuotes.oairQuoteRQVO.oflightSegmentVOs[i].odepTime = flight.DepTime;
                        orderObj.oOrderVO.oairQuotes.oairQuoteRQVO.oflightSegmentVOs[i].omarketingAirLineID = flight.MarketingAirlineId;
                        orderObj.oOrderVO.oairQuotes.oairQuoteRQVO.oflightSegmentVOs[i].omarketingFlightNo = flight.MarketingFlightNo;
                        orderObj.oOrderVO.oairQuotes.oairQuoteRQVO.oflightSegmentVOs[i].ometadataKey = flight.flightMetaKey;
                        orderObj.oOrderVO.oairQuotes.oairQuoteRQVO.oflightSegmentVOs[i].ooperatingAirLineID = flight.OperatingArilineID;
                        orderObj.oOrderVO.oairQuotes.oairQuoteRQVO.oflightSegmentVOs[i].ooperatingFlightNo = flight.OperatingFlightNo;
                        orderObj.oOrderVO.oairQuotes.oairQuoteRQVO.oflightSegmentVOs[i].osegKey = flight.SegmentKey;
                        orderObj.oOrderVO.oairQuotes.oairQuoteRQVO.oflightSegmentVOs[i].odisplayFareType = "Published";
                        orderObj.oOrderVO.oairQuotes.oairQuoteRQVO.oflightSegmentVOs[i].obookingFareType = "Published";

                        if (request.offerData.ADTfareRuleRef != null)
                        {
                            orderObj.oOrderVO.oairQuotes.oairQuoteRQVO.oflightSegmentVOs[i].oADTFareRuleRef = request.offerData.ADTfareRuleRef;
                            orderObj.oOrderVO.oairQuotes.oairQuoteRQVO.oflightSegmentVOs[i].oADTFareRuleDefinition = request.offerData.ADTfareRuleDefinition;
                        }
                        if (request.offerData.CNNfareRuleRef != null)
                        {
                            orderObj.oOrderVO.oairQuotes.oairQuoteRQVO.oflightSegmentVOs[i].oCNNFareRuleRef = request.offerData.CNNfareRuleRef;
                            orderObj.oOrderVO.oairQuotes.oairQuoteRQVO.oflightSegmentVOs[i].oCNNFareRuleDefinition = request.offerData.CNNfareRuleDefinition;
                        }
                        if (request.offerData.INFfareRuleRef != null)
                        {
                            orderObj.oOrderVO.oairQuotes.oairQuoteRQVO.oflightSegmentVOs[i].oINFFareRuleRef = request.offerData.INFfareRuleRef;
                            orderObj.oOrderVO.oairQuotes.oairQuoteRQVO.oflightSegmentVOs[i].oINFFareRuleDefinition = request.offerData.INFfareRuleDefinition;
                        }

                        flightReference = flightReference + flight.flightReferences + " ";
                        i++;
                    }

                    orderObj.oOrderVO.oairQuotes.oairQuoteRQVO.oflightOriginDestVOs[0] = new Model.AddToCartRequest.OFlightorigindestvos();
                    orderObj.oOrderVO.oairQuotes.oairQuoteRQVO.oflightOriginDestVOs[0].oarrivalCode = request.offerData.arrivalCode;
                    orderObj.oOrderVO.oairQuotes.oairQuoteRQVO.oflightOriginDestVOs[0].odepartureCode = request.offerData.departureCode;
                    orderObj.oOrderVO.oairQuotes.oairQuoteRQVO.oflightOriginDestVOs[0].oflightReferences = flightReference.Trim();
                    orderObj.oOrderVO.oairQuotes.oairQuoteRQVO.oflightOriginDestVOs[0].ooriginDestKey = "OD1";
                }
                if (request.insuranceData != null)
                {
                    orderObj.oOrderVO.oinsuranceQuotes = new Model.AddToCartRequest.OInsurancequotes();
                    orderObj.oOrderVO.oinsuranceQuotes.oinsuranceBookingRequestVO = new Model.AddToCartRequest.OInsurancebookingrequestvo();
                    orderObj.oOrderVO.oinsuranceQuotes.oinsuranceBookingRequestVO.policySpecification = new Model.AddToCartRequest.Policyspecification();
                    orderObj.oOrderVO.oinsuranceQuotes.oinsuranceBookingRequestVO.policySpecification.policy = new Model.AddToCartRequest.Policy();
                    orderObj.oOrderVO.oinsuranceQuotes.oinsuranceBookingRequestVO.policySpecification.policy.payment = new Model.AddToCartRequest.Payment();
                    orderObj.oOrderVO.oinsuranceQuotes.oinsuranceBookingRequestVO.policySpecification.policy.payment.totalPremiumAmount = request.insuranceData.totalPremiumAmount;
                    orderObj.oOrderVO.oinsuranceQuotes.oinsuranceBookingRequestVO.policySpecification.policy.product = new Model.AddToCartRequest.Product();
                    orderObj.oOrderVO.oinsuranceQuotes.oinsuranceBookingRequestVO.policySpecification.policy.product.planID = request.insuranceData.planID;
                    orderObj.oOrderVO.oinsuranceQuotes.oinsuranceBookingRequestVO.policySpecification.policy.product.productCode = request.insuranceData.productCode;
                    orderObj.oOrderVO.oinsuranceQuotes.oinsuranceBookingRequestVO.policySpecification.policy.trip = new Model.AddToCartRequest.Trip();
                    orderObj.oOrderVO.oinsuranceQuotes.oinsuranceBookingRequestVO.policySpecification.policy.trip.departureDate = request.insuranceData.departureDate;
                    orderObj.oOrderVO.oinsuranceQuotes.oinsuranceBookingRequestVO.policySpecification.policy.trip.destination = new Model.AddToCartRequest.Destination[1];
                    orderObj.oOrderVO.oinsuranceQuotes.oinsuranceBookingRequestVO.policySpecification.policy.trip.destination[0] = new Model.AddToCartRequest.Destination();
                    orderObj.oOrderVO.oinsuranceQuotes.oinsuranceBookingRequestVO.policySpecification.policy.trip.destination[0].city = request.insuranceData.destinationCity;
                    orderObj.oOrderVO.oinsuranceQuotes.oinsuranceBookingRequestVO.policySpecification.policy.trip.destination[0].country = request.insuranceData.destinationCountry;
                    orderObj.oOrderVO.oinsuranceQuotes.oinsuranceBookingRequestVO.policySpecification.policy.trip.finalPaymentDate = request.insuranceData.finalPaymentDate;
                    orderObj.oOrderVO.oinsuranceQuotes.oinsuranceBookingRequestVO.policySpecification.policy.trip.initialTripDepositDate = request.insuranceData.initialTripDepositDate;
                    orderObj.oOrderVO.oinsuranceQuotes.oinsuranceBookingRequestVO.policySpecification.policy.trip.returnDate = request.insuranceData.returnDate;
                }
                if (request.vehicleData != null)
                {
                    orderObj.oOrderVO.ovehicleQuotes = new Model.AddToCartRequest.OVehiclequotes[1];
                    orderObj.oOrderVO.ovehicleQuotes[0] = new Model.AddToCartRequest.OVehiclequotes();
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo = new Model.AddToCartRequest.OVehiclequoterequestinfo();
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.driverType = new Model.AddToCartRequest.Drivertype();
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.driverType.age = request.vehicleData.driverAge;
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.driverType.quantity = request.vehicleData.driverQty;
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.fees = new Model.AddToCartRequest.Fees();
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.fees.fee = new Model.AddToCartRequest.Fee();
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.fees.fee.amount = "208.97";
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.fees.fee.currencyCode = "USD";
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.fees.fee.purpose = "22";
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.gasPrePay = "true";
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.luggageQty = "5";
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.passengerQty = request.vehicleData.passengerQty;
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.pickUpDateTime = string.Format("{0:s}", request.vehicleData.pickupDatetime);
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.pickUpLocation = new Model.AddToCartRequest.Pickuplocation();
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.pickUpLocation.locationCode = request.vehicleData.pickupLocation.ToString();
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.pickUpLocation.codeContext = request.vehicleData.pickupCodeContext;
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.rateQualifier = request.vehicleData.rateQualifier;
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.reference = new Model.AddToCartRequest.Reference();
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.reference.dateTime = string.Format("{0:s}", request.vehicleData.vehAvailDateTime);
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.reference.id = request.vehicleData.Id.ToString();
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.reference.id_Context = request.vehicleData.id_Context;
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.reference.type = request.vehicleData.type.ToString();
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.reference.url = request.vehicleData.url;
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.remark = new Model.AddToCartRequest.Remark();
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.remark.text = "";
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.rentalPaymentPref = new Model.AddToCartRequest.Rentalpaymentpref();
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.rentalPaymentPref.paymentType = "1";
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.resStatus = "Book";
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.returnDateTime = string.Format("{0:s}", request.vehicleData.returnDatetime);
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.returnLocation = new Model.AddToCartRequest.Returnlocation();
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.returnLocation.codeContext = request.vehicleData.returnCodeContext;
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.returnLocation.locationCode = request.vehicleData.returnLocation.ToString();
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.smokingAllowed = "false";
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.totalCharge = new Model.AddToCartRequest.Totalcharge();
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.totalCharge.rateTotalAmount = request.vehicleData.rateTotalAmount;
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.totalCharge.estimatedTotalAmount = request.vehicleData.rateTotalAmount;
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.totalCharge.currencyCode = request.vehicleData.currencyCode;
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.vehicleCharges = new Model.AddToCartRequest.Vehiclecharges();
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.vehicleCharges.vehicleCharge = new Model.AddToCartRequest.Vehiclecharge();
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.vehicleCharges.vehicleCharge.description = "Breakdown assistance";
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.vehicleCharges.vehicleCharge.includedInRate = "true";
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.vehicleCharges.vehicleCharge.purpose = "602.VCP.X";
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.vehicleCharges.vehicleCharge.taxInclusive = "true";
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.vehPref = new Model.AddToCartRequest.Vehpref();
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.vehPref.airConditionInd = request.vehicleData.airConditionAvailable.ToString();
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.vehPref.code = request.vehicleData.vehCode;
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.vehPref.codeContext = request.vehicleData.codeContext;
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.vehPref.driveType = request.vehicleData.driveType;
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.vehPref.fuelType = request.vehicleData.fuelType;
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.vehPref.transmissionType = request.vehicleData.transmissionType;
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.vehPref.vehClass = new Model.AddToCartRequest.Vehclass();
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.vehPref.vehClass.size = request.vehicleData.size.ToString();
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.vehPref.vehMakeModel = new Model.AddToCartRequest.Vehmakemodel();
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.vehPref.vehMakeModel.code = request.vehicleData.makeModelCode;
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.vehPref.vehMakeModel.name = request.vehicleData.makeModelName;
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.vehPref.vehType = new Model.AddToCartRequest.Vehtype();
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.vehPref.vehType.doorCount = request.vehicleData.doorCount.ToString();
                    orderObj.oOrderVO.ovehicleQuotes[0].ovehicleQuoteRequestInfo.vehPref.vehType.vehicleCategory = request.vehicleData.vehCategory.ToString();
                }

                Model.AddToCartResponse.AddToCartResponseModel response;
                var output = Util.ServiceBridge<Model.AddToCartRequest.AddToCartRequestModel>.Run(orderObj, ServiceTypes.AddToOrder, HttpMethod.Post);

                addToOrderResponse.addToCartRequest = JsonConvert.SerializeObject(orderObj);
                addToOrderResponse.addToCartResponse = output;
                var orderData = new OrderData();

                response = JsonConvert.DeserializeObject<Model.AddToCartResponse.AddToCartResponseModel>(output);

                if (response != null)
                {
                    if(response.oOrderVO.otransactionStatus.ToUpper() == "SUCCESS")
                    {
                        orderData.orderId = response.oOrderVO.oid;
                        orderData.externalOrderHash = response.oOrderVO.oexternalOrderHash;
                        orderData.externalOrderId = response.oOrderVO.oexternalOrderId;
                        orderData.airlineOrderAvailable = false;
                        orderData.vehicleOrderAvailable = false;
                        orderData.insuranceOrderAvailable = false;
                        if (response.oOrderVO.oairQuotes!= null)
                        {
                            orderData.airlineOrderAvailable = true;
                            orderData.airMainId = response.oOrderVO.oairQuotes.oairMainId;
                            orderData.airQuoteId = response.oOrderVO.oairQuotes.oid;
                            orderData.airtotalPrice = response.oOrderVO.oairQuotes.ototalPrice;
                            //orderData.flightSegment = response.oOrderVO.oairQuotes.oairQuoteRQVO.oflightSegmentVOs.osegKey;
                            orderData.airlineId = request.offerData.Owner;
                        }
                        if (response.oOrderVO.oinsuranceQuotes != null)
                        {
                            orderData.insuranceOrderAvailable = true;
                            orderData.insurancePlanID = response.oOrderVO.oinsuranceQuotes.oinsuranceBookingRequestVO.policySpecification.policy.product.planID;
                            orderData.insuranceProductCode = response.oOrderVO.oinsuranceQuotes.oinsuranceBookingRequestVO.policySpecification.policy.product.productCode;
                            orderData.insuranceQuoteId = response.oOrderVO.oinsuranceQuotes.oid;
                            orderData.insuranceTotalPrice = response.oOrderVO.oinsuranceQuotes.ototalPrice;
                            orderData.tripCost = request.insuranceData.tripCost;
                        }
                        if (response.oOrderVO.ovehicleQuotes != null)
                        {
                            orderData.vehicleOrderAvailable = true;
                            orderData.pricingCurrency = response.oOrderVO.ovehicleQuotes.opricingCurrency;
                            orderData.vehicleQuoteId = response.oOrderVO.ovehicleQuotes.oid;
                            orderData.vehicletotalPrice = response.oOrderVO.ovehicleQuotes.ototalPrice;
                            orderData.driverAge = request.vehicleData.driverAge;
                        }
                        addToOrderResponse.orderData = orderData;

                    }
                }
            }
            catch (Exception ex)
            {

            }

            return addToOrderResponse;
        }
    }
}
