using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
/****************************** Module Header ******************************\
Module Name     :   VehicleSearchRequestModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas


JSON class for vehicle search request
\***************************************************************************/
namespace GalaxyToAir_TestHarness.Model.VehicleSearchRequest
{

    public class VehicleSearchRequestModel
    {
        [JsonProperty("va.VehicleAvailabilitySearchRequestVO")]
        public VaVehicleavailabilitysearchrequestvo vaVehicleAvailabilitySearchRequestVO { get; set; }
    }

    public class VaVehicleavailabilitysearchrequestvo
    {
        public Pos pos { get; set; }
        public Vehavailrqcore vehAvailRQCore { get; set; }
        public Vehavailrqinfo vehAvailRQInfo { get; set; }
    }

    public class Pos
    {
        public Source[] source { get; set; }
    }

    public class Source
    {
        public string isoCurrency { get; set; }
    }

    public class Vehavailrqcore
    {
        public Drivertype driverType { get; set; }
        public Vehrentalcore vehRentalCore { get; set; }
    }

    public class Drivertype
    {
        public string age { get; set; }
    }

    public class Vehrentalcore
    {
        public DateTime pickUpDateTime { get; set; }
        public Pickuplocation[] pickUpLocation { get; set; }
        public DateTime returnDateTime { get; set; }
        public Returnlocation returnLocation { get; set; }
    }

    public class Returnlocation
    {
        public string codeContext { get; set; }
        public string locationCode { get; set; }
    }

    public class Pickuplocation
    {
        public string codeContext { get; set; }
        public string locationCode { get; set; }
    }

    public class Vehavailrqinfo
    {
        public string passengerQty { get; set; }
        public Customer customer { get; set; }
    }

    public class Customer
    {
        public Primary primary { get; set; }
    }

    public class Primary
    {
        public Citizencountryname citizenCountryName { get; set; }
    }

    public class Citizencountryname
    {
        public string code { get; set; }
    }

}
