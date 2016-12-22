using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/****************************** Module Header ******************************\
Module Name     :   VehicleRentalConditionRequestModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas


Business model for rental condition request
\***************************************************************************/
namespace GalaxyToAir_TestHarness.BusinessModel
{
    public class VehicleRentalConditionRequestModel
    {
        public string isoCurrency { get; set; }
        public string pickupCodeContext { get; set; }
        public string pickupLocationCode { get; set; }
        public string pickupLocationName { get; set; }
        public string  returnCodeContext { get; set; }
        public string returnLocationCode { get; set; }
        public string returnLocationName { get; set; }
        public DateTime pickupDateTime { get; set; }
        public DateTime returnDateTime { get; set; }
        public string countryCode { get; set; }
        public string vehType { get; set; }
        public string vehID { get; set; }
        public string idContext { get; set; }
        public DateTime dateTime { get; set; }
        public string url { get; set; }
    }
}
