using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaxyToAir_TestHarness.BusinessModel;
/****************************** Module Header ******************************\
Module Name     :   IMasterService.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas

Interface for Master Service
\***************************************************************************/
namespace GalaxyToAir_TestHarness.Services
{
    public interface IMasterService
    {
        List<Country> GetCountry();
        List<Currency> GetCurrency();
        List<Airport> GetAirport();
        Suppliers GetSuppliers();
        Customers GetCustomers();
    }
}
