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
Module Name     :   BookingDetailsViewModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas

This is the view model for booking details screen
\***************************************************************************/
namespace GalaxyToAir_TestHarness.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class BookingDetailsViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the BookingDetailsViewModel class.
        /// </summary>
        /// 

        private BookingRequestModel _bookingRequestModel;
        public BookingRequestModel bookingRequestModel
        {
            get { return _bookingRequestModel; }
            set { _bookingRequestModel = value; RaisePropertyChanged(); }
        }

        private BookingData _bookingData;
        public BookingData bookingData
        {
            get { return _bookingData; }
            set { _bookingData = value; RaisePropertyChanged(); }
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

        private readonly IBookingService _bookingService;

        public BookingDetailsViewModel(IBookingService bookingService)
        {
            _bookingService = bookingService;

        }

        public void ConfirmBooking()
        {
            var loc = new ViewModelLocator();

            bookingRequestModel = loc.OrderDetails.bookingRequestModel;

            if (bookingRequestModel != null)
            {
                var response = _bookingService.BookOrder(bookingRequestModel);

                if(response != null)
                {

                    var req = response.bookingRequest;
                    var resp = response.bookingResponse;
                    bookingData = response.bookingData;

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
                      loc.FareRules.PopulatePostBookingAirFareRule();

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
            bookingRequestModel = null;
            bookingData = null;
            jsonRequest = "";
            jsonResponse = "";
            treeViewRequest = null;
            treeViewResponse = null;
            xmlRequest = null;
            xmlResponse = null;
        }
    }
}