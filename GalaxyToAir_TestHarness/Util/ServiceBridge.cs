using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

/****************************** Module Header ******************************\
Module Name     :   ServiceBridge.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas

Service bridge is used as an inteface between test harness and IBS API. Based
on the incoming object, apporiate service url will be selected and object is
passed to service as json and response is passed back to calling method
\***************************************************************************/

namespace GalaxyToAir_TestHarness.Util
{
    public class ServiceBridge<T1>
    {
        public static string Run(T1 input, ServiceTypes servicetype, HttpMethod method)
        {
            string output = string.Empty;

            string ServiceBaseUrl = ConfigurationManager.AppSettings["ServiceBaseUrl"];
            string Url = string.Empty, ServiceUrl = string.Empty;

            switch(servicetype)
            {
                case ServiceTypes.FlightSearch:
                    ServiceUrl = ConfigurationManager.AppSettings["FlightSearchUrl"];
                    break;
                case ServiceTypes.VehicleSearch:
                    ServiceUrl = ConfigurationManager.AppSettings["VehicleSearchUrl"];
                    break;
                case ServiceTypes.InsuranceSearch:
                    ServiceUrl = ConfigurationManager.AppSettings["InsuranceSearchUrl"];
                    break;
                case ServiceTypes.AddToOrder:
                    ServiceUrl = ConfigurationManager.AppSettings["AddToOrderUrl"];
                    break;
                case ServiceTypes.GetCountry:
                    ServiceUrl = ConfigurationManager.AppSettings["GetCountryUrl"];
                    break;
                case ServiceTypes.GetAirport:
                    ServiceUrl = ConfigurationManager.AppSettings["GetAirportUrl"];
                    break;
                case ServiceTypes.GetCurrency:
                    ServiceUrl = ConfigurationManager.AppSettings["GetCurrencyUrl"];
                    break;
                case ServiceTypes.Book:
                    ServiceUrl = ConfigurationManager.AppSettings["BookOrderUrl"];
                    break;
                case ServiceTypes.FareRule:
                    ServiceUrl = ConfigurationManager.AppSettings["FareRuleUrl"];
                    break;
                case ServiceTypes.PostBookingFareRule:
                    ServiceUrl = ConfigurationManager.AppSettings["PostBookingFareRuleUrl"];
                    break;
                case ServiceTypes.RentalCondition:
                    ServiceUrl = ConfigurationManager.AppSettings["RentalConditionUrl"];
                    break;
                    
            }
            Url = ServiceBaseUrl + ServiceUrl;

            Task<string> task = RunAsync(input, Url, method);

            task.Wait();

            output = task.Result;

            return output;
        }

        static async Task<string> RunAsync(T1 input, string ServiceUrl, HttpMethod method)
        {
            string output = string.Empty;

            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var UserName = ConfigurationManager.AppSettings["UserName"];
                    var Password = ConfigurationManager.AppSettings["Password"];

                    var credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes(string.Format("{0}:{1}", UserName, Password)));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", credentials);

                    if(method == HttpMethod.Post)
                    { 
                        var response = await client.PostAsJsonAsync(ServiceUrl, input).ConfigureAwait(false);
                        if (response.IsSuccessStatusCode)
                        {
                            output = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                        }
                    }else if(method == HttpMethod.Get)
                    {
                        var response = await client.GetAsync(ServiceUrl).ConfigureAwait(false);
                        if (response.IsSuccessStatusCode)
                        {
                            output = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return output;
        }
    }
}
