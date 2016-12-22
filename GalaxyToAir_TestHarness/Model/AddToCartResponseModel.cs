using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using GalaxyToAir_TestHarness.Util;
/****************************** Module Header ******************************\
Module Name     :   AddToCartResponseModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas


JSON class for add to cart response
\***************************************************************************/
namespace GalaxyToAir_TestHarness.Model.AddToCartResponse
{
 
    public class AddToCartResponseModel
    {
        [JsonProperty("o.OrderVO")]
        public OOrdervo oOrderVO { get; set; }
    }

    public class OOrdervo
    {
        [JsonProperty("o.id")]
        public int oid { get; set; }
        [JsonProperty("o.externalOrderId")]
        public int oexternalOrderId { get; set; }
        [JsonProperty("o.externalOrderHash")]
        public int oexternalOrderHash { get; set; }
        [JsonProperty("o.transactionStatus")]
        public string otransactionStatus { get; set; }
        [JsonProperty("o.vehicleQuotes")]
        public OVehiclequotes ovehicleQuotes { get; set; }
        [JsonProperty("o.airQuotes")]
        public OAirquotes oairQuotes { get; set; }
        [JsonProperty("o.insuranceQuotes")]
        public OInsurancequotes oinsuranceQuotes { get; set; }
    }

    public class OVehiclequotes
    {
        [JsonProperty("o.id")]
        public int oid { get; set; }
        [JsonProperty("o.pricingCurrency")]
        public string opricingCurrency { get; set; }
        [JsonProperty("o.status")]
        public string ostatus { get; set; }
        [JsonProperty("o.totalPrice")]
        public float ototalPrice { get; set; }
        [JsonProperty("o.vehicleQuoteRequestInfo")]
        public OVehiclequoterequestinfo ovehicleQuoteRequestInfo { get; set; }
    }

    public class OVehiclequoterequestinfo
    {
        public Reference reference { get; set; }
    }

    public class Reference
    {
        public DateTime dateTime { get; set; }
        public int id { get; set; }
        public string id_Context { get; set; }
        public int type { get; set; }
        public string url { get; set; }
    }

    public class OAirquotes
    {
        [JsonProperty("o.id")]
        public int oid { get; set; }
        [JsonProperty("o.status")]
        public string ostatus { get; set; }
        [JsonProperty("o.totalPrice")]
        public float ototalPrice { get; set; }
        [JsonProperty("o.airMainId")]
        public int oairMainId { get; set; }
        [JsonProperty("o.airQuoteRQVO")]
        public OAirquoterqvo oairQuoteRQVO { get; set; }
    }

    public class OAirquoterqvo
    {
        [JsonProperty("o.flightSegmentVOs")]
        [JsonConverter(typeof(SingleOrArrayConverter<OFlightsegmentvos>))]
        public OFlightsegmentvos[] oflightSegmentVOs { get; set; }
    }

    public class OFlightsegmentvos
    {
        [JsonProperty("o.segKey")]
        public string osegKey { get; set; }
    }

    public class OInsurancequotes
    {
        [JsonProperty("o.id")]
        public int oid { get; set; }
        [JsonProperty("o.status")]
        public string ostatus { get; set; }
        [JsonProperty("o.totalPrice")]
        public int ototalPrice { get; set; }
        [JsonProperty("o.insuranceBookingRequestVO")]
        public OInsurancebookingrequestvo oinsuranceBookingRequestVO { get; set; }
    }

    public class OInsurancebookingrequestvo
    {
        public Policyspecification policySpecification { get; set; }
    }

    public class Policyspecification
    {
        public Policy policy { get; set; }
    }

    public class Policy
    {
        public Product product { get; set; }
    }

    public class Product
    {
        public int planID { get; set; }
        public string productCode { get; set; }
    }

}
