using System;
using System.Xml;
using System.Xml.Linq;
using System.Windows;
using System.Collections;
using System.Collections.Generic;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaxyToAir_TestHarness.BusinessModel;
using GalaxyToAir_TestHarness.Model;
using GalaxyToAir_TestHarness.Services;
using GalaxyToAir_TestHarness.Util;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
/****************************** Module Header ******************************\
Module Name     :   VehicleSearchViewModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas

View model for vehicle search screen
\***************************************************************************/
namespace GalaxyToAir_TestHarness.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class VehicleSearchViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the VehicleSearchViewModel class.
        /// </summary>
        /// 

        private DateTime _pickupDate;
        public DateTime pickupDate
        {
            get { return _pickupDate; }
            set { _pickupDate = value; RaisePropertyChanged(); }
        }
        public string _pickupHour;
        public string pickupHour
        {
            get { return _pickupHour; }
            set { _pickupHour = value; RaisePropertyChanged(); }
        }
        public string _pickupMinute;
        public string pickupMinute
        {
            get { return _pickupMinute; }
            set { _pickupMinute = value; RaisePropertyChanged(); }
        }
        public string _pickupLocation;
        public string pickupLocation
        {
            get { return _pickupLocation; }
            set { _pickupLocation = value; RaisePropertyChanged(); }
        }
        private DateTime _returnDate;
        public DateTime returnDate
        {
            get { return _returnDate; }
            set { _returnDate = value; RaisePropertyChanged(); }
        }
        public string _returnHour;
        public string returnHour
        {
            get { return _returnHour; }
            set { _returnHour = value; RaisePropertyChanged(); }
        }
        public string _returnMinute;
        public string returnMinute
        {
            get { return _returnMinute; }
            set { _returnMinute = value; RaisePropertyChanged(); }
        }
        public string _returnLocation;
        public string returnLocation
        {
            get { return _returnLocation; }
            set { _returnLocation = value; RaisePropertyChanged(); }
        }
        public string _currency;
        public string currency
        {
            get { return _currency; }
            set { _currency = value; RaisePropertyChanged(); }
        }
        public string _noOfPassengers;
        public string noOfPassengers
        {
            get { return _noOfPassengers; }
            set { _noOfPassengers = value; RaisePropertyChanged(); }
        }
        public string _country;
        public string country
        {
            get { return _country; }
            set { _country = value; RaisePropertyChanged(); }
        }
        public string _age;
        public string age
        {
            get { return _age; }
            set { _age = value; RaisePropertyChanged(); }
        }

        public List<VehicleData> _vehicleDataList;
        public List<VehicleData> vehicleDataList
        {
            get { return _vehicleDataList; }
            set { _vehicleDataList = value; RaisePropertyChanged(); }
        }

        public VehicleData _vehicleData;
        public VehicleData vehicleData
        {
            get { return _vehicleData; }
            set { _vehicleData = value; RaisePropertyChanged(); }
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

        private List<Country> _lstCountry;
        public List<Country> lstCountry
        {
            get { return _lstCountry; }
            set { _lstCountry = value; RaisePropertyChanged(); }
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

        private readonly IVehicleService _vehicleService;

        public VehicleSearchViewModel(IVehicleService vehicleService)
        {

            var loc = new ViewModelLocator();

            lstAirport = loc.LandingPage.lstAirport;
            lstCurrency = loc.LandingPage.lstCurrency;
            lstCountry = loc.LandingPage.lstCountry;

            _vehicleService = vehicleService;
            pickupDate = DateTime.Now.AddDays(2);
            returnDate = DateTime.Now.AddDays(3);
            pickupHour = "00";
            pickupMinute = "00";
            returnHour = "00";
            returnMinute = "00";
            country = "US";
            currency = "USD";
            pickupLocation = "LAS";
            returnLocation = "LAS";
            noOfPassengers = "2";
            age = "30";

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

                          var request = new VehicleSearchRequestModel();
                          request.age=age;
                          request.country = country;
                          request.currency = currency;
                          request.noOfPassengers = noOfPassengers;
                          request.pickupLocation = pickupLocation;
                          request.returnLocation = returnLocation;

                          string dtstring;
                          DateTime dtValue;

                          dtstring = pickupDate.ToString("MM/dd/yyyy") + " " + pickupHour + ":" + pickupMinute + ":00";
                          DateTime.TryParse(dtstring, out dtValue);
                          request.pickupDateTime = dtValue;

                          dtstring = returnDate.ToString("MM/dd/yyyy") + " " + returnHour + ":" + returnMinute + ":00";
                          DateTime.TryParse(dtstring, out dtValue);
                          request.returnDateTime = dtValue;

                          var response=_vehicleService.GetVehicleDetails(request);
                          vehicleDataList = response.vehicleData;
                          
                          var req = response.vehicleSearchRquest;
                          var resp = response.vehicleSearchResponse;

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
                      catch (Exception ex)
                      {

                      }
                  }));
            }
        }

        private RelayCommand<VehicleData> _selectVehicle;
        public RelayCommand<VehicleData> SelectVehicle
        {
            get
            {
                return _selectVehicle ?? (_selectVehicle =
                    new RelayCommand<VehicleData>(
                  (data) =>
                  {
                      UIHelper.SetBusyState();

                      vehicleData = data;
                      MessengerInstance.Send(PageNavigation.InsuranceSearch);
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
                      UIHelper.SetBusyState();

                      vehicleData = null;
                      MessengerInstance.Send(PageNavigation.InsuranceSearch);
                  }));
            }
        }

        private RelayCommand _backClick;
        public RelayCommand BackClick
        {
            get
            {
                return _backClick ?? (_backClick =
                    new RelayCommand(
                  () =>
                  {
                      UIHelper.SetBusyState();
                      MessengerInstance.Send(PageNavigation.FlightSearch);
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
            pickupDate = DateTime.Now.AddDays(2);
            returnDate = DateTime.Now.AddDays(3);
            pickupHour = "00";
            pickupMinute = "00";
            returnHour = "00";
            returnMinute = "00";
            country = "US";
            currency = "USD";
            pickupLocation = "LAS";
            returnLocation = "LAS";
            noOfPassengers = "2";
            age = "30";
            vehicleDataList = null;
            vehicleData = null;
            jsonRequest = "";
            jsonResponse = "";
            treeViewRequest = null;
            treeViewResponse = null;
            xmlRequest = null;
            xmlResponse = null;

        }
    }
}