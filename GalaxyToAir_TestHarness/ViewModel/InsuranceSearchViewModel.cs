using System;
using System.Windows;
using System.Xml;
using System.Xml.Linq;
using System.Collections.Generic;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaxyToAir_TestHarness.BusinessModel;
using GalaxyToAir_TestHarness.Services;
using GalaxyToAir_TestHarness.Util;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
/****************************** Module Header ******************************\
Module Name     :   InsuranceSearchViewModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas

View model for Insurance Search screen
\***************************************************************************/
namespace GalaxyToAir_TestHarness.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class InsuranceSearchViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the InsuranceSearchViewModel class.
        /// </summary>
        /// 

        public string _planID;
        public string planID
        {
            get { return _planID; }
            set { _planID = value; RaisePropertyChanged(); }
        }

        public string _productCode;
        public string productCode
        {
            get { return _productCode; }
            set { _productCode = value; RaisePropertyChanged(); }
        }

        public string _tripCost;
        public string tripCost
        {
            get { return _tripCost; }
            set { _tripCost = value; RaisePropertyChanged(); }
        }

        public DateTime _birthDate;
        public DateTime birthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; RaisePropertyChanged(); }
        }

        public string _gender;
        public string gender
        {
            get { return _gender; }
            set { _gender = value; RaisePropertyChanged(); }
        }

        public string _firstName;
        public string firstName
        {
            get { return _firstName; }
            set { _firstName = value; RaisePropertyChanged(); }
        }

        public string _lastName;
        public string lastName
        {
            get { return _lastName; }
            set { _lastName = value; RaisePropertyChanged(); }
        }

        public string _street;
        public string street
        {
            get { return _street; }
            set { _street = value; RaisePropertyChanged(); }
        }

        public string _city;
        public string city
        {
            get { return _city; }
            set { _city = value; RaisePropertyChanged(); }
        }

        public string _zip;
        public string zip
        {
            get { return _zip; }
            set { _zip = value; RaisePropertyChanged(); }
        }

        public string _country;
        public string country
        {
            get { return _country; }
            set { _country = value; RaisePropertyChanged(); }
        }

        public string _state;
        public string state
        {
            get { return _state; }
            set { _state = value; RaisePropertyChanged(); }
        }

        public DateTime _departureDate;
        public DateTime departureDate
        {
            get { return _departureDate; }
            set { _departureDate = value; RaisePropertyChanged(); }
        }

        public DateTime _returnDate;
        public DateTime returnDate
        {
            get { return _returnDate; }
            set { _returnDate = value; RaisePropertyChanged(); }
        }

        public DateTime _initialDepositDate;
        public DateTime initialDepositDate
        {
            get { return _initialDepositDate; }
            set { _initialDepositDate = value; RaisePropertyChanged(); }
        }

        public DateTime _finalPaymentDate;
        public DateTime finalPaymentDate
        {
            get { return _finalPaymentDate; }
            set { _finalPaymentDate = value; RaisePropertyChanged(); }
        }

        public string _destinationCountry;
        public string destinationCountry
        {
            get { return _destinationCountry; }
            set { _destinationCountry = value; RaisePropertyChanged(); }
        }

        public string _destinationState;
        public string destinationState
        {
            get { return _destinationState; }
            set { _destinationState = value; RaisePropertyChanged(); }
        }

        public InsuranceData _insuranceData;
        public InsuranceData insuranceData
        {
            get { return _insuranceData; }
            set { _insuranceData = value; RaisePropertyChanged(); }
        }

        private List<Country> _lstCountry;
        public List<Country> lstCountry
        {
            get { return _lstCountry; }
            set { _lstCountry = value; RaisePropertyChanged(); }
        }

        private string _policyVisible;
        public string policyVisible
        {
            get { return _policyVisible; }
            set { _policyVisible = value; RaisePropertyChanged(); }
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

        private readonly IInsuranceService _insuranceService;

        public InsuranceSearchViewModel(IInsuranceService insuranceService)
        {
            _insuranceService = insuranceService;

            var loc = new ViewModelLocator();

            lstCountry = loc.LandingPage.lstCountry;

            birthDate = DateTime.Now;
            departureDate = DateTime.Now;
            finalPaymentDate = DateTime.Now;
            initialDepositDate = DateTime.Now;
            returnDate = DateTime.Now;
            destinationCountry = "US";
            planID = "242268";
            productCode = "CA8574";
            policyVisible = "Hidden";
            birthDate = DateTime.Now.AddYears(-30);
            tripCost = "500";
            destinationCountry = "US";
            destinationState = "NV";
            FillCustomerInfo();
        }

        public void FillCustomerInfo()
        {
            var loc = new ViewModelLocator();
            var lstCustomer = loc.LandingPage.lstCustomers;

            if(lstCustomer.customerList[0] != null)
            {

                firstName = lstCustomer.customerList[0].firstName;
                lastName = lstCustomer.customerList[0].lastName;
                gender = lstCustomer.customerList[0].gender;
                street = lstCustomer.customerList[0].street;
                city = lstCustomer.customerList[0].city;
                zip = lstCustomer.customerList[0].zip;
                state = lstCustomer.customerList[0].state;
                country = lstCustomer.customerList[0].country;
            }
            
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

                          var request = new InsuranceSearchModel();

                          request.birthDate = birthDate.ToString("yyyy-MM-dd");
                          request.city = city;
                          request.country = country;
                          request.departureDate = departureDate.ToString("yyyy-MM-dd");
                          request.destinationCountry = destinationCountry;
                          request.destinationState = destinationState;
                          request.finalPaymentDate = finalPaymentDate.ToString("yyyy-MM-dd");
                          request.firstName = firstName;
                          request.gender = gender;
                          request.initialDepositDate = initialDepositDate.ToString("yyyy-MM-dd");
                          request.lastName = lastName;
                          request.planID = planID;
                          request.productCode = productCode;
                          request.returnDate = returnDate.ToString("yyyy-MM-dd");
                          request.state = state;
                          request.street = street;
                          request.tripCost = tripCost;
                          request.zip = zip;


                          var response = _insuranceService.GetInsuranceDetails(request);

                          insuranceData = response.insuranceData;

                          var req = response.insuranceSearchRquest;
                          var resp = response.insuranceSearchResponse;

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

                          if(insuranceData != null && insuranceData.planID != null)
                          {
                              policyVisible = "Visible";
                          }
                          else
                          {
                              policyVisible = "Hidden";
                          }

                      }
                      catch (Exception ex)
                      {

                      }
                  }));
            }
        }

        private RelayCommand _selectInsurance;
        public RelayCommand SelectInsurance
        {
            get
            {
                return _selectInsurance ?? (_selectInsurance =
                    new RelayCommand(
                  () =>
                  {
                      UIHelper.SetBusyState();
                      var loc = new ViewModelLocator();
                      loc.OrderDetails.AddOrderToCart();
                      MessengerInstance.Send(PageNavigation.OrderDetails);
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
                      insuranceData = null;
                      var loc = new ViewModelLocator();
                      loc.OrderDetails.AddOrderToCart();
                      MessengerInstance.Send(PageNavigation.OrderDetails);
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
            birthDate = DateTime.Now;
            departureDate = DateTime.Now;
            finalPaymentDate = DateTime.Now;
            initialDepositDate = DateTime.Now;
            returnDate = DateTime.Now;
            country = "US";
            destinationCountry = "US";
            planID = "242268";
            productCode = "CA8574";
            policyVisible = "Hidden";
            tripCost = "";
            gender = "";
            firstName = "";
            lastName = "";
            street = "";
            city = "";
            zip = "";
            state = "";
            destinationState = "";
            insuranceData = null;
            jsonRequest = "";
            jsonResponse = "";
            treeViewRequest = null;
            treeViewResponse = null;
            xmlRequest = null;
            xmlResponse = null;
            tripCost = "500";
            birthDate = DateTime.Now.AddYears(-30);
            destinationCountry = "US";
            destinationState = "NV";

            FillCustomerInfo();
        }
    }
}