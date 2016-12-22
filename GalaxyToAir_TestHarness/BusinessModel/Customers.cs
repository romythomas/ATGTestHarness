using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/****************************** Module Header ******************************\
Module Name     :   Customers.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas


Business model for customer list
\***************************************************************************/
namespace GalaxyToAir_TestHarness.BusinessModel
{
     
    public class Customers
    {
        public Customerlist[] customerList { get; set; }
    }

    public class Customerlist
    {
        public string prefix { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string zip { get; set; }
        public string state { get; set; }
        public string apartment { get; set; }
        public string email { get; set; }
        public string countrycode { get; set; }
        public string phoneno { get; set; }
        public string country { get; set; }
    }
}
