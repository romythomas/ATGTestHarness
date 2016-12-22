using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaxyToAir_TestHarness.Util;
using Newtonsoft.Json;
/****************************** Module Header ******************************\
Module Name     :   AirFareRuleResponseModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas


JSON class for fare rule response
\***************************************************************************/
namespace GalaxyToAir_TestHarness.Model.AirFareRuleResponse
{
    
    public class AirFareRuleResponseModel
    {
        [JsonProperty("ns10.AirFareRulesResponse")]
        public Ns10Airfarerulesresponse ns10AirFareRulesResponse { get; set; }
    }

    public class Ns10Airfarerulesresponse
    {
        public string transactionID { get; set; }
        public string transactionStatus { get; set; }
        [JsonConverter(typeof(SingleOrArrayConverter<Farerule>))]
        public Farerule[] fareRules { get; set; }
        public Rulemetadatas ruleMetadatas { get; set; }
    }

    public class Rulemetadatas
    {
        [JsonConverter(typeof(SingleOrArrayConverter<Rulemetadata>))]
        public Rulemetadata[] ruleMetadata { get; set; }
    }

    public class Rulemetadata
    {
        public string metadataKey { get; set; }
        public Augmentationpoint augmentationPoint { get; set; }
    }

    public class Augmentationpoint
    {
        public Augpoint augPoint { get; set; }
        public Lists lists { get; set; }
    }

    public class Augpoint
    {
        public string key { get; set; }
    }

    public class Lists
    {
        public List list { get; set; }
    }

    public class List
    {
        public string listKey { get; set; }
        public string augPointAssociationKeyRef { get; set; }
    }

    public class Farerule
    {
        public string fareRuleCategoryRef { get; set; }
        public int code { get; set; }
        public string description { get; set; }
    }
}
