using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
/****************************** Module Header ******************************\
Module Name     :   FlightSearchRequestModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas


JSON class for flight search request
\***************************************************************************/
namespace GalaxyToAir_TestHarness.Model.FlightSearchRequest
{

        public class FlightSearchRequestModel
        {
            [JsonProperty("a.AirSearchRequest")]
            public AAirsearchrequest aAirSearchRequest { get; set; }
        }

        public class AAirsearchrequest
        {
            public Travelrequestvo travelRequestVO { get; set; }
            public Passengercountvo passengerCountVO { get; set; }
            public Currcodes currCodes { get; set; }
            public Preferences preferences { get; set; }
            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
            public Qualifiers qualifiers { get; set; }
        }

        public class Travelrequestvo
        {
            public string from { get; set; }
            public string to { get; set; }
            public string departure { get; set; }
            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
            public string returnValue { get; set; }
        }

        public class Passengercountvo
        {
            [JsonProperty("o.adultCount")]
            public string oadultCount { get; set; }
            [JsonProperty("o.childCount")]
            public string ochildCount { get; set; }
            [JsonProperty("o.infantCount")]
            public string oinfantCount { get; set; }
        }

        public class Currcodes
        {
            public string value { get; set; }
        }

        public class Preferences
        {
            public Cabinpreference[] cabinPreferences { get; set; }
        }

        public class Cabinpreference
        {
            public string code { get; set; }
            public string objectKey { get; set; }
        }

        public class Qualifiers
        {
            public Qualifier[] qualifier { get; set; }
        }

        public class Qualifier
        {
            public Account account { get; set; }
        }

        public class Account
        {
            public string accountCode { get; set; }
        }
}
