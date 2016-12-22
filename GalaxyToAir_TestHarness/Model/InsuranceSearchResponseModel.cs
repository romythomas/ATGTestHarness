using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
/****************************** Module Header ******************************\
Module Name     :   InsuranceSearchResponseModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas


JSON class for insurance search response
\***************************************************************************/
namespace GalaxyToAir_TestHarness.Model.InsuranceSearchResponse
{
 
    public class InsuranceSearchResponseModel
    {
        [JsonProperty("ns10.InsuranceQuoteResponseVO")]
        public Ns10Insurancequoteresponsevo ns10InsuranceQuoteResponseVO { get; set; }
    }

    public class Ns10Insurancequoteresponsevo
    {
        public string transactionIdentifier { get; set; }
        public string transactionStatus { get; set; }
        public Getquoteresponse getQuoteResponse { get; set; }
    }

    public class Getquoteresponse
    {
        public Getquoteresult getQuoteResult { get; set; }
    }

    public class Getquoteresult
    {
        public Policyquotedetails policyQuoteDetails { get; set; }
    }

    public class Policyquotedetails
    {
        public Policyinformation policyInformation { get; set; }
    }

    public class Policyinformation
    {
        [JsonProperty("@planID")]
        public string planID { get; set; }
        public Premium premium { get; set; }
    }

    public class Premium
    {
        [JsonProperty("@totalPremiumAmount")]
        public string totalPremiumAmount { get; set; }
        [JsonProperty("@standardPremium")]
        public string standardPremium { get; set; }
        [JsonProperty("@optionalPremium")]
        public string optionalPremium { get; set; }
        [JsonProperty("@standardTax")]
        public string standardTax { get; set; }
        [JsonProperty("@optionalTax")]
        public string optionalTax { get; set; }
        [JsonProperty("@extendedTax")]
        public string extendedTax { get; set; }
        [JsonProperty("@extendedPremium")]
        public string extendedPremium { get; set; }
        [JsonProperty("@promotionalPremium")]
        public string promotionalPremium { get; set; }
        [JsonProperty("@feesPremium")]
        public string feesPremium { get; set; }
        [JsonProperty("@feesTax")]
        public string feesTax { get; set; }
        [JsonProperty("@standardFeesPremium")]
        public string standardFeesPremium { get; set; }
        [JsonProperty("@optionalFeesPremium")]
        public string optionalFeesPremium { get; set; }
        [JsonProperty("@tax")]
        public string tax { get; set; }
        public Standardpremiumdistribution standardPremiumDistribution { get; set; }
        public Packagepremiumdistribution packagePremiumDistribution { get; set; }
    }

    public class Standardpremiumdistribution
    {
        public Travelers travelers { get; set; }
    }

    public class Travelers
    {
        public Traveler traveler { get; set; }
    }

    public class Traveler
    {
        [JsonProperty("@travelerPremium")]
        public string travelerPremium { get; set; }
        [JsonProperty("@travelerTax")]
        public string travelerTax { get; set; }
    }

    public class Packagepremiumdistribution
    {
        public Packages packages { get; set; }
    }

    public class Packages
    {
        public Package package { get; set; }
    }

    public class Package
    {
        [JsonProperty("@packageID")]
        public string packageID { get; set; }
        [JsonProperty("@packageName")]
        public string packageName { get; set; }
        [JsonProperty("@packageTypeID")]
        public string packageTypeID { get; set; }
        [JsonProperty("@premium")]
        public string premium { get; set; }
        [JsonProperty("@fees")]
        public string fees { get; set; }
        [JsonProperty("@tax")]
        public string tax { get; set; }
        public Packagetravelers packageTravelers { get; set; }
    }

    public class Packagetravelers
    {
        public Packagetraveler packageTraveler { get; set; }
    }

    public class Packagetraveler
    {
        [JsonProperty("@travelerID")]
        public string travelerID { get; set; }
        [JsonProperty("@premium")]
        public string premium { get; set; }
        [JsonProperty("@tax")]
        public string tax { get; set; }
    }

}
