using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaxyToAir_TestHarness.Model;
/****************************** Module Header ******************************\
Module Name     :   VehicleSearchResponseModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas


Business model for vehicle search response
\***************************************************************************/
namespace GalaxyToAir_TestHarness.BusinessModel
{
    public class VehicleSearchResponseModel
    {
        public string vehicleSearchRquest;
        public string vehicleSearchResponse;
        public List<VehicleData> vehicleData;
    }

    public class VehicleData
    {
        public DateTime pickupDatetime{get; set;}
        public string pickupCodeContext { get; set; }
        public DateTime returnDatetime { get; set; }
        public int pickupLocation { get; set; }
        public int returnLocation { get; set; }
        public string returnCodeContext { get; set; }
        public int vendorCode { get; set; }
        public string vendorName { get; set; }
        public string driverAge { get; set; }
        public string driverQty { get; set; }
        public string passengerQty { get; set; }
        public DateTime vehAvailDateTime { get; set; }
        public int Id { get; set; }
        public string id_Context { get; set; }
        public int type { get; set; }
        public string url { get; set; }
        public string rateQualifier { get; set; }
        public string currencyCode { get; set; }
        public string estimatedTotalAmount { get; set; }
        public string rateTotalAmount { get; set; }
        public bool airConditionAvailable { get; set; }
        public string vehCode { get; set; }
        public string codeContext { get; set; }
        public string driveType { get; set; }
        public string fuelType { get; set; }
        public string transmissionType { get; set; }
        public int size { get; set; }
        public string makeModelCode { get; set; }
        public string makeModelName { get; set; }
        public int vehCategory { get; set; }
        public string Amount { get; set; }
        public string purpose { get; set; }
        public int doorCount { get; set; }
        public string country { get; set; }
    }
}
