using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/****************************** Module Header ******************************\
Module Name     :   FlightSearchRequestModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas


Business model forflight search request
\***************************************************************************/
namespace GalaxyToAir_TestHarness.BusinessModel
{
    public class FlightSearchRequestModel
    {
        public string fromAirport { get; set; }
        public string toAirport { get; set; }
        public string adults { get; set; }
        public string child { get; set; }
        public string infant { get; set; }
        public Boolean roundTrip { get; set; }
        public string traveldate { get; set; }
        public string returndate { get; set; }
        public string currency { get; set; }
        public string travelclass { get; set; }
        public string account { get; set; }
    }
}
