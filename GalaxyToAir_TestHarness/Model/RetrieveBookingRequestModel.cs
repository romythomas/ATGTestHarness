using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
/****************************** Module Header ******************************\
Module Name     :   RetrieveBookingRequestModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas


JSON class for post retrieve booking request
\***************************************************************************/
namespace GalaxyToAir_TestHarness.Model.RetrieveBookingRequest
{
   
    public class RetrieveBookingRequestModel
    {
        [JsonProperty("o.OrderVO")]
        public OOrdervo oOrderVO { get; set; }
    }

    public class OOrdervo
    {
        [JsonProperty("o.superPNR")]
        public string osuperPNR { get; set; }
    }

}
