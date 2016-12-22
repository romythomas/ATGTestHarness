using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaxyToAir_TestHarness.Util;
using Newtonsoft.Json;
/****************************** Module Header ******************************\
Module Name     :   FlightSearchResponseModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas


JSON class for flight search response
\***************************************************************************/
namespace GalaxyToAir_TestHarness.Model.FlightSearchResponse
{

    public class FlightSearchResponseModel
    {
        [JsonProperty("ns9.AirShoppingRS")]
        public Ns9Airshoppingrs ns9AirShoppingRS { get; set; }
    }

    public class Ns9Airshoppingrs
    {
        public string transactionID { get; set; }
        public string transactionStatus { get; set; }
        [JsonProperty("ns9.shoppingResponseIDs")]
        public Ns9Shoppingresponseids ns9shoppingResponseIDs { get; set; }
        [JsonProperty("ns9.offersGroup")]
        public Ns9Offersgroup ns9offersGroup { get; set; }
        [JsonProperty("ns9.dataLists")]
        public Ns9Datalists ns9dataLists { get; set; }
        [JsonProperty("ns9.metadata")]
        public Ns9Metadata ns9metadata { get; set; }
    }

    public class Ns9Shoppingresponseids
    {
        [JsonProperty("ns9.owner")]
        public string ns9owner { get; set; }
        [JsonProperty("ns9.responseId")]
        public string ns9responseId { get; set; }
    }

    public class Ns9Offersgroup
    {
        [JsonProperty("ns9.airlineOffers")]
        [JsonConverter(typeof(SingleOrArrayConverter<Ns9Airlineoffers>))]
        public Ns9Airlineoffers[] ns9airlineOffers { get; set; }
    }

    public class Ns9Airlineoffers
    {
        [JsonProperty("ns9.owner")]
        public string ns9owner { get; set; }
        [JsonProperty("ns9.airlineOffer")]
        [JsonConverter(typeof(SingleOrArrayConverter<Ns9Airlineoffer>))]
        public Ns9Airlineoffer[] ns9airlineOffer { get; set; }
    }

    public class Ns9Airlineoffer
    {
        [JsonProperty("ns9.offerId")]
        public string ns9offerId { get; set; }
        [JsonProperty("ns9.price")]
        public float ns9price { get; set; }
        [JsonProperty("ns9.currencyCode")]
        public string ns9currencyCode { get; set; }
        [JsonProperty("ns9.taxTotal")]
        public float ns9taxTotal { get; set; }
        [JsonProperty("ns9.taxCode")]
        public string ns9taxCode { get; set; }
        [JsonProperty("ns9.offerPrice")]
        [JsonConverter(typeof(SingleOrArrayConverter<Ns9Offerprice>))]
        public Ns9Offerprice[] ns9offerPrice { get; set; }
        [JsonProperty("ns9.associations")]
        [JsonConverter(typeof(SingleOrArrayConverter<Ns9Associations>))]
        public Ns9Associations[] ns9associations { get; set; }
    }

    public class Ns9Offerprice
    {
        [JsonProperty("ns9.baseAmount")]
        public float ns9baseAmount { get; set; }
        [JsonProperty("ns9.baseAmountCode")]
        public string ns9baseAmountCode { get; set; }
        [JsonProperty("ns9.fareComponent")]
        [JsonConverter(typeof(SingleOrArrayConverter<Ns9Farecomponent>))]
        public Ns9Farecomponent[] ns9fareComponent { get; set; }
        [JsonProperty("ns9.passengerType")]
        public string ns9passengerType { get; set; }
    }

    public class Ns9Farecomponent
    {
        [JsonProperty("ns9.fareBasisCode")]
        public string ns9fareBasisCode { get; set; }
        [JsonProperty("ns9.fareRules")]
        public Ns9Farerules ns9fareRules { get; set; }
        [JsonProperty("ns9.fareRemark")]
        public string ns9fareRemark { get; set; }
        [JsonProperty("ns9.accountCode")]
        public string ns9accountCode { get; set; }
    }

    public class Ns9Farerules
    {
        [JsonProperty("ns9.objectKey")]
        public string ns9objectKey { get; set; }
        [JsonProperty("ns9.fareRuleRemark")]
        public string ns9fareRuleRemark { get; set; }
    }

    public class Ns9Associations
    {
        [JsonProperty("ns9.applicableFlight")]
        public Ns9Applicableflight ns9applicableFlight { get; set; }
    }

    public class Ns9Applicableflight
    {
        [JsonProperty("ns9.flightSegmentReference")]
        public Ns9Flightsegmentreference ns9flightSegmentReference { get; set; }
        [JsonProperty("ns9.flightReference")]
        public Ns9Flightreference ns9flightReference { get; set; }
    }

    public class Ns9Flightsegmentreference
    {
        [JsonProperty("ns9.flightRef")]
        public string ns9flightRef { get; set; }
        [JsonProperty("ns9.cabinDesignator")]
        public string ns9cabinDesignator { get; set; }
        [JsonProperty("ns9.marketingName")]
        public string ns9marketingName { get; set; }
    }

    public class Ns9Flightreference
    {
        [JsonProperty("ns9.value")]
        public string ns9value { get; set; }
        [JsonProperty("ns9.onPoint")]
        public string ns9onPoint { get; set; }
        [JsonProperty("ns9.offPoint")]
        public string ns9offPoint { get; set; }
    }

