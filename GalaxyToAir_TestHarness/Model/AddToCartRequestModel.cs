using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
/****************************** Module Header ******************************\
Module Name     :   AddToCartRequestModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas


JSON class for add to cart request
\***************************************************************************/
namespace GalaxyToAir_TestHarness.Model.AddToCartRequest
{

    public class AddToCartRequestModel
    {
        [JsonProperty("o.OrderVO")]
        public OOrdervo oOrderVO { get; set; }
    }

    public class OOrdervo
    {
        [JsonProperty("o.externalOrderId")]
        public string oexternalOrderId { get; set; }
        [JsonProperty("o.externalOrderHash")]
        public string oexternalOrderHash { get; set; }
        [JsonProperty("o.vehicleQuotes", NullValueHandling = NullValueHandling.Ignore)]
        public OVehiclequotes[] ovehicleQuotes { get; set; }
        [JsonProperty("o.airQuotes", NullValueHandling = NullValueHandling.Ignore)]
        public OAirquotes oairQuotes { get; set; }
        [JsonProperty("o.insuranceQuotes", NullValueHandling = NullValueHandling.Ignore)]
        public OInsurancequotes oinsuranceQuotes { get; set; }
    }

    public class OAirquotes
    {
        [JsonProperty("o.airQuoteRQVO")]
        public OAirquoterqvo oairQuoteRQVO { get; set; }
    }

    public class OAirquoterqvo
    {
        [JsonProperty("o.totalPrice")]
        public string ototalPrice { get; set; }
        [JsonProperty("o.owner")]
        public string oowner { get; set; }
        [JsonProperty("o.requesterID")]
        public string orequesterID { get; set; }
        [JsonProperty("o.currencyCode")]
        public string ocurrencyCode { get; set; }
        [JsonProperty("o.flightSegmentVOs")]
        public OFlightsegmentvos[] oflightSegmentVOs { get; set; }
        [JsonProperty("o.flightOriginDestVOs")]
        public OFlightorigindestvos[] oflightOriginDestVOs { get; set; }
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
        [JsonProperty("o.marketingFlightNo")]
        public string omarketingFlightNo { get; set; }
        [JsonProperty("o.operatingAirLineID")]
        public string ooperatingAirLineID { get; set; }
        [JsonProperty("o.operatingFlightNo")]
        public string ooperatingFlightNo { get; set; }
        [JsonProperty("o.classCode")]
        public string oclassCode { get; set; }
        [JsonProperty("o.classMarketingName")]
        public string oclassMarketingName { get; set; }
        [JsonProperty("o.metadataKey")]
        public string ometadataKey { get; set; }
        [JsonProperty("o.displayFareType")]
        public string odisplayFareType { get; set; }
        [JsonProperty("o.bookingFareType")]
        public string obookingFareType { get; set; }
        [JsonProperty("o.ADTFareRuleRef")]
        public string oADTFareRuleRef { get; set; }
        [JsonProperty("o.ADTFareRuleDefinition")]
        public string oADTFareRuleDefinition { get; set; }
        [JsonProperty("o.CNNFareRuleRef", NullValueHandling = NullValueHandling.Ignore)]
        public string oCNNFareRuleRef { get; set; }
        [JsonProperty("o.CNNFareRuleDefinition", NullValueHandling = NullValueHandling.Ignore)]
        public string oCNNFareRuleDefinition { get; set; }
        [JsonProperty("o.INFFareRuleRef", NullValueHandling = NullValueHandling.Ignore)]
        public string oINFFareRuleRef { get; set; }
        [JsonProperty("o.INFFareRuleDefinition", NullValueHandling = NullValueHandling.Ignore)]
        public string oINFFareRuleDefinition { get; set; }
    }

    public class OFlightorigindestvos
    {
        [JsonProperty("o.originDestKey")]
        public string ooriginDestKey { get; set; }
        [JsonProperty("o.departureCode")]
        public string odepartureCode { get; set; }
        [JsonProperty("o.arrivalCode")]
        public string oarrivalCode { get; set; }
        [JsonProperty("o.flightReferences")]
        public string oflightReferences { get; set; }
    }

    public class OInsurancequotes
    {
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
        public Trip trip { get; set; }
        public Payment payment { get; set; }
    }

    public class Product
    {
        public string planID { get; set; }
        public string productCode { get; set; }
    }

    public class Trip
    {
        public string departureDate { get; set; }
        public string returnDate { get; set; }
        public string initialTripDepositDate { get; set; }
        public string finalPaymentDate { get; set; }
        public Destination[] destination { get; set; }
    }

    public class Destination
    {
        public string country { get; set; }
        public string city { get; set; }
    }

    public class Payment
    {
        public string totalPremiumAmount { get; set; }
    }

    public class OVehiclequotes
    {
        [JsonProperty("o.vehicleQuoteRequestInfo")]
        public OVehiclequoterequestinfo ovehicleQuoteRequestInfo { get; set; }
    }

    public class OVehiclequoterequestinfo
    {
        public string pickUpDateTime { get; set; }
        public string returnDateTime { get; set; }
        public Pickuplocation pickUpLocation { get; set; }
        public Returnlocation returnLocation { get; set; }
        public Drivertype driverType { get; set; }
        public string passengerQty { get; set; }
        public Reference reference { get; set; }
        public string rateQualifier { get; set; }
        public Totalcharge totalCharge { get; set; }
        public Vehpref vehPref { get; set; }
        public Fees fees { get; set; }
        public Vehiclecharges vehicleCharges { get; set; }
        public string gasPrePay { get; set; }
        public string luggageQty { get; set; }
        public Remark remark { get; set; }
        public Rentalpaymentpref rentalPaymentPref { get; set; }
        public string resStatus { get; set; }
        public string smokingAllowed { get; set; }
    }

    public class Pickuplocation
    {
        public string codeContext { get; set; }
        public string locationCode { get; set; }
    }

    public class Returnlocation
    {
        public string codeContext { get; set; }
        public string locationCode { get; set; }
    }

    public class Drivertype
    {
        public string age { get; set; }
        public string quantity { get; set; }
    }

    public class Reference
    {
        public string dateTime { get; set; }
        public string id { get; set; }
        public string id_Context { get; set; }
        public string type { get; set; }
        public string url { get; set; }
    }

    public class Totalcharge
    {
        public string currencyCode { get; set; }
        public string estimatedTotalAmount { get; set; }
        public string rateTotalAmount { get; set; }
    }

    public class Vehpref
    {
        public string airConditionInd { get; set; }
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
        public string size { get; set; }
    }

    public class Vehmakemodel
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Vehtype
    {
        public string doorCount { get; set; }
        public string vehicleCategory { get; set; }
    }

    public class Fees
    {
        public Fee fee { get; set; }
    }

    public class Fee
    {
        public string amount { get; set; }
        public string currencyCode { get; set; }
        public string purpose { get; set; }
    }

    public class Vehiclecharges
    {
        public Vehiclecharge vehicleCharge { get; set; }
    }

    public class Vehiclecharge
    {
        public string description { get; set; }
        public string includedInRate { get; set; }
        public string purpose { get; set; }
        public string taxInclusive { get; set; }
    }

    public class Remark
    {
        public string text { get; set; }
    }

    public class Rentalpaymentpref
    {
        public string paymentType { get; set; }
    }
}
