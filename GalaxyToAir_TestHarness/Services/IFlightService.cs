using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaxyToAir_TestHarness.Model;
using GalaxyToAir_TestHarness.BusinessModel;
/****************************** Module Header ******************************\
Module Name     :   IFlightService.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas

Interface for Flight Service
\***************************************************************************/
namespace GalaxyToAir_TestHarness.Services
{
    public interface IFlightService
    {
        FlightSearchResponseModel GetFlightDetails(FlightSearchRequestModel request);
        AirFareRuleResponseModel GetFareRules(AirFareRuleRequestModel request);
        PostBookingFareRuleResponseModel GetPostBookingFareRules(PostBookingFareRuleRequestModel request);
    }
}
