using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaxyToAir_TestHarness.BusinessModel;
using GalaxyToAir_TestHarness.Model;
using GalaxyToAir_TestHarness.Util;
using Newtonsoft.Json;
/****************************** Module Header ******************************\
Module Name     :   BookingService.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas

Class contains business logic to construct booking object, call the 
booking service, parse the response and return data in business model.
\***************************************************************************/
namespace GalaxyToAir_TestHarness.Services
{
    public class BookingService : IBookingService
    {
        public BookingResponseModel BookOrder(BookingRequestModel request)
        {

            var bookingObj = new Model.BookingRequest.BookingRequestModel();
            var bookingResponse = new BusinessModel.BookingResponseModel();
            var target = ConfigurationManager.AppSettings["target"].ToString().ToLower();
            int i = 0;
            try
            {
                bookingObj.oOrderVO = new Model.BookingRequest.OOrdervo();
                bookingObj.oOrderVO.oid = request.orderData.orderId.ToString();

                if (request.orderData.airlineOrderAvailable)
                {
                    bookingObj.oOrderVO.oairQuotes = new Model.BookingRequest.OAirquotes[1];
                    bookingObj.oOrderVO.oairQuotes[0] = new Model.BookingRequest.OAirquotes();
                    bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO = new Model.BookingRequest.OAirbookingrequestvo();
                    bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers = new Model.BookingRequest.Passengers();
                    bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger = new Model.BookingRequest.Passenger[request.paxData.Count];

                    foreach(var pax in request.paxData)
                    {
                        bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i] = new Model.BookingRequest.Passenger();
                        bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].age = new Model.BookingRequest.Age();
                        bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].age.birthDate = pax.dateOfBirth.ToString("yyyy-MM-dd");
                        bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].airPtc = new Model.BookingRequest.Airptc();
                        bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].airPtc.quantity = "1";
                        if(pax.isAdult)
                        { 
                            bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].airPtc.value = "ADT";
                        }
                        else
                        {
                            bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].airPtc.value = "CNN";
                        }
                        bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].contacts = new Model.BookingRequest.Contacts();
                        bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].contacts.contact = new Model.BookingRequest.Contact[1];
                        bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].contacts.contact[0] = new Model.BookingRequest.Contact();
                        bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].contacts.contact[0].emailContact = new Model.BookingRequest.Emailcontact();
                        bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].contacts.contact[0].emailContact.address = pax.email;
                        bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].contacts.contact[0].phoneContact = new Model.BookingRequest.Phonecontact();
                        bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].contacts.contact[0].phoneContact.application = "Emergency";
                        bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].contacts.contact[0].phoneContact.number = new Model.BookingRequest.Number();
                        bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].contacts.contact[0].phoneContact.number.countryCode = pax.countryCode;
                        bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].contacts.contact[0].phoneContact.number.value = pax.phoneNo;
                        bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].foids = new Model.BookingRequest.Foids();
                        bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].foids.foid = new Model.BookingRequest.Foid[1];
                        bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].foids.foid[0] = new Model.BookingRequest.Foid();
                        bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].foids.foid[0].id = "123456";
                        bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].foids.foid[0].type = new Model.BookingRequest.Type();
                        bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].foids.foid[0].type.content = "P";
                        bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].foids.foid[0].type.shortDate = "2020-11-13";
                        bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].foids.foid[0].issuer = "US";
                        bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].fqtvs = new Model.BookingRequest.Fqtvs();
                        bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].fqtvs.account = new Model.BookingRequest.Account();
                        bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].fqtvs.account.number = "LNADT123456789"; //LNADT123456789
                        bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].fqtvs.account.signID = "SIGN1"; //SIGN1
                        bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].fqtvs.airLineID = request.orderData.airlineId;
                        bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].fqtvs.programID = "LOYALPGM1"; //LOYALPGM1
                        bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].gender = pax.gender;
                        if(i==0)
                        { 
                            bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].leadPaxIndex = "yes";
                        }
                        else
                        {
                            bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].leadPaxIndex = "no";
                        }
                        bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].name = new Model.BookingRequest.Name();
                        bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].name.given = pax.firstName;
                        bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].name.middle = pax.middleName;
                        bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].name.surname = pax.lastName;
                        bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].objectKey = "PAX" + (i+1).ToString();
                        bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].remarks = new Model.BookingRequest.Remarks();
                        bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].remarks.remark = "";
                        bookingObj.oOrderVO.oairQuotes[0].oairBookingRequestVO.passengers.passenger[i].residenceCode = pax.country;

                        i++;
                    }
                    
                    bookingObj.oOrderVO.oairQuotes[0].oid = request.orderData.airQuoteId.ToString();
                    bookingObj.oOrderVO.oairQuotes[0].otarget = target;
                }
                if (request.orderData.insuranceOrderAvailable)
                {
                    bookingObj.oOrderVO.oinsuranceQuotes = new Model.BookingRequest.OInsurancequotes[1];
                    bookingObj.oOrderVO.oinsuranceQuotes[0] = new Model.BookingRequest.OInsurancequotes();
                    bookingObj.oOrderVO.oinsuranceQuotes[0].ocarriers = new Model.BookingRequest.OCarriers();
                    bookingObj.oOrderVO.oinsuranceQuotes[0].ocarriers.ocarrier = new Model.BookingRequest.OCarrier[1];
                    bookingObj.oOrderVO.oinsuranceQuotes[0].ocarriers.ocarrier[0] = new Model.BookingRequest.OCarrier();
                    bookingObj.oOrderVO.oinsuranceQuotes[0].ocarriers.ocarrier[0].ocarrierType = "Airline";
                    bookingObj.oOrderVO.oinsuranceQuotes[0].ocarriers.ocarrier[0].oname = "American";
                    bookingObj.oOrderVO.oinsuranceQuotes[0].oid = request.orderData.insuranceQuoteId.ToString();
                    bookingObj.oOrderVO.oinsuranceQuotes[0].otravelers = new Model.BookingRequest.OTravelers();
                    bookingObj.oOrderVO.oinsuranceQuotes[0].otravelers.otraveler = new Model.BookingRequest.OTraveler[request.paxData.Count];

                    i = 0;
                    foreach (var pax in request.paxData)
                    {
                        bookingObj.oOrderVO.oinsuranceQuotes[0].otravelers.otraveler[i] = new Model.BookingRequest.OTraveler();
                        bookingObj.oOrderVO.oinsuranceQuotes[0].otravelers.otraveler[i].oaddress = new Model.BookingRequest.OAddress();
                        bookingObj.oOrderVO.oinsuranceQuotes[0].otravelers.otraveler[i].oaddress.ocity = pax.city;
                        bookingObj.oOrderVO.oinsuranceQuotes[0].otravelers.otraveler[i].oaddress.ocountry = pax.country;
                        bookingObj.oOrderVO.oinsuranceQuotes[0].otravelers.otraveler[i].oaddress.ostate = pax.state;
                        bookingObj.oOrderVO.oinsuranceQuotes[0].otravelers.otraveler[i].oaddress.ostreet = pax.street;
                        bookingObj.oOrderVO.oinsuranceQuotes[0].otravelers.otraveler[i].oaddress.ozip = pax.zip;
                        bookingObj.oOrderVO.oinsuranceQuotes[0].otravelers.otraveler[i].obirthDate = pax.dateOfBirth.ToString("yyyy-MM-dd");
                        bookingObj.oOrderVO.oinsuranceQuotes[0].otravelers.otraveler[i].oemail = pax.email;
                        bookingObj.oOrderVO.oinsuranceQuotes[0].otravelers.otraveler[i].ogender = pax.gender;
                        bookingObj.oOrderVO.oinsuranceQuotes[0].otravelers.otraveler[i].oleadPaxIndex = "yes";
                        bookingObj.oOrderVO.oinsuranceQuotes[0].otravelers.otraveler[i].otravelerName = new Model.BookingRequest.OTravelername();
                        bookingObj.oOrderVO.oinsuranceQuotes[0].otravelers.otraveler[i].otravelerName.ofirst = pax.firstName;
                        bookingObj.oOrderVO.oinsuranceQuotes[0].otravelers.otraveler[i].otravelerName.olast = pax.lastName;
                        bookingObj.oOrderVO.oinsuranceQuotes[0].otravelers.otraveler[i].otripCost = request.orderData.tripCost;
                        i++;
                    }
                    
                }
                if (request.orderData.vehicleOrderAvailable)
                {
                    bookingObj.oOrderVO.ovehicleQuotes = new Model.BookingRequest.OVehiclequotes[1];
                    bookingObj.oOrderVO.ovehicleQuotes[0] = new Model.BookingRequest.OVehiclequotes();
                    bookingObj.oOrderVO.ovehicleQuotes[0].oid = request.orderData.vehicleQuoteId.ToString();
                    bookingObj.oOrderVO.ovehicleQuotes[0].opassengerDetails = new Model.BookingRequest.OPassengerdetails[request.paxData.Count];

                    i = 0;
                    foreach (var pax in request.paxData)
                    {
                        bookingObj.oOrderVO.ovehicleQuotes[0].opassengerDetails[i] = new Model.BookingRequest.OPassengerdetails();
                        bookingObj.oOrderVO.ovehicleQuotes[0].opassengerDetails[i].oage = request.orderData.driverAge;
                        bookingObj.oOrderVO.ovehicleQuotes[0].opassengerDetails[i].ocontactVO = new Model.BookingRequest.OContactvo();
                        bookingObj.oOrderVO.ovehicleQuotes[0].opassengerDetails[i].ocontactVO.oaddressLineOne = pax.apartment;
                        bookingObj.oOrderVO.ovehicleQuotes[0].opassengerDetails[i].ocontactVO.ocity = pax.city;
                        bookingObj.oOrderVO.ovehicleQuotes[0].opassengerDetails[i].ocontactVO.ocountryCode = pax.country;
                        bookingObj.oOrderVO.ovehicleQuotes[0].opassengerDetails[i].ocontactVO.oemailId = pax.email;
                        bookingObj.oOrderVO.ovehicleQuotes[0].opassengerDetails[i].ocontactVO.ophoneContacts = new Model.BookingRequest.OPhonecontacts[1];
                        bookingObj.oOrderVO.ovehicleQuotes[0].opassengerDetails[i].ocontactVO.ophoneContacts[0] = new Model.BookingRequest.OPhonecontacts();
                        bookingObj.oOrderVO.ovehicleQuotes[0].opassengerDetails[i].ocontactVO.ophoneContacts[0].oareaCode = pax.phoneNo.Substring(0, 3);
                        bookingObj.oOrderVO.ovehicleQuotes[0].opassengerDetails[i].ocontactVO.ophoneContacts[0].ocountryCode = pax.countryCode;
                        bookingObj.oOrderVO.ovehicleQuotes[0].opassengerDetails[i].ocontactVO.ophoneContacts[0].ophoneNumber = pax.phoneNo.Substring(3);
                        bookingObj.oOrderVO.ovehicleQuotes[0].opassengerDetails[i].ocontactVO.ostateProvince = "Nevada";
                        bookingObj.oOrderVO.ovehicleQuotes[0].opassengerDetails[i].ocontactVO.ostateProvinceCode = "NV";
                        bookingObj.oOrderVO.ovehicleQuotes[0].opassengerDetails[i].ocontactVO.ostreetName = pax.street;
                        bookingObj.oOrderVO.ovehicleQuotes[0].opassengerDetails[i].ocontactVO.otype = "2";
                        bookingObj.oOrderVO.ovehicleQuotes[0].opassengerDetails[i].ocontactVO.ozipCode = pax.zip;

                        bookingObj.oOrderVO.ovehicleQuotes[0].opassengerDetails[i].odateOfBirth = pax.dateOfBirth.ToString("yyyy-MM-dd");
                        bookingObj.oOrderVO.ovehicleQuotes[0].opassengerDetails[i].ofirstName = pax.firstName;
                        bookingObj.oOrderVO.ovehicleQuotes[0].opassengerDetails[i].ogender = pax.gender;
                        if(i == 0)
                        {
                            bookingObj.oOrderVO.ovehicleQuotes[0].opassengerDetails[i].oleadPaxIndex = "yes";
                        }
                        else
                        {
                            bookingObj.oOrderVO.ovehicleQuotes[0].opassengerDetails[i].oleadPaxIndex = "no";
                        }
                        bookingObj.oOrderVO.ovehicleQuotes[0].opassengerDetails[i].omiddleName = pax.middleName;
                        bookingObj.oOrderVO.ovehicleQuotes[0].opassengerDetails[i].onamePrefix = pax.prefix;
                        bookingObj.oOrderVO.ovehicleQuotes[0].opassengerDetails[i].onationality = pax.country;
                        bookingObj.oOrderVO.ovehicleQuotes[0].opassengerDetails[i].ophysChallName = "false";
                        bookingObj.oOrderVO.ovehicleQuotes[0].opassengerDetails[i].osurName = pax.lastName;
                        bookingObj.oOrderVO.ovehicleQuotes[0].opassengerDetails[i].ovalidInd = "true";
                        i++;
                    }
                }

                Model.BookingResponse.BookingResponseModel response;

                var output = Util.ServiceBridge<Model.BookingRequest.BookingRequestModel>.Run(bookingObj, ServiceTypes.Book, HttpMethod.Post);

                bookingResponse.bookingRequest = JsonConvert.SerializeObject(bookingObj);
                bookingResponse.bookingResponse = output;
                var bookingData = new BookingData();

                response = JsonConvert.DeserializeObject<Model.BookingResponse.BookingResponseModel>(output);

                if(response!= null)
                {
                    if(response.oOrderVO.otransactionStatus.ToUpper() == "SUCCESS")
                    {
                        bookingData.superPNR = response.oOrderVO.osuperPNR;
                        if(response.oOrderVO.oairQuotes!= null)
                        {
                            bookingData.airProviderConfID = response.oOrderVO.oairQuotes.oproviderConfirmationId;
                            bookingData.airTotalPrice = response.oOrderVO.oairQuotes.ototalPrice;
                        }
                        if(response.oOrderVO.ovehicleQuotes != null)
                        {
                            bookingData.vehicleProviderConfID = response.oOrderVO.ovehicleQuotes.oproviderConfirmationId;
                            bookingData.vehicleTotalPrice = response.oOrderVO.ovehicleQuotes.ototalPrice;
                        }
                        if(response.oOrderVO.oinsuranceQuotes != null)
                        {
                            bookingData.insurancePolicyNumber = response.oOrderVO.oinsuranceQuotes.oinsuranceBookingResponseVO.policyInformation.policyNumber.ToString();
                            bookingData.insurnceTotalPremiumAmount = response.oOrderVO.oinsuranceQuotes.oinsuranceBookingResponseVO.policyInformation.totalPremiumAmount;
                        }
                    }

                    bookingResponse.bookingData = bookingData;
                }
            }
            catch (Exception ex)
            {

            }
            return bookingResponse;
        }
    }
}
