using GalaxyToAir_TestHarness.Model;
using GalaxyToAir_TestHarness.Util;
using GalaxyToAir_TestHarness.BusinessModel;
using GalaxyToAir_TestHarness.Services;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Collections.Generic;
/****************************** Module Header ******************************\
Module Name     :   MainViewModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas

View model for Main window
\***************************************************************************/
namespace GalaxyToAir_TestHarness.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {

        /// <summary>
        /// The <see cref="WelcomeTitle" /> property's name.
        /// </summary>
        public const string WelcomeTitlePropertyName = "WelcomeTitle";

        private string _title = string.Empty;

        /// <summary>
        /// Gets the WelcomeTitle property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string title
        {
            get
            {
                return _title;
            }
            set
            {
                Set(ref _title, value);
            }
        }

       

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        /// 
        

        public MainViewModel()
        {
            title = "Air To Galaxy Test Harness (" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString() + ")";
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
                      var loc = new ViewModelLocator();

                      loc.FlightSearch.ClearFields();
                      loc.VehicleSearch.ClearFields();
                      loc.InsuranceSearch.ClearFields();
                      loc.OrderDetails.ClearFields();
                      loc.BookingDetails.ClearFields();

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

        public PageNavigation _landingPageMenu = PageNavigation.Landing;
        public PageNavigation landingPageMenu
        {

            get
            {
                return _landingPageMenu;
            }
            set
            {
                _landingPageMenu = value;
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

        //public PageNavigation _retrieveMenu = PageNavigation.InsuranceSearch;
        //public PageNavigation retrieveMenu
        //{

        //    get
        //    {
        //        return _retrieveMenu;
        //    }
        //    set
        //    {
        //        _retrieveMenu = value;
        //    }
        //}
        ////public override void Cleanup()
        ////{
        ////    // Clean up if needed

        ////    base.Cleanup();
        ////}
    }
}