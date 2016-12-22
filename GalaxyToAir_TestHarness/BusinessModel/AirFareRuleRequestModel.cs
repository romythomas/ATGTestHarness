using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/****************************** Module Header ******************************\
Module Name     :   AirFareRuleRequestModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas


Business model for Fare rule request
\***************************************************************************/
namespace GalaxyToAir_TestHarness.BusinessModel
{
    public class AirFareRuleRequestModel
    {
        public string ADTfareInfoRef { get; set; }
        public string ADTfareRuleKey { get; set; }
        public string CNNfareInfoRef { get; set; }
        public string CNNfareRuleKey { get; set; }
        public string INFfareInfoRef { get; set; }
        public string INFfareRuleKey { get; set; }
    }
}
