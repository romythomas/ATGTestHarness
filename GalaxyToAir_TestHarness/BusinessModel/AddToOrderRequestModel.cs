using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/****************************** Module Header ******************************\
Module Name     :   AddToOrderRequestModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas


Business model for Add to order request
\***************************************************************************/
namespace GalaxyToAir_TestHarness.BusinessModel
{
    public class AddToOrderRequestModel
    {
        //public FlightData flightData { get; set; }
        public OfferData offerData { get; set; }
        public VehicleData vehicleData { get; set; }
        public InsuranceData insuranceData { get; set; }

    }
}
