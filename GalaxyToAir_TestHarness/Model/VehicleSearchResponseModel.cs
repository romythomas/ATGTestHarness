using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaxyToAir_TestHarness.Util;
using Newtonsoft.Json;
/****************************** Module Header ******************************\
Module Name     :   VehicleSearchResponseModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas


JSON class for vehicle search response
\***************************************************************************/
namespace GalaxyToAir_TestHarness.Model.VehicleSearchResponse
{

    public class VehicleSearchResponseModel
    {
        [JsonProperty("va.VehicleAvailabilitySearchResponseVO")]
        public VaVehicleavailabilitysearchresponsevo vaVehicleAvailabilitySearchResponseVO { get; set; }
    }

    public class VaVehicleavailabilitysearchresponsevo
    {
        public string transactionID { get; set; }
        public string transactionStatus { get; set; }
        public DateTime timeStamp { get; set; }
        public string target { get; set; }
        public string xmlns { get; set; }
        public float version { get; set; }
        public string success { get; set; }
        public string primaryLangID { get; set; }
        public Vehavailrscore vehAvailRSCore { get; set; }
    }

    public class Vehavailrscore
    {
        public Vehrentalcore vehRentalCore { get; set; }
        public Vehvendoravails vehVendorAvails { get; set; }
    }

    public class Vehrentalcore
    {
        public DateTime pickUpDateTime { get; set; }
        public Pickuplocation pickUpLocation { get; set; }
        public Returnlocation returnLocation { get; set; }
        public DateTime returnDateTime { get; set; }
    }

    public class Pickuplocation
    {
        public string codeContext { get; set; }
        public int locationCode { get; set; }
    }

    public class Returnlocation
    {
        public string codeContext { get; set; }
        public int locationCode { get; set; }
    }

    public class Vehvendoravails
    {
        [JsonConverter(typeof(SingleOrArrayConverter<Vehvendoravail>))]
        public Vehvendoravail[] vehVendorAvail { get; set; }
    }

    public class Vehvendoravail
    {
        public Vehavails vehAvails { get; set; }
        public Vendor vendor { get; set; }
        public Info info { get; set; }
    }

    public class Vehavails
    {
        [JsonConverter(typeof(SingleOrArrayConverter<Vehavail>))]
        public Vehavail[] vehAvail { get; set; }
    }

    public class Vehavail
    {
        public Vehavailinfo vehAvailInfo { get; set; }
        public Vehavailcore vehAvailCore { get; set; }
    }

    public class Vehavailinfo
    {
        public string pricedCoverages { get; set; }
    }

    public class Vehavailcore
    {
        public Fees fees { get; set; }
        public string status { get; set; }
        public Rentalrate rentalRate { get; set; }
        public object pricedEquips { get; set; }
        public Reference reference { get; set; }
        public Vehicle vehicle { get; set; }
        public Totalcharge totalCharge { get; set; }
    }

    public class Fees
    {
        [JsonConverter(typeof(SingleOrArrayConverter<Fee>))]
        public Fee[] fee { get; set; }
    }

    public class Fee
    {
        public object amount { get; set; }
        public int purpose { get; set; }
        public string currencyCode { get; set; }
    }

    public class Rentalrate
    {
        public Vehiclecharges vehicleCharges { get; set; }
        public Ratequalifier rateQualifier { get; set; }
        public Ratedistance rateDistance { get; set; }
    }

    public class Vehiclecharges
    {
        public object vehicleCharge { get; set; }
    }

    public class Ratequalifier
    {
        public string rateQualifier { get; set; }
    }

    public class Ratedistance
    {
        public bool unlimited { get; set; }
    }

    public class Reference
    {
        public DateTime dateTime { get; set; }
        public int type { get; set; }
        public int id { get; set; }
        public string id_Context { get; set; }
        public string url { get; set; }
    }

    public class Vehicle
    {
        public Vehidentity vehIdentity { get; set; }
        public string fuelType { get; set; }
        public string transmissionType { get; set; }
        public Vehtype vehType { get; set; }
        public Vehclass vehClass { get; set; }
        public string pictureURL { get; set; }
        public Vehmakemodel vehMakeModel { get; set; }
        public string codeContext { get; set; }
        public int baggageQuantity { get; set; }
        public string code { get; set; }
        public string driveType { get; set; }
        public int passengerQuantity { get; set; }
        public bool airConditionInd { get; set; }
    }

    public class Vehidentity
    {
        public int vehicleAssetNumber { get; set; }
    }

    public class Vehtype
    {
        public int vehicleCategory { get; set; }
        public int doorCount { get; set; }
    }

    public class Vehclass
    {
        public int size { get; set; }
    }

    public class Vehmakemodel
    {
        public string name { get; set; }
        public string code { get; set; }
    }

    public class Totalcharge
    {
        public object rateTotalAmount { get; set; }
        public string currencyCode { get; set; }
        public object estimatedTotalAmount { get; set; }
    }

    public class Vendor
    {
        public string division { get; set; }
        public string companyShortName { get; set; }
        public string codeContext { get; set; }
        public int code { get; set; }
    }

    public class Info
    {
        public Locationdetails locationDetails { get; set; }
        public Vendormessages vendorMessages { get; set; }
    }

    public class Locationdetails
    {
        public string name { get; set; }
        public Telephone telephone { get; set; }
        public Additionalinfo additionalInfo { get; set; }
        public Address address { get; set; }
        public bool atAirport { get; set; }
        public int code { get; set; }
    }

    public class Telephone
    {
        public object phoneNumber { get; set; }
    }

    public class Additionalinfo
    {
        public Counterlocation counterLocation { get; set; }
        public Vehrentlocinfos vehRentLocInfos { get; set; }
    }

    public class Counterlocation
    {
        public string location { get; set; }
    }

    public class Vehrentlocinfos
    {
        public Vehrentlocinfo vehRentLocInfo { get; set; }
    }

    public class Vehrentlocinfo
    {
        public string type { get; set; }
    }

    public class Address
    {
        public Countryname countryName { get; set; }
        public string addressLine { get; set; }
        public string remark { get; set; }
    }

    public class Countryname
    {
        public string code { get; set; }
    }

    public class Vendormessages
    {
        public Vendormessage vendorMessage { get; set; }
    }

    public class Vendormessage
    {
        public Subsection subSection { get; set; }
    }

    public class Subsection
    {
        public Paragraph paragraph { get; set; }
    }

    public class Paragraph
    {
        public string url { get; set; }
    }

}
