using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
/****************************** Module Header ******************************\
Module Name     :   GetAirportResponseModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas


JSON class for airport list
\***************************************************************************/
namespace GalaxyToAir_TestHarness.Model.GetAirport
{
   
    public class GetAirportResponseModel
    {
        [JsonProperty("ns9.MasterRS")]
        public Ns9Masterrs ns9MasterRS { get; set; }
    }

    public class Ns9Masterrs
    {
        public string transactionStatus { get; set; }
        [JsonProperty("ns9.airportList")]
        public Ns9Airportlist[] ns9airportList { get; set; }
    }

    public class Ns9Airportlist
    {
        [JsonProperty("ns9.code")]
        public string ns9code { get; set; }
        [JsonProperty("ns9.name")]
        public string ns9name { get; set; }
        [JsonProperty("ns9.cityCode")]
        public string ns9cityCode { get; set; }
        [JsonProperty("ns9.countryCode")]
        public string ns9countryCode { get; set; }
        [JsonProperty("ns9.icao")]
        public string ns9icao { get; set; }
    }

}
