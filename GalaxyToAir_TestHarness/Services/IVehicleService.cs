using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaxyToAir_TestHarness.BusinessModel;
/****************************** Module Header ******************************\
Module Name     :   IVehicleService.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas

Interface for Vehicle Service
\***************************************************************************/
namespace GalaxyToAir_TestHarness.Services
{
    public interface IVehicleService
    {
        VehicleSearchResponseModel GetVehicleDetails(VehicleSearchRequestModel request);
        VehicleRentalConditionResponseModel GetRentalCondition(VehicleRentalConditionRequestModel request);
    }
}