    public class Ns9Datalists
    {
        [JsonProperty("ns9.flightSegmentList")]
        public Ns9Flightsegmentlist ns9flightSegmentList { get; set; }
        [JsonProperty("ns9.originDestinationList")]
        public Ns9Origindestinationlist ns9originDestinationList { get; set; }
    }

    public class Ns9Flightsegmentlist
    {
        [JsonProperty("ns9.flightSegment")]
        [JsonConverter(typeof(SingleOrArrayConverter<Ns9Flightsegment>))]
        public Ns9Flightsegment[] ns9flightSegment { get; set; }
    }

    public class Ns9Flightsegment
    {
        [JsonProperty("ns9.segmentKey")]
        public string ns9segmentKey { get; set; }
        [JsonProperty("ns9.departureAirPortCode")]
        public string ns9departureAirPortCode { get; set; }
        [JsonProperty("ns9.departureDate")]
        public string ns9departureDate { get; set; }
        [JsonProperty("ns9.departureTime")]
        public string ns9departureTime { get; set; }
        [JsonProperty("ns9.arrivalAirPortCode")]
        public string ns9arrivalAirPortCode { get; set; }
        [JsonProperty("ns9.arrivalDate")]
        public string ns9arrivalDate { get; set; }
        [JsonProperty("ns9.arrivalTime")]
        public string ns9arrivalTime { get; set; }
        [JsonProperty("ns9.marketingAirLine")]
        public string ns9marketingAirLine { get; set; }
        [JsonProperty("ns9.flightNo")]
        public int ns9flightNo { get; set; }
        [JsonProperty("ns9.airCraftCode")]
        public object ns9airCraftCode { get; set; }
        [JsonProperty("ns9.stops")]
        public int ns9stops { get; set; }
        [JsonProperty("ns9.flightDuration")]
        public int ns9flightDuration { get; set; }
        [JsonProperty("ns9.operatingCarrierID")]
        public string ns9operatingCarrierID { get; set; }
        [JsonProperty("ns9.operatingCarrierFlightNo")]
        public int ns9operatingCarrierFlightNo { get; set; }
        [JsonProperty("ns9.flightDistanceValue")]
        public int ns9flightDistanceValue { get; set; }
        [JsonProperty("ns9.flightDistanceUOM")]
        public string ns9flightDistanceUOM { get; set; }
        [JsonProperty("ns9.direction")]
        public string ns9direction { get; set; }
    }

    public class Ns9Origindestinationlist
    {
        [JsonProperty("ns9.originDestination")]
        [JsonConverter(typeof(SingleOrArrayConverter<Ns9Origindestination>))]
        public Ns9Origindestination[] ns9originDestination { get; set; }
    }

    public class Ns9Origindestination
    {
        [JsonProperty("ns9.departureCode")]
        public string ns9departureCode { get; set; }
        [JsonProperty("ns9.arrivalCode")]
        public string ns9arrivalCode { get; set; }
        [JsonProperty("ns9.originDestinationflightReference")]
        public Ns9Origindestinationflightreference ns9originDestinationflightReference { get; set; }
    }

    public class Ns9Origindestinationflightreference
    {
        [JsonProperty("ns9.flightRef")]
        public object ns9flightRef { get; set; }
        [JsonProperty("ns9.onPoint")]
        public string ns9onPoint { get; set; }
        [JsonProperty("ns9.offPoint")]
        public string ns9offPoint { get; set; }
    }

    public class Ns9Metadata
    {
        [JsonProperty("ns9.flight")]
        public Ns9Flight ns9flight { get; set; }
    }

    public class Ns9Flight
    {
        [JsonProperty("ns9.flightMetadatasOrItineraryMetadata")]
        public Ns9Flightmetadatasoritinerarymetadata ns9flightMetadatasOrItineraryMetadata { get; set; }
    }

    public class Ns9Flightmetadatasoritinerarymetadata
    {
        [JsonProperty("ns9.flightMetadatas")]
        [JsonConverter(typeof(SingleOrArrayConverter<Ns9Flightmetadatas>))]
        public Ns9Flightmetadatas[] ns9flightMetadatas { get; set; }
    }

    public class Ns9Flightmetadatas
    {
        [JsonProperty("ns9.metadataKey")]
        public string ns9metadataKey { get; set; }
        [JsonProperty("ns9.augPointList")]
        public Ns9Augpointlist ns9augPointList { get; set; }
        [JsonProperty("ns9.Auglist")]
        public Ns9Auglist ns9Auglist { get; set; }
    }

    public class Ns9Augpointlist
    {
        [JsonProperty("ns9.key")]
        public string ns9key { get; set; }
    }

    public class Ns9Auglist
    {
        [JsonProperty("ns9.listName")]
        public string ns9listName { get; set; }
        [JsonProperty("ns9.listKey")]
        public int ns9listKey { get; set; }
        [JsonProperty("ns9.augPointAssoc")]
        public Ns9Augpointassoc ns9augPointAssoc { get; set; }
    }

    public class Ns9Augpointassoc
    {
        [JsonProperty("ns9.keyRef")]
        public Ns9Keyref ns9keyRef { get; set; }
    }

    public class Ns9Keyref
    {
        [JsonProperty("ns9.keyRef")]
        public string ns9keyRef { get; set; }
    }

}
