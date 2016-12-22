using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/****************************** Module Header ******************************\
Module Name     :   ServiceTypes.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas

Enumeration services used in application.
\***************************************************************************/
namespace GalaxyToAir_TestHarness.Util
{
    public enum ServiceTypes
    {
        FlightSearch,
        VehicleSearch,
        InsuranceSearch,
        AddToOrder,
        Book,
        GetCountry,
        GetCurrency,
        GetAirport,
        FareRule,
        PostBookingFareRule,
        RentalCondition
    }
}
