using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/****************************** Module Header ******************************\
Module Name     :   PostBookingFareRuleResponseModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas


Business model for post booking fare rule response
\***************************************************************************/
namespace GalaxyToAir_TestHarness.BusinessModel
{
    public class PostBookingFareRuleResponseModel
    {
        public string fareRuleRequest { get; set; }
        public string fareRuleResponse { get; set; }
        public string FareRule;
    }
}
