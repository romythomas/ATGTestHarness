using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaxyToAir_TestHarness.Model;
/****************************** Module Header ******************************\
Module Name     :   InsuranceSearchResponseModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas


Business model for insurance search response
\***************************************************************************/
namespace GalaxyToAir_TestHarness.BusinessModel
{
    public class InsuranceSearchResponseModel
    {
        public string insuranceSearchRquest;
        public string insuranceSearchResponse;
        public InsuranceData insuranceData;
    }

    public class InsuranceData
    {
        public string planID { get; set; }
        public string productCode { get; set; }
        public string standardPremium { get; set; }
        public string optionalPremium { get; set; }
        public string standardTax { get; set; }
        public string optionalTax { get; set; }
        public string extendedTax { get; set; }
        public string extendedPremium { get; set; }
        public string promotionalPremium { get; set; }
        public string feesPremium { get; set; }
        public string feesTax { get; set; }
        public string standardFeesPremium { get; set; }
        public string optionalFeesPremium { get; set; }
        public string tax { get; set; }
        public string totalPremiumAmount { get; set; }
        public string departureDate { get; set; }
        public string destinationCity { get; set; }
        public string destinationCountry { get; set; }
        public string finalPaymentDate { get; set; }
        public string initialTripDepositDate { get; set; }
        public string returnDate { get; set; }
        public string tripCost { get; set; }
    }
}
