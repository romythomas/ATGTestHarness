using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaxyToAir_TestHarness.Model;
/****************************** Module Header ******************************\
Module Name     :   BookingResponseModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas


Business model for booking response
\***************************************************************************/
namespace GalaxyToAir_TestHarness.BusinessModel
{
    public class BookingResponseModel
    {
        public string bookingRequest { get; set; }
        public string bookingResponse { get; set; }
        public BookingData bookingData;
    }

    public class BookingData
    {
        public string superPNR { get; set; }
        public string vehicleProviderConfID { get; set; }
        public float vehicleTotalPrice { get; set; }
        public string airProviderConfID { get; set; }
        public string airTotalPrice { get; set; }
        public string insurancePolicyNumber { get; set; }
        public float insurnceTotalPremiumAmount { get; set; }
    }
}
