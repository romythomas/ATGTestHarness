using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/****************************** Module Header ******************************\
Module Name     :   BookingRequestModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas


Business model for booking request
\***************************************************************************/
namespace GalaxyToAir_TestHarness.BusinessModel
{
    public class BookingRequestModel
    {
        public OrderData orderData { get; set; }
        public List<PaxData> paxData { get; set; }
    }
    public class PaxData
    {

        public string customerIndex { get; set; }
        public bool isAdult { get; set; }
        public string prefix { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string country { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string gender { get; set; }
        public string street { get; set; }
        public string apartment { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string email { get; set; }
        public string countryCode { get; set; }
        public string phoneNo { get; set; }
    }
}
