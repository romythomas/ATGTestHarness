using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
/****************************** Module Header ******************************\
Module Name     :   VehicleRentalConditionRequestModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas


JSON class for rental condition request
\***************************************************************************/
namespace GalaxyToAir_TestHarness.Model.VehicleRentalConditionRequest
{

    public class VehicleRentalConditionRequestModel
    {
        [JsonProperty("vr.ct_RentalConditionsRQ")]
        public VrCt_Rentalconditionsrq vrct_RentalConditionsRQ { get; set; }
    }

    public class VrCt_Rentalconditionsrq
    {
        public POS POS { get; set; }
        public Vehresrqcore VehResRQCore { get; set; }
        public Vehresrqinfo VehResRQInfo { get; set; }
    }

    public class POS
    {
        public Source Source { get; set; }
    }

    public class Source
    {
        [JsonProperty("@ISOCurrency")]
        public string ISOCurrency { get; set; }
    }

    public class Vehresrqcore
    {
        public Vehrentalcore VehRentalCore { get; set; }
        public Customer Customer { get; set; }
        [JsonProperty("@Status")]
        public string Status { get; set; }
    }

    public class Vehrentalcore
    {
        public Pickuplocation[] PickUpLocation { get; set; }
        public Returnlocation ReturnLocation { get; set; }
        [JsonProperty("@PickUpDateTime")]
        public DateTime PickUpDateTime { get; set; }
        [JsonProperty("@ReturnDateTime")]
        public DateTime ReturnDateTime { get; set; }
    }

    public class Returnlocation
    {
        [JsonProperty("@CodeContext")]
        public string CodeContext { get; set; }
        [JsonProperty("@LocationCode")]
        public string LocationCode { get; set; }
        [JsonProperty("@Name")]
        public string Name { get; set; }
    }

    public class Pickuplocation
    {
        [JsonProperty("@CodeContext")]
        public string CodeContext { get; set; }
        [JsonProperty("@LocationCode")]
        public string LocationCode { get; set; }
        [JsonProperty("@Name")]
        public string Name { get; set; }
    }

    public class Customer
    {
        public Primary Primary { get; set; }
    }

    public class Primary
    {
        public Citizencountryname CitizenCountryName { get; set; }
    }

    public class Citizencountryname
    {
        [JsonProperty("@Code")]
        public string Code { get; set; }
    }

    public class Vehresrqinfo
    {
        public Reference Reference { get; set; }
    }

    public class Reference
    {
        [JsonProperty("@Type")]
        public string Type { get; set; }
        [JsonProperty("@ID")]
        public string ID { get; set; }
        [JsonProperty("@ID_Context")]
        public string ID_Context { get; set; }
        [JsonProperty("@DateTime")]
        public DateTime DateTime { get; set; }
        [JsonProperty("@URL")]
        public string URL { get; set; }
    }

}
