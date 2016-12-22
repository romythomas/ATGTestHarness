using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/****************************** Module Header ******************************\
Module Name     :   AirFareRuleRequestModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas


Business model for Fare rule response
\***************************************************************************/
namespace GalaxyToAir_TestHarness.BusinessModel
{
    public class AirFareRuleResponseModel
    {
        public string airFareRuleRequest { get; set; }
        public string airFareRuleResponse { get; set; }
        public string FareRule;
    }
}
