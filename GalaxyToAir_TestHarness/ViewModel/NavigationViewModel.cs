using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaxyToAir_TestHarness.Util;
using GalaxyToAir_TestHarness.View;
using System.Windows.Controls;
/****************************** Module Header ******************************\
Module Name     :   NavigationViewModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas

Navigation view model controls the navigation across screens
\***************************************************************************/
namespace GalaxyToAir_TestHarness.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class NavigationViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the NavigationViewModel class.
        /// </summary>
        /// 

        private UserControl _currentPage;
        public UserControl CurrentPage { get { return _currentPage; } set { _currentPage = value; RaisePropertyChanged(); } }

        private UserControl _currentUserPage;
        public UserControl CurrentUserPage { get { return _currentUserPage; } set { _currentUserPage = value; RaisePropertyChanged(); } }

        public bool ErrorPageIsSet { get; set; }

        public NavigationViewModel()
        {
            CurrentUserPage = null;
            MessengerInstance.Register<PageNavigation>(this, OnPageNavigationByEnum);
        }

        private void OnPageNavigationByEnum(PageNavigation page)
        {
            CurrentPage = null;

            switch (page)
            {
                case PageNavigation.None:
                    // DO NOTHING..
                    break;
                case PageNavigation.Landing:
                    OnPageNavigation(new LandingPageView());
                    break;
                case PageNavigation.FlightSearch:
                    OnPageNavigation(new FlightSearchView());
                    break;
                case PageNavigation.VehicleSearch:
                    OnPageNavigation(new VehicleSearchView());
                    break;
                case PageNavigation.InsuranceSearch:
                    OnPageNavigation(new InsuranceSearchView());
                    break;
                case PageNavigation.OrderDetails:
                    OnPageNavigation(new OrderDetailsView());
                    break;
                case PageNavigation.Book:
                    OnPageNavigation(new BookingDetailsView());
                    break;
                case PageNavigation.FareRule:
                    OnPageNavigation(new FareRulesView());
                    break;
            }
        }

        private void OnPageNavigation(UserControl control)
        {
            CurrentPage = control;
        }
    }
}