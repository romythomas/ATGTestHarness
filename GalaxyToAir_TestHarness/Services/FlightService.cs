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
Module Name     :   FlightService.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas

Class contains business logic to construct flight search object, call the 
flight search service, parse the response and return data in business model.
\***************************************************************************/
namespace GalaxyToAir_TestHarness.Services
{

    public class FlightService : IFlightService
    {

        public FlightSearchResponseModel GetFlightDetails(BusinessModel.FlightSearchRequestModel request)
        {
            var flightObject = new Model.FlightSearchRequest.FlightSearchRequestModel();
            flightObject.aAirSearchRequest = new Model.FlightSearchRequest.AAirsearchrequest();
            var objFlightSearchResponseModel = new FlightSearchResponseModel();

            try
            { 
                flightObject.aAirSearchRequest.travelRequestVO = new Model.FlightSearchRequest.Travelrequestvo();
                flightObject.aAirSearchRequest.travelRequestVO.from = request.fromAirport;
                flightObject.aAirSearchRequest.travelRequestVO.to = request.toAirport;
                flightObject.aAirSearchRequest.travelRequestVO.departure = request.traveldate;

                if(request.roundTrip)
                {
                    flightObject.aAirSearchRequest.travelRequestVO.returnValue = request.returndate;
                }

                flightObject.aAirSearchRequest.passengerCountVO = new Model.FlightSearchRequest.Passengercountvo();

                flightObject.aAirSearchRequest.passengerCountVO.oadultCount = request.adults;
                flightObject.aAirSearchRequest.passengerCountVO.ochildCount = request.child;
                flightObject.aAirSearchRequest.passengerCountVO.oinfantCount = request.infant;

                flightObject.aAirSearchRequest.currCodes = new Model.FlightSearchRequest.Currcodes();

                flightObject.aAirSearchRequest.currCodes.value = request.currency;

                flightObject.aAirSearchRequest.preferences = new Model.FlightSearchRequest.Preferences();
                flightObject.aAirSearchRequest.preferences.cabinPreferences = new Model.FlightSearchRequest.Cabinpreference[1];

                flightObject.aAirSearchRequest.preferences.cabinPreferences[0] = new Model.FlightSearchRequest.Cabinpreference();
                flightObject.aAirSearchRequest.preferences.cabinPreferences[0].code = request.travelclass;
                flightObject.aAirSearchRequest.preferences.cabinPreferences[0].objectKey = request.travelclass;

                if (request.account != null && request.account != string.Empty)
                {
                    flightObject.aAirSearchRequest.qualifiers = new Model.FlightSearchRequest.Qualifiers();
                    flightObject.aAirSearchRequest.qualifiers.qualifier = new Model.FlightSearchRequest.Qualifier[1];
                    flightObject.aAirSearchRequest.qualifiers.qualifier[0] = new Model.FlightSearchRequest.Qualifier();
                    flightObject.aAirSearchRequest.qualifiers.qualifier[0].account = new Model.FlightSearchRequest.Account();
                    flightObject.aAirSearchRequest.qualifiers.qualifier[0].account.accountCode = request.account;
                }
                Model.FlightSearchResponse.FlightSearchResponseModel response = null;

                objFlightSearchResponseModel.offerData = new List<OfferData>();
                objFlightSearchResponseModel.flightSearchRquest = JsonConvert.SerializeObject(flightObject);
                FlightData objFlightData;
                OfferData objOffer;

                var output = Util.ServiceBridge<Model.FlightSearchRequest.FlightSearchRequestModel>.Run(flightObject, ServiceTypes.FlightSearch, HttpMethod.Post);

                objFlightSearchResponseModel.flightSearchResponse = output;

                response = JsonConvert.DeserializeObject<Model.FlightSearchResponse.FlightSearchResponseModel>(output);

                if (response != null)
                {
                    if (response.ns9AirShoppingRS.transactionStatus.ToUpper() == "SUCCESS")
                    { 
                        foreach (var owner in response.ns9AirShoppingRS.ns9offersGroup.ns9airlineOffers)
                        {
                            foreach(var offer in owner.ns9airlineOffer)
                            {
                                objOffer = new OfferData();

                                objOffer.OfferId = offer.ns9offerId;
                                objOffer.totalPrice = offer.ns9price;
                                objOffer.tax = offer.ns9taxTotal.ToString();
                                objOffer.Owner = owner.ns9owner;
                                objOffer.currencyCode = request.currency;
                                objOffer.departureCode = request.fromAirport;
                                objOffer.arrivalCode = request.toAirport;
                                if (offer.ns9offerPrice.Length > 0)
                                {
                                    objOffer.fareType = offer.ns9offerPrice[0].ns9fareComponent[0].ns9fareRemark;
                                    var offerPriceADT = offer.ns9offerPrice.Where(item => item.ns9passengerType == "ADT").FirstOrDefault();
                                    if(offerPriceADT != null)
                                    {
                                        objOffer.ADTfareRuleRef = offerPriceADT.ns9fareComponent[0].ns9fareRules.ns9objectKey;
                                        objOffer.ADTfareRuleDefinition = offerPriceADT.ns9fareComponent[0].ns9fareRules.ns9fareRuleRemark;
                                    }
                                    var offerPriceCNN = offer.ns9offerPrice.Where(item => item.ns9passengerType == "CNN").FirstOrDefault();
                                    if (offerPriceCNN != null)
                                    {
                                        objOffer.CNNfareRuleRef = offerPriceCNN.ns9fareComponent[0].ns9fareRules.ns9objectKey;
                                        objOffer.CNNfareRuleDefinition = offerPriceCNN.ns9fareComponent[0].ns9fareRules.ns9fareRuleRemark;
                                    }
                                    var offerPriceINF = offer.ns9offerPrice.Where(item => item.ns9passengerType == "INF").FirstOrDefault();
                                    if (offerPriceINF != null)
                                    {
                                        objOffer.INFfareRuleRef = offerPriceINF.ns9fareComponent[0].ns9fareRules.ns9objectKey;
                                        objOffer.INFfareRuleDefinition = offerPriceINF.ns9fareComponent[0].ns9fareRules.ns9fareRuleRemark;
                                    }
                                    //if (offer.ns9offerPrice[0].ns9fareComponent.Length > 0 )
                                    //{
                                    //    objOffer.ADTfareRuleRef = offer.ns9offerPrice[0].ns9fareComponent[0].ns9fareRules.ns9objectKey;
                                    //    objOffer.ADTfareRuleDefinition = offer.ns9offerPrice[0].ns9fareComponent[0].ns9fareRules.ns9fareRuleRemark;
                                    //    objOffer.fareType = offer.ns9offerPrice[0].ns9fareComponent[0].ns9fareRemark;
                                    //}
                                }
                                //if (offer.ns9offerPrice.Length > 1)
                                //{
                                //    if (offer.ns9offerPrice[1].ns9fareComponent.Length > 0)
                                //    {
                                //        objOffer.CNNfareRuleRef = offer.ns9offerPrice[1].ns9fareComponent[0].ns9fareRules.ns9objectKey;
                                //        objOffer.CNNfareRuleDefinition = offer.ns9offerPrice[1].ns9fareComponent[0].ns9fareRules.ns9fareRuleRemark;
                                //    }
                                //}
                                //if (offer.ns9offerPrice.Length > 2)
                                //{
                                //    if (offer.ns9offerPrice[1].ns9fareComponent.Length > 0)
                                //    {
                                //        objOffer.INFfareRuleRef = offer.ns9offerPrice[2].ns9fareComponent[0].ns9fareRules.ns9objectKey;
                                //        objOffer.INFfareRuleDefinition = offer.ns9offerPrice[2].ns9fareComponent[0].ns9fareRules.ns9fareRuleRemark;
                                //    }
                                //}
                                objOffer.flightData = new List<FlightData>();

                                foreach(var applicableFlight in offer.ns9associations)
                                {
                                    objFlightData = new FlightData();

                                    objFlightData.SegmentKey = applicableFlight.ns9applicableFlight.ns9flightReference.ns9value;

                                    var flightSegement = response.ns9AirShoppingRS.ns9dataLists.ns9flightSegmentList.ns9flightSegment
                                        .Where(item => item.ns9segmentKey == objFlightData.SegmentKey)
                                        .FirstOrDefault();

                                    if(flightSegement != null)
                                    {
                                        objFlightData.ArrivalAirport = flightSegement.ns9arrivalAirPortCode;
                                        objFlightData.ArrivalDate = DateTime.Parse(flightSegement.ns9arrivalDate);
                                        objFlightData.ArrivalTime = flightSegement.ns9arrivalTime;
                                        objFlightData.DepAirport = flightSegement.ns9departureAirPortCode;
                                        objFlightData.DepDate = DateTime.Parse(flightSegement.ns9departureDate);
                                        objFlightData.DepTime = flightSegement.ns9departureTime;
                                        objFlightData.flightReferences = flightSegement.ns9segmentKey;
                                        objFlightData.SegmentKey = flightSegement.ns9segmentKey;
                                        objFlightData.MarketingAirlineId = flightSegement.ns9marketingAirLine;
                                        objFlightData.MarketingFlightNo = flightSegement.ns9flightNo.ToString();
                                        objFlightData.OperatingArilineID = flightSegement.ns9operatingCarrierID;
                                        objFlightData.OperatingFlightNo = flightSegement.ns9operatingCarrierFlightNo.ToString();
                                        objFlightData.classCode = applicableFlight.ns9applicableFlight.ns9flightSegmentReference.ns9cabinDesignator;
                                        objFlightData.classMarketingName = applicableFlight.ns9applicableFlight.ns9flightSegmentReference.ns9marketingName;
                                        if(flightSegement.ns9direction.ToUpper() == "INBOUND")
                                        {
                                            objFlightData.flightMetaKey = "1";
                                        }
                                        else
                                        {
                                            objFlightData.flightMetaKey = "0";
                                        }
                                        
                                    }
                                    objOffer.flightData.Add(objFlightData);
                                }
                                objFlightSearchResponseModel.offerData.Add(objOffer);
                            }
                        }
                    }
                }

            }catch(Exception ex)
            {

            }
            return objFlightSearchResponseModel;
        }

