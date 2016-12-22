/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocatorTemplate xmlns:vm="clr-namespace:GalaxyToAir_TestHarness.ViewModel"
                                   x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using GalaxyToAir_TestHarness.Model;
using GalaxyToAir_TestHarness.Services;
/****************************** Module Header ******************************\
Module Name     :   ViewModelLocator.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas

View model locator for MVVM.Also act as a dependency injection contianer for services
\***************************************************************************/
namespace GalaxyToAir_TestHarness.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            if (ViewModelBase.IsInDesignModeStatic)
            {
            }
            else
            {
                SimpleIoc.Default.Register<IFlightService, FlightService>();
                SimpleIoc.Default.Register<IVehicleService, VehicleService>();
                SimpleIoc.Default.Register<IInsuranceService, InsuranceService>();
                SimpleIoc.Default.Register<IOrderService, OrderService>();
                SimpleIoc.Default.Register<IMasterService, MasterService>();
                SimpleIoc.Default.Register<IBookingService, BookingService>();
            }

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<NavigationViewModel>();
            SimpleIoc.Default.Register<LandingPageViewModel>();
            SimpleIoc.Default.Register<FlightSearchViewModel>();
            SimpleIoc.Default.Register<VehicleSearchViewModel>();
            SimpleIoc.Default.Register<InsuranceSearchViewModel>();
            SimpleIoc.Default.Register<OrderDetailsViewModel>();
            SimpleIoc.Default.Register<BookingDetailsViewModel>();
            SimpleIoc.Default.Register<FareRulesViewModel>();
        }

        /// <summary>
        /// Gets the Main property.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public NavigationViewModel Navigation
        {
            get
            {
                return ServiceLocator.Current.GetInstance<NavigationViewModel>();
            }
        }

        public LandingPageViewModel LandingPage
        {
            get
            {
                return ServiceLocator.Current.GetInstance<LandingPageViewModel>();
            }
        }

        public FlightSearchViewModel FlightSearch
        {
            get
            {
                return ServiceLocator.Current.GetInstance<FlightSearchViewModel>();
            }
        }

        public VehicleSearchViewModel VehicleSearch
        {
            get
            {
                return ServiceLocator.Current.GetInstance<VehicleSearchViewModel>();
            }
        }

        public InsuranceSearchViewModel InsuranceSearch
        {
            get
            {
                return ServiceLocator.Current.GetInstance<InsuranceSearchViewModel>();
            }
        }

        public OrderDetailsViewModel OrderDetails
        {
            get
            {
                return ServiceLocator.Current.GetInstance<OrderDetailsViewModel>();
            }
        }

        public BookingDetailsViewModel BookingDetails
        {
            get
            {
                return ServiceLocator.Current.GetInstance<BookingDetailsViewModel>();
            }
        }

        public FareRulesViewModel FareRules
        {
            get
            {
                return ServiceLocator.Current.GetInstance<FareRulesViewModel>();
            }
        }

        /// <summary>
        /// Cleans up all the resources.
        /// </summary>
        public static void Cleanup()
        {
        }
    }
}