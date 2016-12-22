using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Xml;
using System.Xml.Linq;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaxyToAir_TestHarness.Services;
using GalaxyToAir_TestHarness.BusinessModel;
using GalaxyToAir_TestHarness.Util;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
/****************************** Module Header ******************************\
Module Name     :   FareRulesViewModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas

This is the view model for Fare Rules/Rental Conditions screen
\***************************************************************************/
namespace GalaxyToAir_TestHarness.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class FareRulesViewModel: ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the BookingDetailsViewModel class.
        /// </summary>
        /// 

        private string _fareRule;
        public string fareRule
        {
            get { return _fareRule; }
            set { _fareRule = value; RaisePropertyChanged(); }
        }

        private PageNavigation _origin;
        public PageNavigation origin
        {
            get { return _origin; }
            set { _origin = value; RaisePropertyChanged(); }
        }

        private string _jsonRequest;
        public string jsonRequest
        {
            get { return _jsonRequest; }
            set { _jsonRequest = value; RaisePropertyChanged(); }
        }

        private string _jsonResponse;
        public string jsonResponse
        {
            get { return _jsonResponse; }
            set { _jsonResponse = value; RaisePropertyChanged(); }
        }

        private XmlDocument _xmlRequest;
        public XmlDocument xmlRequest
        {
            get { return _xmlRequest; }
            set { _xmlRequest = value; RaisePropertyChanged(); }
        }

        private XmlDocument _xmlResponse;
        public XmlDocument xmlResponse
        {
            get { return _xmlResponse; }
            set { _xmlResponse = value; RaisePropertyChanged(); }
        }

        private List<JToken> _treeViewRequest;
        public List<JToken> treeViewRequest
        {
            get { return _treeViewRequest; }
            set { _treeViewRequest = value; RaisePropertyChanged(); }
        }

        private List<JToken> _treeViewResponse;
        public List<JToken> treeViewResponse
        {
            get { return _treeViewResponse; }
            set { _treeViewResponse = value; RaisePropertyChanged(); }
        }

        private readonly IFlightService _flightService;
        private readonly IVehicleService _vehicleService;

        public FareRulesViewModel(IFlightService flightService, IVehicleService vehicleService)
        {
            _flightService = flightService;
            _vehicleService = vehicleService;
            origin = PageNavigation.Landing;
        }

        public void PopulateAirFareRule()
        {
            var loc = new ViewModelLocator();

            var offerData = loc.FlightSearch.offerData;

            if (offerData != null)
            {
                origin = PageNavigation.OrderDetails;

                var airFareRuleRequest = new AirFareRuleRequestModel { 
                        ADTfareInfoRef = offerData.ADTfareRuleRef, 
                        ADTfareRuleKey = offerData.ADTfareRuleDefinition,
                        CNNfareInfoRef = offerData.CNNfareRuleRef,
                        CNNfareRuleKey = offerData.CNNfareRuleDefinition,
                        INFfareInfoRef = offerData.INFfareRuleRef,
                        INFfareRuleKey = offerData.INFfareRuleDefinition
                };
                var airFareRuleResponse = _flightService.GetFareRules(airFareRuleRequest);
                if(airFareRuleResponse != null)
                {
                    fareRule = airFareRuleResponse.FareRule;

                    var req = airFareRuleResponse.airFareRuleRequest;
                    var resp = airFareRuleResponse.airFareRuleResponse;

                    dynamic parsedJsonRequest = JsonConvert.DeserializeObject(req);
                    jsonRequest = JsonConvert.SerializeObject(parsedJsonRequest, Newtonsoft.Json.Formatting.Indented);

                    dynamic parsedJsonResponse = JsonConvert.DeserializeObject(resp);
                    jsonResponse = JsonConvert.SerializeObject(parsedJsonResponse, Newtonsoft.Json.Formatting.Indented);

                    var xmlDocRequest = JsonConvert.DeserializeXmlNode(jsonRequest, "root");

                    xmlRequest = xmlDocRequest;


                    List<JToken> jtokenRequest;
                    List<JToken> jtokenResponse;

                    jtokenRequest = new List<JToken>();

                    var requestToken = JToken.Parse(jsonRequest);

                    if (requestToken != null)
                    {
                        jtokenRequest.Add(requestToken);
                    }

                    treeViewRequest = jtokenRequest;

                    var xmlDocResponse = JsonConvert.DeserializeXmlNode(jsonResponse, "root");

                    xmlResponse = xmlDocResponse;

                    jtokenResponse = new List<JToken>();

                    var responseToken = JToken.Parse(jsonResponse);

                    if (responseToken != null)
                    {
                        jtokenResponse.Add(responseToken);
                    }

                    treeViewResponse = jtokenResponse;
                }
            }
        }

        public void PopulatePostBookingAirFareRule()
        {
            origin = PageNavigation.Book;

            var loc = new ViewModelLocator();
            var bookingRequestModel = loc.OrderDetails.bookingRequestModel;

            if (bookingRequestModel.orderData.airQuoteId != 0)
            {
                var fareRuleRequest = new PostBookingFareRuleRequestModel { OrderId = bookingRequestModel.orderData.airQuoteId.ToString() };
                var fareRuleResponse = _flightService.GetPostBookingFareRules(fareRuleRequest);

                if (fareRuleResponse != null)
                {
                    fareRule = fareRuleResponse.FareRule;

                    var req = fareRuleResponse.fareRuleRequest;
                    var resp = fareRuleResponse.fareRuleResponse;

                    dynamic parsedJsonRequest = JsonConvert.DeserializeObject(req);
                    jsonRequest = JsonConvert.SerializeObject(parsedJsonRequest, Newtonsoft.Json.Formatting.Indented);

                    dynamic parsedJsonResponse = JsonConvert.DeserializeObject(resp);
                    jsonResponse = JsonConvert.SerializeObject(parsedJsonResponse, Newtonsoft.Json.Formatting.Indented);

                    var xmlDocRequest = JsonConvert.DeserializeXmlNode(jsonRequest, "root");

                    xmlRequest = xmlDocRequest;


                    List<JToken> jtokenRequest;
                    List<JToken> jtokenResponse;

                    jtokenRequest = new List<JToken>();

                    var requestToken = JToken.Parse(jsonRequest);

                    if (requestToken != null)
                    {
                        jtokenRequest.Add(requestToken);
                    }

                    treeViewRequest = jtokenRequest;

                    var xmlDocResponse = JsonConvert.DeserializeXmlNode(jsonResponse, "root");

                    xmlResponse = xmlDocResponse;

                    jtokenResponse = new List<JToken>();

                    var responseToken = JToken.Parse(jsonResponse);

                    if (responseToken != null)
                    {
                        jtokenResponse.Add(responseToken);
                    }

                    treeViewResponse = jtokenResponse;
                }
            }

        }

        public void PopulateRentalCondition()
        {
            var loc = new ViewModelLocator();

            var vehicleData = loc.VehicleSearch.vehicleData;

            if (vehicleData != null)
            {
                origin = PageNavigation.OrderDetails;

                var rentalConditionRequest = new VehicleRentalConditionRequestModel();

                rentalConditionRequest.countryCode = vehicleData.country;
                rentalConditionRequest.dateTime = vehicleData.vehAvailDateTime;
                rentalConditionRequest.idContext = vehicleData.id_Context;
                rentalConditionRequest.isoCurrency = vehicleData.currencyCode;
                rentalConditionRequest.pickupCodeContext = vehicleData.pickupCodeContext;
                rentalConditionRequest.pickupDateTime = vehicleData.pickupDatetime;
                rentalConditionRequest.pickupLocationCode = vehicleData.pickupLocation.ToString();
                rentalConditionRequest.pickupLocationName = vehicleData.pickupLocation.ToString();
                rentalConditionRequest.returnCodeContext = vehicleData.returnCodeContext;
                rentalConditionRequest.returnDateTime = vehicleData.returnDatetime;
                rentalConditionRequest.returnLocationCode = vehicleData.returnLocation.ToString();

                rentalConditionRequest.returnLocationName = vehicleData.returnLocation.ToString();
                rentalConditionRequest.url = vehicleData.url;
                rentalConditionRequest.vehID = vehicleData.Id.ToString();
                rentalConditionRequest.vehType = vehicleData.vehCategory.ToString();

                var rentalConditionResponse = _vehicleService.GetRentalCondition(rentalConditionRequest);

                if (rentalConditionResponse != null)
                {
                    fareRule = rentalConditionResponse.rentalCondition;

                    var req = rentalConditionResponse.rentalConditionRequest;
                    var resp = rentalConditionResponse.rentalConditionResponse;

                    dynamic parsedJsonRequest = JsonConvert.DeserializeObject(req);
                    jsonRequest = JsonConvert.SerializeObject(parsedJsonRequest, Newtonsoft.Json.Formatting.Indented);

                    dynamic parsedJsonResponse = JsonConvert.DeserializeObject(resp);
                    jsonResponse = JsonConvert.SerializeObject(parsedJsonResponse, Newtonsoft.Json.Formatting.Indented);

                    var xmlDocRequest = JsonConvert.DeserializeXmlNode(jsonRequest, "root");

                    xmlRequest = xmlDocRequest;


                    List<JToken> jtokenRequest;
                    List<JToken> jtokenResponse;

                    jtokenRequest = new List<JToken>();

                    var requestToken = JToken.Parse(jsonRequest);

                    if (requestToken != null)
                    {
                        jtokenRequest.Add(requestToken);
                    }

                    treeViewRequest = jtokenRequest;

                    var xmlDocResponse = JsonConvert.DeserializeXmlNode(jsonResponse, "root");

                    xmlResponse = xmlDocResponse;

                    jtokenResponse = new List<JToken>();

                    var responseToken = JToken.Parse(jsonResponse);

                    if (responseToken != null)
                    {
                        jtokenResponse.Add(responseToken);
                    }

                    treeViewResponse = jtokenResponse;
                }
            }
        }

        private RelayCommand _cmdBack;
        public RelayCommand cmdBack
        {
            get
            {
                return _cmdBack ?? (_cmdBack =
                    new RelayCommand(
                  () =>
                  {
                      UIHelper.SetBusyState();
                      ClearFields();
                      MessengerInstance.Send(origin);
                  }));
            }
        }

        private RelayCommand _copyJsonRequest;
        public RelayCommand copyJsonRequest
        {
            get
            {
                return _copyJsonRequest ?? (_copyJsonRequest =
                    new RelayCommand(
                  () =>
                  {
                      UIHelper.SetBusyState();
                      Clipboard.SetText(jsonRequest);
                  }));
            }
        }

        private RelayCommand _copyJsonResponse;
        public RelayCommand copyJsonResponse
        {
            get
            {
                return _copyJsonResponse ?? (_copyJsonResponse =
                    new RelayCommand(
                  () =>
                  {
                      UIHelper.SetBusyState();
                      Clipboard.SetText(jsonResponse);
                  }));
            }
        }

        private RelayCommand _copyXmlRequest;
        public RelayCommand copyXmlRequest
        {
            get
            {
                return _copyXmlRequest ?? (_copyXmlRequest =
                    new RelayCommand(
                  () =>
                  {
                      UIHelper.SetBusyState();
                      Clipboard.SetText(XElement.Parse(xmlRequest.OuterXml).ToString());
                  }));
            }
        }

        private RelayCommand _copyXmlResponse;
        public RelayCommand copyXmlResponse
        {
            get
            {
                return _copyXmlResponse ?? (_copyXmlResponse =
                    new RelayCommand(
                  () =>
                  {
                      UIHelper.SetBusyState();
                      Clipboard.SetText(XElement.Parse(xmlResponse.OuterXml).ToString());
                  }));
            }
        }

        public void ClearFields()
        {
            fareRule = "";
            jsonRequest = "";
            jsonResponse = "";
            treeViewRequest = null;
            treeViewResponse = null;
            xmlRequest = null;
            xmlResponse = null;
        }
    }
}