        public AirFareRuleResponseModel GetFareRules(AirFareRuleRequestModel request)
        {
            var fareRuleRequest = new Model.AirFareRuleRequest.AirFareRuleRequest();
            var fareRuleResponse = new AirFareRuleResponseModel();
            try
            {
                if(request != null)
                {
                    int paxCount = 0;
                    if(request.ADTfareInfoRef != null)
                    {
                        paxCount++;
                    }
                    if (request.CNNfareInfoRef != null)
                    {
                        paxCount++;
                    }
                    if (request.INFfareInfoRef != null)
                    {
                        paxCount++;
                    }
                    fareRuleRequest.fairFareRulesRequest = new Model.AirFareRuleRequest.FAirfarerulesrequest();
                    fareRuleRequest.fairFareRulesRequest.fareRules = new Model.AirFareRuleRequest.Farerule[paxCount];

                    if(paxCount>0)
                    {
                        fareRuleRequest.fairFareRulesRequest.fareRules[0] = new Model.AirFareRuleRequest.Farerule();
                        fareRuleRequest.fairFareRulesRequest.fareRules[0].fareInfoRef = request.ADTfareInfoRef;
                        fareRuleRequest.fairFareRulesRequest.fareRules[0].fareRuleKey = request.ADTfareRuleKey;
                    }
                    if (paxCount > 1)
                    {
                        fareRuleRequest.fairFareRulesRequest.fareRules[1] = new Model.AirFareRuleRequest.Farerule();
                        fareRuleRequest.fairFareRulesRequest.fareRules[1].fareInfoRef = request.CNNfareInfoRef;
                        fareRuleRequest.fairFareRulesRequest.fareRules[1].fareRuleKey = request.CNNfareRuleKey;
                    }
                    if (paxCount > 2)
                    {
                        fareRuleRequest.fairFareRulesRequest.fareRules[2] = new Model.AirFareRuleRequest.Farerule();
                        fareRuleRequest.fairFareRulesRequest.fareRules[2].fareInfoRef = request.INFfareInfoRef;
                        fareRuleRequest.fairFareRulesRequest.fareRules[2].fareRuleKey = request.INFfareRuleKey;
                    }

                    fareRuleResponse.airFareRuleRequest = JsonConvert.SerializeObject(fareRuleRequest);

                    var output = Util.ServiceBridge<Model.AirFareRuleRequest.AirFareRuleRequest>.Run(fareRuleRequest, ServiceTypes.FareRule, HttpMethod.Post);
                
                    fareRuleResponse.airFareRuleResponse = output;

                    Model.AirFareRuleResponse.AirFareRuleResponseModel response;

                    response = JsonConvert.DeserializeObject<Model.AirFareRuleResponse.AirFareRuleResponseModel>(output);

                    fareRuleResponse.FareRule = string.Empty;

                    if (response != null)
                    {
                        if (response.ns10AirFareRulesResponse.transactionStatus.ToUpper() == "SUCCESS")
                        {
                            foreach (var item in response.ns10AirFareRulesResponse.fareRules)
                            {
                                fareRuleResponse.FareRule = fareRuleResponse.FareRule + item.description + "\n\n";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return fareRuleResponse;
        }

        public PostBookingFareRuleResponseModel GetPostBookingFareRules(PostBookingFareRuleRequestModel request)
        {
            var fareRuleRequest = new Model.PostBookingFareRuleRequest.PostBookingFareRuleRequestModel();
            var fareRuleResponse = new PostBookingFareRuleResponseModel();
            try
            {
                if (request != null)
                {

                    fareRuleRequest.oOrderVO = new Model.PostBookingFareRuleRequest.OOrdervo();
                    fareRuleRequest.oOrderVO.oairQuotes = new Model.PostBookingFareRuleRequest.OAirquotes();
                    fareRuleRequest.oOrderVO.oairQuotes.oid = request.OrderId; 

                    fareRuleResponse.fareRuleRequest = JsonConvert.SerializeObject(fareRuleRequest);

                    var output = Util.ServiceBridge<Model.PostBookingFareRuleRequest.PostBookingFareRuleRequestModel>.Run(fareRuleRequest, ServiceTypes.PostBookingFareRule, HttpMethod.Post);

                    fareRuleResponse.fareRuleResponse = output;

                    Model.PostBookingFareRuleResponse.PostBookingFareRuleResponseModel response;

                    response = JsonConvert.DeserializeObject<Model.PostBookingFareRuleResponse.PostBookingFareRuleResponseModel>(output);

                    fareRuleResponse.FareRule = string.Empty;

                    if (response != null)
                    {
                        //if (response.oOrderVO.otransactionStatus.ToUpper() == "SUCCESS")
                        //{
                            foreach (var item in response.oOrderVO.oairQuotes.oairFareRulesResponse.fareRules)
                            {
                                fareRuleResponse.FareRule = fareRuleResponse.FareRule + item.description + "\n\n";
                            }
                        //}
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return fareRuleResponse;
        }

    }
}
