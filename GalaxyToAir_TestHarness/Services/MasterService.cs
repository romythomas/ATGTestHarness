using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaxyToAir_TestHarness.BusinessModel;
using GalaxyToAir_TestHarness.Util;
using GalaxyToAir_TestHarness.Model;
using Newtonsoft.Json;
/****************************** Module Header ******************************\
Module Name     :   MasterService.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas

Class contains business logic to call the master services for airport, country
currency, supplier, customer parse the response and return data in business model.
Right now these data are picked up from json files placed in App_Data inorder to
ensure performance
\***************************************************************************/
namespace GalaxyToAir_TestHarness.Services
{
    public class MasterService : IMasterService
    {

        public List<Country> GetCountry()
        {

            Model.GetCountry.GetCountryResponseModel response;
            //var output = ServiceBridge<Model.FlightSearchRequest.FlightSearchRequestModel>.Run(null, ServiceTypes.GetCountry, HttpMethod.Get);
            //response = JsonConvert.DeserializeObject<Model.GetCountry.GetCountryResponseModel>(output);

            response = JsonConvert.DeserializeObject<Model.GetCountry.GetCountryResponseModel>(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"App_Data\\country.json"));

            List<Country> lstCountry = new List<Country>();
            Country country;
            if (response != null)
            {
                if (response.ns9MasterRS.transactionStatus.ToUpper() == "SUCCESS")
                {
                    foreach (var item in response.ns9MasterRS.ns9countryList)
                    {
                        country = new Country();
                        country.code = item.ns9code;
                        country.name = item.ns9code + " - " + item.ns9name;

                        lstCountry.Add(country);
                    }
                }
            }
            return lstCountry;
        }


        public List<Currency> GetCurrency()
        {

            Model.GetCurrency.GetCurrencyResponseModel response;
            //var output = ServiceBridge<Model.FlightSearchRequest.FlightSearchRequestModel>.Run(null, ServiceTypes.GetCurrency, HttpMethod.Get);
            //response = JsonConvert.DeserializeObject<Model.GetCurrency.GetCurrencyResponseModel>(output);

            response = JsonConvert.DeserializeObject<Model.GetCurrency.GetCurrencyResponseModel>(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"App_Data\\currency.json"));

            List<Currency> lstCurrency = new List<Currency>();
            Currency currency;
            if (response != null)
            {
                if (response.ns9MasterRS.transactionStatus.ToUpper() == "SUCCESS")
                {
                    foreach (var item in response.ns9MasterRS.ns9currencyList)
                    {
                        currency = new Currency();
                        currency.code = item.ns9code;
                        currency.name = item.ns9code + " - " + item.ns9name;

                        lstCurrency.Add(currency);
                    }
                }
            }
            return lstCurrency;
        }


        public List<Airport> GetAirport()
        {

            Model.GetAirport.GetAirportResponseModel response;
            //var output = ServiceBridge<Model.FlightSearchRequest.FlightSearchRequestModel>.Run(null, ServiceTypes.GetAirport, HttpMethod.Get);
            //response = JsonConvert.DeserializeObject<Model.GetAirport.GetAirportResponseModel>(output);

            response = JsonConvert.DeserializeObject<Model.GetAirport.GetAirportResponseModel>(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"App_Data\\airport.json"));

            List<Airport> lstAirport = new List<Airport>();
            Airport airport;
            if (response != null)
            {
                if (response.ns9MasterRS.transactionStatus.ToUpper() == "SUCCESS")
                {
                    foreach (var item in response.ns9MasterRS.ns9airportList)
                    {
                        airport = new Airport();
                        airport.code = item.ns9code;
                        airport.name = item.ns9code + " - " + item.ns9name;

                        lstAirport.Add(airport);
                    }
                }
            }
            return lstAirport;
        }

        public Suppliers GetSuppliers()
        {
            Suppliers response;

            response = JsonConvert.DeserializeObject<Suppliers>(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"App_Data\\suppliers.json"));

            return response;
        }

        public Customers GetCustomers()
        {
            Customers response;

            response = JsonConvert.DeserializeObject<Customers>(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"App_Data\\customers.json"));

            return response;
        }
    }
}
