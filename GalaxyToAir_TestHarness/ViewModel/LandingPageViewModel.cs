using System;
using System.Configuration;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaxyToAir_TestHarness.Model;
using GalaxyToAir_TestHarness.Util;
using System.Collections.Generic;
using GalaxyToAir_TestHarness.BusinessModel;
using GalaxyToAir_TestHarness.Services;
/****************************** Module Header ******************************\
Module Name     :   LandingPageViewModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas

View model for Landing Page/Configuration screen
\***************************************************************************/
namespace GalaxyToAir_TestHarness.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class LandingPageViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the LandingPageViewModel class.
        /// </summary>
        /// 
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

        private Suppliers _lstSuppliers;
        public Suppliers lstSuppliers
        {
            get { return _lstSuppliers; }
            set { _lstSuppliers = value; RaisePropertyChanged(); }
        }

        private Customers _lstCustomers;
        public Customers lstCustomers
        {
            get { return _lstCustomers; }
            set { _lstCustomers = value; RaisePropertyChanged(); }
        }

        private string _baseUrl;
        public string baseUrl
        {
            get { return _baseUrl; }
            set { _baseUrl = value; RaisePropertyChanged(); }
        }

        private string _userId;
        public string userId
        {
            get { return _userId; }
            set { _userId = value; RaisePropertyChanged(); }
        }

        private string _password;
        public string password
        {
            get { return _password; }
            set { _password = value; RaisePropertyChanged(); }
        }

        private string _target;
        public string target
        {
            get { return _target; }
            set { _target = value; RaisePropertyChanged(); }
        }

        private RelayCommand<PageNavigation> _cmdMenuRedirect;
        public RelayCommand<PageNavigation> cmdMenuRedirect
        {
            get
            {
                return _cmdMenuRedirect ?? (_cmdMenuRedirect =
                    new RelayCommand<PageNavigation>(
                  item =>
                  {
                      MessengerInstance.Send(item);
                  }));
            }
        }

        public PageNavigation _flightSearchMenu = PageNavigation.FlightSearch;
        public PageNavigation flightSearchMenu
        {

            get
            {
                return _flightSearchMenu;
            }
            set
            {
                _flightSearchMenu = value;
            }
        }

        public PageNavigation _retrieveMenu = PageNavigation.InsuranceSearch;
        public PageNavigation retrieveMenu
        {

            get
            {
                return _retrieveMenu;
            }
            set
            {
                _retrieveMenu = value;
            }
        }

        public PageNavigation _vehicleSearchMenu = PageNavigation.VehicleSearch;
        public PageNavigation vehicleSearchMenu
        {

            get
            {
                return _vehicleSearchMenu;
            }
            set
            {
                _vehicleSearchMenu = value;
            }
        }

        public PageNavigation _insuranceSearchMenu = PageNavigation.InsuranceSearch;
        public PageNavigation insuranceSearchMenu
        {

            get
            {
                return _insuranceSearchMenu;
            }
            set
            {
                _insuranceSearchMenu = value;
            }
        }

        public PageNavigation _orderDetailsMenu = PageNavigation.OrderDetails;
        public PageNavigation orderDetailsMenu
        {

            get
            {
                return _orderDetailsMenu;
            }
            set
            {
                _orderDetailsMenu = value;
            }
        }

        private readonly IMasterService _masterService;
        public LandingPageViewModel(IMasterService masterService)
        {
            _masterService = masterService;
            lstAirport = _masterService.GetAirport();
            lstCurrency = _masterService.GetCurrency();
            lstCountry = _masterService.GetCountry();
            lstSuppliers = _masterService.GetSuppliers();
            lstCustomers = _masterService.GetCustomers();

            baseUrl = ConfigurationManager.AppSettings["ServiceBaseUrl"];
            userId = ConfigurationManager.AppSettings["UserName"];
            password = ConfigurationManager.AppSettings["Password"];
            target = ConfigurationManager.AppSettings["target"];

        }

        private RelayCommand _updateClick;
        public RelayCommand UpdateClick
        {
            get
            {
                return _updateClick ?? (_updateClick =
                    new RelayCommand(
                  () =>
                  {
                      Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                      config.AppSettings.Settings["ServiceBaseUrl"].Value = baseUrl;
                      config.AppSettings.Settings["UserName"].Value = userId;
                      config.AppSettings.Settings["Password"].Value = password;
                      ConfigurationManager.AppSettings["target"] = target;

                      config.Save(ConfigurationSaveMode.Modified);
                  }));
            }
        }
    }
}