using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using GalaxyToAir_TestHarness.Util;
/****************************** Module Header ******************************\
Module Name     :   PostBookingFareRuleResponseModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas


JSON class for post booking fare rule response
\***************************************************************************/
namespace GalaxyToAir_TestHarness.Model.PostBookingFareRuleResponse
{
    
    public class PostBookingFareRuleResponseModel
    {
        [JsonProperty("o.OrderVO")]
        public OOrdervo oOrderVO { get; set; }
    }

    public class OOrdervo
    {
        public string transactionID { get; set; }
        public string otransactionStatus { get; set; }
        [JsonProperty("o.airQuotes")]
        public OAirquotes oairQuotes { get; set; }
    }

    public class OAirquotes
    {
        [JsonProperty("o.id")]
        public int oid { get; set; }
        [JsonProperty("o.airFareRulesResponse")]
        public OAirfarerulesresponse oairFareRulesResponse { get; set; }
    }

    public class OAirfarerulesresponse
    {
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
