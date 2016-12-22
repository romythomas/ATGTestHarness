using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
/****************************** Module Header ******************************\
Module Name     :   OrderDetailsResponseModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas


JSON class for order details response
\***************************************************************************/
namespace GalaxyToAir_TestHarness.Model.OrderDetailsResponse
{
 
    public class OrderDetailsResponseModel
    {
        [JsonProperty("o.OrderVO")]
        public OOrdervo oOrderVO { get; set; }
    }

    public class OOrdervo
    {

        public string transactionID { get; set; }
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
        [JsonProperty("o.vehicleQuoteResponseInfo")]
        public OVehiclequoteresponseinfo ovehicleQuoteResponseInfo { get; set; }
    }

    public class OVehiclequoterequestinfo
    {
        public DateTime pickUpDateTime { get; set; }
        public DateTime returnDateTime { get; set; }
        public Pickuplocation pickUpLocation { get; set; }
        public Returnlocation returnLocation { get; set; }
        public Drivertype driverType { get; set; }
        public int passengerQty { get; set; }
        public Reference reference { get; set; }
        public string rateQualifier { get; set; }
        public Totalcharge totalCharge { get; set; }
        public Vehpref vehPref { get; set; }
        public Fees fees { get; set; }
        public int luggageQty { get; set; }
        public Remark remark { get; set; }
        public int vehicleMainId { get; set; }
    }

    public class Pickuplocation
    {
        public string codeContext { get; set; }
        public int locationCode { get; set; }
    }

    public class Returnlocation
    {
        public string codeContext { get; set; }
        public int locationCode { get; set; }
    }

    public class Drivertype
    {
        public int age { get; set; }
        public int quantity { get; set; }
    }

    public class Reference
    {
        public DateTime dateTime { get; set; }
        public int id { get; set; }
        public string id_Context { get; set; }
        public int type { get; set; }
        public string url { get; set; }
    }

    public class Totalcharge
    {
        public string currencyCode { get; set; }
        public float estimatedTotalAmount { get; set; }
        public float rateTotalAmount { get; set; }
    }

    public class Vehpref
    {
        public bool airConditionInd { get; set; }
        public string code { get; set; }
        public string codeContext { get; set; }
        public string driveType { get; set; }
        public string fuelType { get; set; }
        public string transmissionType { get; set; }
        public Vehclass vehClass { get; set; }
        public Vehmakemodel vehMakeModel { get; set; }
        public Vehtype vehType { get; set; }
    }

    public class Vehclass
    {
        public int size { get; set; }
    }

    public class Vehmakemodel
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Vehtype
    {
        public int doorCount { get; set; }
        public int vehicleCategory { get; set; }
    }

    public class Fees
    {
        public Fee fee { get; set; }
    }

    public class Fee
    {
        public int amount { get; set; }
        public string currencyCode { get; set; }
        public int purpose { get; set; }
    }

    public class Remark
    {
        public string text { get; set; }
    }

    public class OVehiclequoteresponseinfo
    {
        public Vehresrscore vehResRSCore { get; set; }
    }

    public class Vehresrscore
    {
        public Vehreservation vehReservation { get; set; }
    }

    public class Vehreservation
    {
        public Vehsegmentinfo vehSegmentInfo { get; set; }
    }

    public class Vehsegmentinfo
    {
        public string paymentRules { get; set; }
    }

    public class OAirquotes
    {
        [JsonProperty("o.id")]
        public int oid { get; set; }
        [JsonProperty("o.pricingCurrency")]
        public string opricingCurrency { get; set; }
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
        public OFlightsegmentvos oflightSegmentVOs { get; set; }
        [JsonProperty("o.owner")]
        public string oowner { get; set; }
        [JsonProperty("o.totalPrice")]
        public float ototalPrice { get; set; }
    }

    public class OFlightsegmentvos
    {
        [JsonProperty("o.segKey")]
        public string osegKey { get; set; }
        [JsonProperty("o.depAirportCode")]
        public string odepAirportCode { get; set; }
        [JsonProperty("o.depDate")]
        public string odepDate { get; set; }
        [JsonProperty("o.depTime")]
        public string odepTime { get; set; }
        [JsonProperty("o.arrivalAirportCode")]
        public string oarrivalAirportCode { get; set; }
        [JsonProperty("o.arrivalDate")]
        public string oarrivalDate { get; set; }
        [JsonProperty("o.arrivalTime")]
        public string oarrivalTime { get; set; }
        [JsonProperty("o.marketingAirLineID")]
        public string omarketingAirLineID { get; set; }
        [JsonProperty("oid")]
        public int omarketingFlightNo { get; set; }
        [JsonProperty("o.operatingAirLineID")]
        public string ooperatingAirLineID { get; set; }
        [JsonProperty("o.operatingFlightNo")]
        public int ooperatingFlightNo { get; set; }
        [JsonProperty("o.classCode")]
        public string oclassCode { get; set; }
        [JsonProperty("o.classMarketingName")]
        public string oclassMarketingName { get; set; }
    }

    public class OInsurancequotes
    {
        [JsonProperty("o.id")]
        public int oid { get; set; }
        [JsonProperty("o.status")]
        public string ostatus { get; set; }
        [JsonProperty("o.insuranceBookingRequestVO")]
        public OInsurancebookingrequestvo oinsuranceBookingRequestVO { get; set; }
    }

    public class OInsurancebookingrequestvo
    {
        public Policyspecification policySpecification { get; set; }
        public int insuranceMainId { get; set; }
    }

    public class Policyspecification
    {
        public Policy policy { get; set; }
    }

    public class Policy
    {
        public Product product { get; set; }
        public Trip trip { get; set; }
        public Payment payment { get; set; }
        public Fulfillment fulfillment { get; set; }
        public Agency agency { get; set; }
        public string premium { get; set; }
    }

    public class Product
    {
        public string purchaseDate { get; set; }
        public int planID { get; set; }
        public string productCode { get; set; }
        public string transactionType { get; set; }
        public string submissionType { get; set; }
    }

    public class Trip
    {
        public string departureDate { get; set; }
        public string returnDate { get; set; }
        public string initialTripDepositDate { get; set; }
        public string finalPaymentDate { get; set; }
        public Destination destination { get; set; }
    }

    public class Destination
    {
        public string country { get; set; }
        public string city { get; set; }
    }

    public class Payment
    {
        public string paymentType { get; set; }
        public int totalPremiumAmount { get; set; }
    }

    public class Fulfillment
    {
        public string fulfillmentType { get; set; }
    }

    public class Agency
    {
        public int ARC { get; set; }
        public int agencyPhone { get; set; }
        public string email { get; set; }
        public string agencyInitials { get; set; }
    }

}
