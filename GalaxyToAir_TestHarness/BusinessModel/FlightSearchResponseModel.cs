using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaxyToAir_TestHarness.Model;
/****************************** Module Header ******************************\
Module Name     :   FlightSearchResponseModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas


Business model for flight search response
\***************************************************************************/
namespace GalaxyToAir_TestHarness.BusinessModel
{
    public class FlightSearchResponseModel
    {
        public string flightSearchRquest { get; set; }
        public string flightSearchResponse { get; set;}
        public List<OfferData> offerData { get; set;}
    }

    public class OfferData
    {
        public int noOfAdult { get; set; }
        public int noOfChild { get; set; }
        public int noOfInfant { get; set; }
        public string OfferId { get; set; }
        public float totalPrice { get; set; }
        public string tax { get; set; }
        public string Owner { get; set; }
        public string fareType { get; set; }
        public string currencyCode { get; set; }
        public string ADTfareRuleRef { get; set; }
        public string ADTfareRuleDefinition { get; set; }
        public string CNNfareRuleRef { get; set; }
        public string CNNfareRuleDefinition { get; set; }
        public string INFfareRuleRef { get; set; }
        public string INFfareRuleDefinition { get; set; }
        public string departureCode { get; set; }
        public string arrivalCode { get; set; }
        public List<FlightData> flightData{ get; set;}
    }

    public class FlightData
    {
        public string DepAirport { get; set; }
        public DateTime DepDate { get; set; }
        public string DepTime { get; set; }
        public string ArrivalAirport { get; set; }
        public DateTime ArrivalDate { get; set; }
        public string ArrivalTime { get; set; }
        public string MarketingAirlineId { get; set; }
        public string MarketingFlightNo { get; set; }
        public string OperatingArilineID { get; set; }
        public string OperatingFlightNo { get; set; }
        public string classCode { get; set; }
        public string classMarketingName { get; set; }
        public string flightReferences { get; set; }
        public string SegmentKey { get; set; }
        public string flightMetaKey { get; set; }
    }
}
