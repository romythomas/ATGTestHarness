using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
/****************************** Module Header ******************************\
Module Name     :   PostBookingFareRuleRequestModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas


JSON class for post booking fare rule request
\***************************************************************************/
namespace GalaxyToAir_TestHarness.Model.PostBookingFareRuleRequest
{
   
    public class PostBookingFareRuleRequestModel
    {
        [JsonProperty("o.OrderVO")]
        public OOrdervo oOrderVO { get; set; }
    }

    public class OOrdervo
    {
        [JsonProperty("o.airQuotes")]
        public OAirquotes oairQuotes { get; set; }
    }

    public class OAirquotes
    {
        [JsonProperty("o.id")]
        public string oid { get; set; }
    }

}
