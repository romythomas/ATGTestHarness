using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using GalaxyToAir_TestHarness.Util;
/****************************** Module Header ******************************\
Module Name     :   BookingResponseModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas


JSON class for booking response
\***************************************************************************/
namespace GalaxyToAir_TestHarness.Model.BookingResponse
{

    public class BookingResponseModel
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
        [JsonProperty("o.superPNR")]
        public string osuperPNR { get; set; }
        [JsonProperty("o.superPNRStatus")]
        public string osuperPNRStatus { get; set; }
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
        [JsonProperty("o.providerConfirmationId")]
        public string oproviderConfirmationId { get; set; }
        [JsonProperty("o.status")]
        public string ostatus { get; set; }
        [JsonProperty("o.totalPrice")]
        public float ototalPrice { get; set; }
        [JsonProperty("o.vendorConfirmationId")]
        public string ovendorConfirmationId { get; set; }
        [JsonProperty("o.bookedOn")]
        public DateTime obookedOn { get; set; }
        [JsonProperty("o.vehicleQuoteResponseInfo")]
        public OVehiclequoteresponseinfo ovehicleQuoteResponseInfo { get; set; }
    }

    public class OVehiclequoteresponseinfo
    {
        public string primaryLangID { get; set; }
        public string target { get; set; }
        public DateTime timeStamp { get; set; }
        public string version { get; set; }
        public Conditionsrs conditionsRS { get; set; }
    }

    public class Conditionsrs
    {
        public string transactionStatus { get; set; }
        public string Success { get; set; }
        public string Type { get; set; }
        public string RentalConditionsSummary { get; set; }
        public Rentalconditions RentalConditions { get; set; }
    }

    public class Rentalconditions
    {
        [JsonConverter(typeof(SingleOrArrayConverter<Subsection>))]
        public Subsection[] SubSection { get; set; }
    }

    public class Subsection
    {
        public string Title { get; set; }
        public string Paragraph { get; set; }
    }

    public class OAirquotes
    {
        [JsonProperty("o.id")]
        public int oid { get; set; }
        [JsonProperty("o.pricingCurrency")]
        public string opricingCurrency { get; set; }
        [JsonProperty("o.providerConfirmationId")]
        public string oproviderConfirmationId { get; set; }
        [JsonProperty("o.status")]
        public string ostatus { get; set; }
        [JsonProperty("o.totalPrice")]
        public string ototalPrice { get; set; }
        [JsonProperty("o.vendorConfirmationId")]
        public string ovendorConfirmationId { get; set; }
        [JsonProperty("o.version")]
        public int oversion { get; set; }
        [JsonProperty("o.bookedOn")]
        public DateTime obookedOn { get; set; }
        [JsonProperty("o.airBookingResponseVO")]
        public OAirbookingresponsevo oairBookingResponseVO { get; set; }
    }

    public class OAirbookingresponsevo
    {
        public Airticketingresponsevo airTicketingResponseVO { get; set; }
    }

    public class Airticketingresponsevo
    {
        public Ticketdocinfos ticketDocInfos { get; set; }
    }

    public class Ticketdocinfos
    {
        [JsonConverter(typeof(SingleOrArrayConverter<Ticketdocinfo>))]
        public Ticketdocinfo[] ticketDocInfo { get; set; }
    }

    public class Ticketdocinfo
    {
        public Traveler traveler { get; set; }
        public Ticketdocument ticketDocument { get; set; }
        public Price price { get; set; }
    }

    public class Traveler
    {
        public string surName { get; set; }
        public string given { get; set; }
        public string ptc { get; set; }
        public string birthDate { get; set; }
        public Emailcontact emailContact { get; set; }
        public Phonecontact phoneContact { get; set; }
    }

    public class Emailcontact
    {
        public string address { get; set; }
    }

    public class Phonecontact
    {
        public Phonenumber phoneNumber { get; set; }
    }

    public class Phonenumber
    {
        public string countryCode { get; set; }
        public string value { get; set; }
    }

    public class Ticketdocument
    {
        public string ticketDocNbr { get; set; }
        public string ticketDocTypeCode { get; set; }
        public int NumberofBooklets { get; set; }
        public string dateOfIssue { get; set; }
        public string timeOfIssue { get; set; }
        [JsonConverter(typeof(SingleOrArrayConverter<Couponinfo>))]
        public Couponinfo[] couponInfo { get; set; }
    }

    public class Couponinfo
    {
        public int couponNumber { get; set; }
        public string statusCode { get; set; }
    }

    public class Price
    {
        public Total total { get; set; }
        public Details details { get; set; }
        public Taxes taxes { get; set; }
    }

    public class Total
    {
        public string code { get; set; }
        public string value { get; set; }
    }

    public class Details
    {
        public Detail detail { get; set; }
    }

    public class Detail
    {
        public string application { get; set; }
        public Amount amount { get; set; }
    }

    public class Amount
    {
        public string code { get; set; }
        public float value { get; set; }
    }

    public class Taxes
    {
        public Total1 total { get; set; }
        public Breakdown breakdown { get; set; }
    }

    public class Total1
    {
        public string code { get; set; }
        public float value { get; set; }
    }

    public class Breakdown
    {
        [JsonConverter(typeof(SingleOrArrayConverter<Tax>))]
        public Tax[] tax { get; set; }
    }

    public class Tax
    {
        public Amount1 amount { get; set; }
        public string taxCode { get; set; }
    }

    public class Amount1
    {
        public string code { get; set; }
        public object value { get; set; }
    }

    public class OInsurancequotes
    {
        [JsonProperty("o.id")]
        public int oid { get; set; }
        [JsonProperty("o.status")]
        public string ostatus { get; set; }
        [JsonProperty("o.bookedOn")]
        public DateTime obookedOn { get; set; }
        [JsonProperty("o.insuranceBookingResponseVO")]
        public OInsurancebookingresponsevo oinsuranceBookingResponseVO { get; set; }
    }

    public class OInsurancebookingresponsevo
    {
        public Policyinformation policyInformation { get; set; }
    }

    public class Policyinformation
    {
        public int policyId { get; set; }
        public int policyNumber { get; set; }
        public float totalPremiumAmount { get; set; }
        public float standardPremium { get; set; }
        public Product product { get; set; }
        public string primaryInsured { get; set; }
    }

    public class Product
    {
        public string productName { get; set; }
        public string planDesc { get; set; }
    }

}
