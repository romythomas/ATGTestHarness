using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
/****************************** Module Header ******************************\
Module Name     :   AirFareRuleRequest.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas


JSON class for fare rule request
\***************************************************************************/
namespace GalaxyToAir_TestHarness.Model.AirFareRuleRequest
{
    public class AirFareRuleRequest
    {
        [JsonProperty("f.airFareRulesRequest")]
        public FAirfarerulesrequest fairFareRulesRequest { get; set; }
    }

    public class FAirfarerulesrequest
    {
        public Farerule[] fareRules { get; set; }
    }

    public class Farerule
    {
        public string fareInfoRef { get; set; }
        public string fareRuleKey { get; set; }
    }


}
