using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
/****************************** Module Header ******************************\
Module Name     :   OrderDetailsRequestModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas


JSON class for order details request
\***************************************************************************/
namespace GalaxyToAir_TestHarness.Model.OrderDetailsRequest
{
  
    public class OrderDetailsRequestModel
    {
        [JsonProperty("o.OrderVO")]
        public OOrdervo oOrderVO { get; set; }
    }

    public class OOrdervo
    {
        [JsonProperty("o.id")]
        public string oid { get; set; }
    }

}
