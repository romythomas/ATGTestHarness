using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
/****************************** Module Header ******************************\
Module Name     :   GetCountryResponseModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas


JSON class for country list
\***************************************************************************/
namespace GalaxyToAir_TestHarness.Model.GetCountry
{

    public class GetCountryResponseModel
    {
        [JsonProperty("ns9.MasterRS")]
        public Ns9Masterrs ns9MasterRS { get; set; }
    }

    public class Ns9Masterrs
    {
        public string transactionStatus { get; set; }
        [JsonProperty("ns9.countryList")]
        public Ns9Countrylist[] ns9countryList { get; set; }
    }

    public class Ns9Countrylist
    {
        [JsonProperty("ns9.code")]
        public string ns9code { get; set; }
        [JsonProperty("ns9.diallingCode")]
        public int ns9diallingCode { get; set; }
        [JsonProperty("ns9.currency")]
        public string ns9currency { get; set; }
        [JsonProperty("ns9.name")]
        public string ns9name { get; set; }
    }
}
