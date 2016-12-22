using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using GalaxyToAir_TestHarness.Util;
/****************************** Module Header ******************************\
Module Name     :   VehicleRentalConditionRequestModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas


JSON class for rental condition response
\***************************************************************************/
namespace GalaxyToAir_TestHarness.Model.VehicleRentalConditionResponse
{

    public class VehicleRentalConditionResponseModel
    {
        [JsonProperty("ns10.ctRentalConditionsRS")]
        public Ns10Ctrentalconditionsrs ns10ctRentalConditionsRS { get; set; }
    }

    public class Ns10Ctrentalconditionsrs
    {
        public string transactionID { get; set; }
        public string transactionStatus { get; set; }
        public string Success { get; set; }
        public string Type { get; set; }
        public Rentalconditionssummary RentalConditionsSummary { get; set; }
        public Rentalconditions RentalConditions { get; set; }
    }

    public class Rentalconditionssummary
    {
        public Subsection SubSection { get; set; }
    }

    public class Subsection
    {
        [JsonProperty("@Title")]
        public string Title { get; set; }
        [JsonProperty("@TitleNameId")]
        public string TitleNameId { get; set; }
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public string[] Paragraph { get; set; }
    }

    public class Rentalconditions
    {
        [JsonConverter(typeof(SingleOrArrayConverter<Subsection1>))]
        public Subsection1[] SubSection { get; set; }
    }

    public class Subsection1
    {
        [JsonProperty("@Title")]
        public string Title { get; set; }
        [JsonProperty("@TitleNameId")]
        public string TitleNameId { get; set; }
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public string[] Paragraph { get; set; }
    }

}
