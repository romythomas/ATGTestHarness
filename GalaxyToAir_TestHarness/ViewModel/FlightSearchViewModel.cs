using System;
using System.Windows;
using System.Xml;
using System.Xml.Linq;
using System.Collections;
using System.Collections.Generic;
using GalaxyToAir_TestHarness.Model;
using GalaxyToAir_TestHarness.Util;
using GalaxyToAir_TestHarness.Services;
using GalaxyToAir_TestHarness.BusinessModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
/****************************** Module Header ******************************\
Module Name     :   FlightSearchViewModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas

View model for Flight Search screen
\***************************************************************************/
namespace GalaxyToAir_TestHarness.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class FlightSearchViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the FlightSearchViewModel class.
        /// </summary>
        /// 

        private string _fromAirport;
        public string fromAirport
        {
            get { return _fromAirport; }
            set { _fromAirport = value; RaisePropertyChanged(); }
        }

        private string _toAirport;
        public string toAirport
        {
            get { return _toAirport; }
            set { _toAirport = value; RaisePropertyChanged(); }
        }

        private string _adults;
        public string adults
        {
            get { return _adults; }
            set { _adults = value; RaisePropertyChanged(); }
        }

        private string _child;
        public string child
        {
            get { return _child; }
            set { _child = value; RaisePropertyChanged(); }
        }

        private string _infant;
        public string infant
        {
            get { return _infant; }
            set { _infant = value; RaisePropertyChanged(); }
        }

        private DateTime _traveldate;
        public DateTime traveldate
        {
            get { return _traveldate; }
            set { _traveldate = value; RaisePropertyChanged(); }
        }

        private Boolean _roundTrip;
        public Boolean roundTrip
        {
            get { return _roundTrip; }
            set { _roundTrip = value; RaisePropertyChanged(); }
        }

        private Boolean _oneWayTrip;
        public Boolean oneWayTrip
        {
            get { return _oneWayTrip; }
            set { _oneWayTrip = value; RaisePropertyChanged(); }
        }

        private DateTime _returndate;
        public DateTime returndate
        {
            get { return _returndate; }
            set { _returndate = value; RaisePropertyChanged(); }
        }

        private string _currency;
        public string currency
        {
            get { return _currency; }
            set { _currency = value; RaisePropertyChanged(); }
        }

        private string _travelclass;
        public string travelclass
        {
            get { return _travelclass; }
            set { _travelclass = value; RaisePropertyChanged(); }
        }

        private string _account;
        public string account
        {
            get { return _account; }
            set { _account = value; RaisePropertyChanged(); }
        }

        private List<OfferData> _offerDataList;
        public List<OfferData> offerDataList
        {
            get { return _offerDataList; }
            set { _offerDataList = value; RaisePropertyChanged(); }
        }

        private OfferData _offerData;
        public OfferData offerData
        {
            get { return _offerData; }
            set { _offerData = value; RaisePropertyChanged(); }
        }

        private List<Airport> _lstAirport;
        public List<Airport> lstAirport
        {
            get { return _lstAirport; }
            set { _lstAirport = value; RaisePropertyChanged(); }
        }

        private List<Currency> _lstCurrency;
        public List<Currency> lstCurrency
        {
            get { return _lstCurrency; }
            set { _lstCurrency = value; RaisePropertyChanged(); }
        }

        private Supplierlist[] _lstSuppliers;
        public Supplierlist[] lstSuppliers
        {
            get { return _lstSuppliers; }
            set { _lstSuppliers = value; RaisePropertyChanged(); }
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

        public FlightSearchViewModel(IFlightService flightService)
        {

            _flightService = flightService;

            var loc = new ViewModelLocator();

            lstAirport = loc.LandingPage.lstAirport;
            lstCurrency = loc.LandingPage.lstCurrency;
            if (loc.LandingPage.lstSuppliers != null)
            {
                lstSuppliers = loc.LandingPage.lstSuppliers.supplierList;
            }

            traveldate = DateTime.Now.AddDays(2);
            returndate = DateTime.Now.AddDays(3);
            fromAirport = "LAX";
            toAirport = "LAS";
            adults = "1";
            child = "0";
            infant = "0";
            currency = "USD";
            travelclass = "Economy";
            roundTrip = true;
            oneWayTrip = false;
            account = "";
        }

        private RelayCommand _cmdSearchClick;
        public RelayCommand SearchClick
        {
            get
            {
                return _cmdSearchClick ?? (_cmdSearchClick =
                    new RelayCommand(
                  () =>
                  {
                      try
                      {
                          UIHelper.SetBusyState();

                          var request = new FlightSearchRequestModel() { fromAirport = fromAirport, toAirport = toAirport, adults = adults,
                            child = child,infant = infant,roundTrip = roundTrip,traveldate = traveldate.ToString("yyyy-MM-dd"), 
                            returndate=returndate.ToString("yyyy-MM-dd"), currency = currency, travelclass = travelclass, account = account};

                          var response = _flightService.GetFlightDetails(request);
                          offerDataList = response.offerData;

                          var req = response.flightSearchRquest;

                          dynamic parsedJsonRequest = JsonConvert.DeserializeObject(req);
                          jsonRequest = JsonConvert.SerializeObject(parsedJsonRequest, Newtonsoft.Json.Formatting.Indented);


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

                          if(response.flightSearchResponse != null)
                          {
                              var resp = response.flightSearchResponse;

                              dynamic parsedJsonResponse = JsonConvert.DeserializeObject(resp);
                              jsonResponse = JsonConvert.SerializeObject(parsedJsonResponse, Newtonsoft.Json.Formatting.Indented);

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
                      catch (Exception ex)
                      {

                      }
                  }));
            }
        }

        private RelayCommand<OfferData> _selectFlight;
        public RelayCommand<OfferData> SelectFlight
        {
            get
            {
                return _selectFlight ?? (_selectFlight =
                    new RelayCommand<OfferData>(
                  (data) =>
                  {
                      offerData = data;
                      offerData.noOfAdult = int.Parse(adults); 
                      offerData.noOfChild = int.Parse(child);
                      offerData.noOfInfant = int.Parse(infant);
                      MessengerInstance.Send(PageNavigation.VehicleSearch);
                  }));
            }
        }

        private RelayCommand _skipClick;
        public RelayCommand SkipClick
        {
            get
            {
                return _skipClick ?? (_skipClick =
                    new RelayCommand(
                  () =>
                  {
                      offerData = null;
                      MessengerInstance.Send(PageNavigation.VehicleSearch);
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
                      Clipboard.SetText(XElement.Parse(xmlResponse.OuterXml).ToString());
                  }));
            }
        }
        
        public void ClearFields()
        {
           fromAirport = "LAX";
           toAirport  = "LAS";
            adults = "1";
            child = "0";
            infant = "0";
            currency = "USD";
            travelclass = "Economy";
            traveldate = DateTime.Now.AddDays(2);
            returndate = DateTime.Now.AddDays(3);
            offerDataList = null;
            offerData = null;
            jsonRequest = "";
            jsonResponse = "";
            roundTrip = true;
            oneWayTrip = false;
            treeViewRequest = null;
            treeViewResponse = null;
            xmlRequest = null;
            xmlResponse = null;
            account = "";
        }
    }
}