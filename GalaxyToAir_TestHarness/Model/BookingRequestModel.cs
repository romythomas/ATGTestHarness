using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
/****************************** Module Header ******************************\
Module Name     :   BookingRequestModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas


JSON class for booking request
\***************************************************************************/
namespace GalaxyToAir_TestHarness.Model.BookingRequest
{
    
    public class BookingRequestModel
    {
        [JsonProperty("o.OrderVO")]
        public OOrdervo oOrderVO { get; set; }
    }

    public class OOrdervo
    {
        [JsonProperty("o.id")]
        public string oid { get; set; }
        [JsonProperty("o.vehicleQuotes", NullValueHandling = NullValueHandling.Ignore)]
        public OVehiclequotes[] ovehicleQuotes { get; set; }
        [JsonProperty("o.airQuotes", NullValueHandling = NullValueHandling.Ignore)]
        public OAirquotes[] oairQuotes { get; set; }
        [JsonProperty("o.insuranceQuotes", NullValueHandling = NullValueHandling.Ignore)]
        public OInsurancequotes[] oinsuranceQuotes { get; set; }
    }

    public class OVehiclequotes
    {
        [JsonProperty("o.id")]
        public string oid { get; set; }
        [JsonProperty("o.passengerDetails")]
        public OPassengerdetails[] opassengerDetails { get; set; }
    }

    public class OPassengerdetails
    {
        [JsonProperty("o.age")]
        public string oage { get; set; }
        [JsonProperty("o.contactVO")]
        public OContactvo ocontactVO { get; set; }
        [JsonProperty("o.dateOfBirth")]
        public string odateOfBirth { get; set; }
        [JsonProperty("o.firstName")]
        public string ofirstName { get; set; }
        [JsonProperty("o.gender")]
        public string ogender { get; set; }
        [JsonProperty("o.leadPaxIndex")]
        public string oleadPaxIndex { get; set; }
        [JsonProperty("o.middleName")]
        public string omiddleName { get; set; }
        [JsonProperty("o.namePrefix")]
        public string onamePrefix { get; set; }
        [JsonProperty("o.nationality")]
        public string onationality { get; set; }
        [JsonProperty("o.physChallName")]
        public string ophysChallName { get; set; }
        [JsonProperty("o.surName")]
        public string osurName { get; set; }
        [JsonProperty("o.validInd")]
        public string ovalidInd { get; set; }
    }

    public class OContactvo
    {
        [JsonProperty("o.addressLineOne")]
        public string oaddressLineOne { get; set; }
        [JsonProperty("o.city")]
        public string ocity { get; set; }
        [JsonProperty("o.countryCode")]
        public string ocountryCode { get; set; }
        [JsonProperty("o.emailId")]
        public string oemailId { get; set; }
        [JsonProperty("o.phoneContacts")]
        public OPhonecontacts[] ophoneContacts { get; set; }
        [JsonProperty("o.stateProvince")]
        public string ostateProvince { get; set; }
        [JsonProperty("o.stateProvinceCode")]
        public string ostateProvinceCode { get; set; }
        [JsonProperty("o.streetName")]
        public string ostreetName { get; set; }
        [JsonProperty("o.type")]
        public string otype { get; set; }
        [JsonProperty("o.zipCode")]
        public string ozipCode { get; set; }
    }

    public class OPhonecontacts
    {
        [JsonProperty("o.areaCode")]
        public string oareaCode { get; set; }
        [JsonProperty("o.countryCode")]
        public string ocountryCode { get; set; }
        [JsonProperty("o.phoneNumber")]
        public string ophoneNumber { get; set; }
    }

    public class OAirquotes
    {
        [JsonProperty("o.id")]
        public string oid { get; set; }
        [JsonProperty("o.airBookingRequestVO")]
        public OAirbookingrequestvo oairBookingRequestVO { get; set; }
        [JsonProperty("o.target")]
        public string otarget { get; set; }
    }

