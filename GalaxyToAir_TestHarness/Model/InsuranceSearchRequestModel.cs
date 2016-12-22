using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
/****************************** Module Header ******************************\
Module Name     :   InsuranceSearchRequestModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas


JSON class for insurance search request
\***************************************************************************/
namespace GalaxyToAir_TestHarness.Model.InsuranceSearchRequest
{

    public class InsuranceSearchRequestModel
    {
        [JsonProperty("dns.insuranceQuoteRQ")]
        public DnsInsurancequoterq dnsinsuranceQuoteRQ { get; set; }
    }

    public class DnsInsurancequoterq
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
        public Travelers travelers { get; set; }
        public Trip trip { get; set; }
    }

    public class Product
    {
        public string planId { get; set; }
        public string productCode { get; set; }
        public string transactionType { get; set; }
    }

    public class Travelers
    {
        public Traveler[] traveler { get; set; }
    }

    public class Traveler
    {
        public string tripCost { get; set; }
        public string birthDate { get; set; }
        public string gender { get; set; }
        public Travelername travelerName { get; set; }
        public Address address { get; set; }
    }

    public class Travelername
    {
        public string first { get; set; }
        public string last { get; set; }
    }

    public class Address
    {
        public string street { get; set; }
        public string city { get; set; }
        public string zip { get; set; }
        public string country { get; set; }
        public string state { get; set; }
    }

    public class Trip
    {
        public string departureDate { get; set; }
        public string returnDate { get; set; }
        public string initialTripDepositDate { get; set; }
        public string finalPaymentDate { get; set; }
        public Destinations destinations { get; set; }
    }

    public class Destinations
    {
        public Destination destination { get; set; }
    }

    public class Destination
    {
        public string country { get; set; }
        public string state { get; set; }
    }

}
