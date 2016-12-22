using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/****************************** Module Header ******************************\
Module Name     :   VehicleSearchRequestModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas


Business model for vehicle search request
\***************************************************************************/
namespace GalaxyToAir_TestHarness.BusinessModel
{
    public class VehicleSearchRequestModel
    {
        
        public DateTime pickupDateTime{get; set;}
        public string pickupLocation{get; set;}
        public DateTime returnDateTime{get; set;}
        public string returnLocation{get; set;}
        public string currency{get; set;}
        public string noOfPassengers{get; set;}
        public string country{get; set;}
        public string age { get; set; }
    }
}
