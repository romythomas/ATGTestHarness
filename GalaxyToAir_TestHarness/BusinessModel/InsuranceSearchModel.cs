using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/****************************** Module Header ******************************\
Module Name     :   InsuranceSearchModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas


Business model for insurance search request
\***************************************************************************/
namespace GalaxyToAir_TestHarness.BusinessModel
{
    public class InsuranceSearchModel
    {
        
        public string planID{get; set;}
        public string productCode { get; set; }
        public string tripCost { get; set; }
        public string birthDate { get; set; }
        public string gender{ get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string zip { get; set; }
        public string country { get; set; }
        public string state { get; set; }
        public string departureDate { get; set; }
        public string returnDate { get; set; }
        public string initialDepositDate { get; set; }
        public string finalPaymentDate { get; set; }
        public string destinationCountry { get; set; }
        public string destinationState { get; set; }
    }
}
