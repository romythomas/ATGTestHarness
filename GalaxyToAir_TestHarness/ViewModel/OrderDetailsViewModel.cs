using System;
using System.Windows;
using System.Xml;
using System.Xml.Linq;
using System.Collections.Generic;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaxyToAir_TestHarness.Services;
using GalaxyToAir_TestHarness.BusinessModel;
using GalaxyToAir_TestHarness.Util;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
/****************************** Module Header ******************************\
Module Name     :   OrderDetailsViewModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas

View model for Order Details screen
\***************************************************************************/
namespace GalaxyToAir_TestHarness.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class OrderDetailsViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the OrderDetailsViewModel class.
        /// </summary>
        /// 
        private OrderData _orderData;
        public OrderData orderData
        {
            get { return _orderData; }
            set { _orderData = value; RaisePropertyChanged(); }
        }

        private List<PaxData> _paxData;
        public List<PaxData> paxData
        {
            get { return _paxData; }
            set { _paxData = value; RaisePropertyChanged(); }
        }

        private List<Country> _lstCountry;
        public List<Country> lstCountry
        {
            get { return _lstCountry; }
            set { _lstCountry = value; RaisePropertyChanged(); }
        }

        private BookingRequestModel _bookingRequestModel;
        public BookingRequestModel bookingRequestModel
        {
            get { return _bookingRequestModel; }
            set { _bookingRequestModel = value; RaisePropertyChanged(); }
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

        private readonly IOrderService _orderService;

        public OrderDetailsViewModel(IOrderService orderService)
        {
            _orderService = orderService;

        }

        public void AddOrderToCart()
        {
            var loc = new ViewModelLocator();

            lstCountry = loc.LandingPage.lstCountry;

            var request = new AddToOrderRequestModel();
            request.offerData = loc.FlightSearch.offerData;
            request.insuranceData = loc.InsuranceSearch.insuranceData;
            request.vehicleData = loc.VehicleSearch.vehicleData;

            var response = _orderService.AddToOrder(request);

            var req = response.addToCartRequest;
            var resp = response.addToCartResponse;
            orderData = response.orderData;

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

            paxData = FillCustomerInfo(request);

            
        }

        private RelayCommand _confirmOrder;
        public RelayCommand confirmOrder
        {
            get
            {
                return _confirmOrder ?? (_confirmOrder =
                    new RelayCommand(
                  () =>
                  {
                      UIHelper.SetBusyState();

                      bookingRequestModel = new BookingRequestModel();
                      bookingRequestModel.orderData = orderData;
                      bookingRequestModel.paxData = paxData;

                      var loc = new ViewModelLocator();
                      loc.BookingDetails.ConfirmBooking();

                      MessengerInstance.Send(PageNavigation.Book);
                  }));
            }
        }

        private RelayCommand _viewFareRule;
        public RelayCommand viewFareRule
        {
            get
            {
                return _viewFareRule ?? (_viewFareRule =
                    new RelayCommand(
                  () =>
                  {
                      UIHelper.SetBusyState();

                      var loc = new ViewModelLocator();
                      loc.FareRules.PopulateAirFareRule();

                      MessengerInstance.Send(PageNavigation.FareRule);
                  }));
            }
        }

        private RelayCommand _viewRentalCondition;
        public RelayCommand viewRentalCondition
        {
            get
            {
                return _viewRentalCondition ?? (_viewRentalCondition =
                    new RelayCommand(
                  () =>
                  {
                      UIHelper.SetBusyState();

                      var loc = new ViewModelLocator();
                      loc.FareRules.PopulateRentalCondition();

                      MessengerInstance.Send(PageNavigation.FareRule);
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
            orderData = null;
            jsonRequest = "";
            jsonResponse = "";
            treeViewRequest = null;
            treeViewResponse = null;
            xmlRequest = null;
            xmlResponse = null;
        }

        public List<PaxData> FillCustomerInfo(AddToOrderRequestModel request)
        {
            var loc = new ViewModelLocator();
            var lstCustomer = loc.LandingPage.lstCustomers;

            int i;
            var paxList = new List<PaxData>();

            if (request.offerData != null)
            { 
                for (i = 0; i < request.offerData.noOfAdult; i++)
                {
                    var pax = new PaxData();
                    pax.customerIndex = "Customer (Adult " + (i + 1).ToString() + ")";
                    if (lstCustomer.customerList[i] != null)
                    {
                        pax.isAdult = true;
                        pax.prefix = lstCustomer.customerList[i].prefix;
                        pax.firstName = lstCustomer.customerList[i].firstName;
                        pax.middleName = lstCustomer.customerList[i].middleName;
                        pax.lastName = lstCustomer.customerList[i].lastName;
                        pax.gender = lstCustomer.customerList[i].gender;
                        pax.street = lstCustomer.customerList[i].street;
                        pax.dateOfBirth = DateTime.Now.AddYears(-30);
                        pax.apartment = lstCustomer.customerList[i].apartment;
                        pax.city = lstCustomer.customerList[i].city;
                        pax.zip = lstCustomer.customerList[i].zip;
                        pax.state = lstCustomer.customerList[i].state;
                        pax.country = lstCustomer.customerList[i].country;
                        pax.email = lstCustomer.customerList[i].email;
                        pax.countryCode = lstCustomer.customerList[i].countrycode;
                        pax.phoneNo = lstCustomer.customerList[i].phoneno;
                    }
                    paxList.Add(pax);
                }
                for (int j = 0; j < request.offerData.noOfChild; j++)
                {
                    var pax = new PaxData();
                    pax.customerIndex = "Customer (Child " + (j + 1).ToString() + ")";

                    if (i < lstCustomer.customerList.Length)
                    {
                        pax.isAdult = false;
                        pax.prefix = lstCustomer.customerList[i].prefix;
                        pax.firstName = lstCustomer.customerList[i].firstName;
                        pax.middleName = lstCustomer.customerList[i].middleName;
                        pax.lastName = lstCustomer.customerList[i].lastName;
                        pax.gender = lstCustomer.customerList[i].gender;
                        pax.dateOfBirth = DateTime.Now.AddYears(-2);
                        pax.street = lstCustomer.customerList[i].street;
                        pax.apartment = lstCustomer.customerList[i].apartment;
                        pax.city = lstCustomer.customerList[i].city;
                        pax.zip = lstCustomer.customerList[i].zip;
                        pax.state = lstCustomer.customerList[i].state;
                        pax.country = lstCustomer.customerList[i].country;
                        pax.email = lstCustomer.customerList[i].email;
                        pax.countryCode = lstCustomer.customerList[i].countrycode;
                        pax.phoneNo = lstCustomer.customerList[i].phoneno;
                        i++;
                    }
                    paxList.Add(pax);
                }
            }
            else
            {
                var pax = new PaxData();
                pax.customerIndex = "Customer 1";
                if (lstCustomer.customerList[0] != null)
                {
                    pax.isAdult = true;
                    pax.prefix = lstCustomer.customerList[0].prefix;
                    pax.firstName = lstCustomer.customerList[0].firstName;
                    pax.middleName = lstCustomer.customerList[0].middleName;
                    pax.lastName = lstCustomer.customerList[0].lastName;
                    pax.gender = lstCustomer.customerList[0].gender;
                    pax.street = lstCustomer.customerList[0].street;
                    pax.dateOfBirth = DateTime.Now.AddYears(-30);
                    pax.apartment = lstCustomer.customerList[0].apartment;
                    pax.city = lstCustomer.customerList[0].city;
                    pax.zip = lstCustomer.customerList[0].zip;
                    pax.state = lstCustomer.customerList[0].state;
                    pax.country = lstCustomer.customerList[0].country;
                    pax.email = lstCustomer.customerList[0].email;
                    pax.countryCode = lstCustomer.customerList[0].countrycode;
                    pax.phoneNo = lstCustomer.customerList[0].phoneno;
                }
                paxList.Add(pax);
            }

            return paxList;
        }
    }
}