    public class OAirbookingrequestvo
    {
        public Passengers passengers { get; set; }
    }

    public class Passengers
    {
        public Passenger[] passenger { get; set; }
    }

    public class Passenger
    {
        public Airptc airPtc { get; set; }
        public string residenceCode { get; set; }
        public Age age { get; set; }
        public Name name { get; set; }
        //public string profileID { get; set; }
        public Contacts contacts { get; set; }
        public string gender { get; set; }
        public string objectKey { get; set; }
        public string leadPaxIndex { get; set; }
        public Fqtvs fqtvs { get; set; }
        public Foids foids { get; set; }
        public Remarks remarks { get; set; }
    }

    public class Airptc
    {
        public string value { get; set; }
        public string quantity { get; set; }
    }

    public class Age
    {
        public string birthDate { get; set; }
    }

    public class Name
    {
        public string surname { get; set; }
        public string given { get; set; }
        public string middle { get; set; }
    }

    public class Contacts
    {
        public Contact[] contact { get; set; }
    }

    public class Contact
    {
        public Emailcontact emailContact { get; set; }
        public Phonecontact phoneContact { get; set; }
    }

    public class Emailcontact
    {
        public string address { get; set; }
    }

    public class Phonecontact
    {
        public string application { get; set; }
        public Number number { get; set; }
    }

    public class Number
    {
        public string countryCode { get; set; }
        public string value { get; set; }
    }

    public class Fqtvs
    {
        public string airLineID { get; set; }
        public Account account { get; set; }
        public string programID { get; set; }
    }

    public class Account
    {
        public string signID { get; set; }
        public string number { get; set; }
    }

    public class Foids
    {
        public Foid[] foid { get; set; }
    }

    public class Foid
    {
        public Type type { get; set; }
        public string id { get; set; }
        public string issuer { get; set; }
    }

    public class Type
    {
        public string shortDate { get; set; }
        public string content { get; set; }
    }

    public class Remarks
    {
        public string remark { get; set; }
    }

    public class OInsurancequotes
    {
        [JsonProperty("o.id")]
        public string oid { get; set; }
        [JsonProperty("o.travelers")]
        public OTravelers otravelers { get; set; }
        [JsonProperty("o.carriers")]
        public OCarriers ocarriers { get; set; }
    }

    public class OTravelers
    {
        [JsonProperty("o.traveler")]
        public OTraveler[] otraveler { get; set; }
    }

    public class OTraveler
    {
        [JsonProperty("o.leadPaxIndex")]
        public string oleadPaxIndex { get; set; }
        [JsonProperty("o.tripCost")]
        public string otripCost { get; set; }
        [JsonProperty("o.birthDate")]
        public string obirthDate { get; set; }
        [JsonProperty("o.gender")]
        public string ogender { get; set; }
        [JsonProperty("o.email")]
        public string oemail { get; set; }
        [JsonProperty("o.travelerName")]
        public OTravelername otravelerName { get; set; }
        [JsonProperty("o.address")]
        public OAddress oaddress { get; set; }
    }

    public class OTravelername
    {
        [JsonProperty("o.first")]
        public string ofirst { get; set; }
        [JsonProperty("o.last")]
        public string olast { get; set; }
    }

    public class OAddress
    {
        [JsonProperty("o.country")]
        public string ocountry { get; set; }
        [JsonProperty("o.state")]
        public string ostate { get; set; }
        [JsonProperty("o.city")]
        public string ocity { get; set; }
        [JsonProperty("o.street")]
        public string ostreet { get; set; }
        [JsonProperty("o.zip")]
        public string ozip { get; set; }
    }

    public class OCarriers
    {
        [JsonProperty("o.carrier")]
        public OCarrier[] ocarrier { get; set; }
    }

    public class OCarrier
    {
        [JsonProperty("o.carrierType")]
        public string ocarrierType { get; set; }
        [JsonProperty("o.name")]
        public string oname { get; set; }
    }

}
