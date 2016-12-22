using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaxyToAir_TestHarness.BusinessModel;
using GalaxyToAir_TestHarness.Model;
using GalaxyToAir_TestHarness.Util;
using Newtonsoft.Json;
/****************************** Module Header ******************************\
Module Name     :   VehicleService.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas

Class contains business logic to construct vehicle search object, call the 
search service, parse the response and return data in business model.
\***************************************************************************/
namespace GalaxyToAir_TestHarness.Services
{
    public class VehicleService : IVehicleService
    {

        public VehicleSearchResponseModel GetVehicleDetails(VehicleSearchRequestModel request)
        {
            var vehicleSearchResponse = new VehicleSearchResponseModel();
            var vehicleObject = new Model.VehicleSearchRequest.VehicleSearchRequestModel();
            try
            {
            
                vehicleObject.vaVehicleAvailabilitySearchRequestVO = new Model.VehicleSearchRequest.VaVehicleavailabilitysearchrequestvo();
                vehicleObject.vaVehicleAvailabilitySearchRequestVO.pos = new Model.VehicleSearchRequest.Pos();
                vehicleObject.vaVehicleAvailabilitySearchRequestVO.pos.source = new Model.VehicleSearchRequest.Source[1];
                vehicleObject.vaVehicleAvailabilitySearchRequestVO.pos.source[0] = new Model.VehicleSearchRequest.Source();
                vehicleObject.vaVehicleAvailabilitySearchRequestVO.pos.source[0].isoCurrency = request.currency;
                vehicleObject.vaVehicleAvailabilitySearchRequestVO.vehAvailRQCore = new Model.VehicleSearchRequest.Vehavailrqcore();
                vehicleObject.vaVehicleAvailabilitySearchRequestVO.vehAvailRQCore.driverType = new Model.VehicleSearchRequest.Drivertype();
                vehicleObject.vaVehicleAvailabilitySearchRequestVO.vehAvailRQCore.driverType.age = request.age;
                vehicleObject.vaVehicleAvailabilitySearchRequestVO.vehAvailRQCore.vehRentalCore = new Model.VehicleSearchRequest.Vehrentalcore();
            
                vehicleObject.vaVehicleAvailabilitySearchRequestVO.vehAvailRQCore.vehRentalCore.pickUpDateTime = request.pickupDateTime;
                vehicleObject.vaVehicleAvailabilitySearchRequestVO.vehAvailRQCore.vehRentalCore.pickUpLocation = new Model.VehicleSearchRequest.Pickuplocation[1];
                vehicleObject.vaVehicleAvailabilitySearchRequestVO.vehAvailRQCore.vehRentalCore.pickUpLocation[0] = new Model.VehicleSearchRequest.Pickuplocation();
                vehicleObject.vaVehicleAvailabilitySearchRequestVO.vehAvailRQCore.vehRentalCore.pickUpLocation[0].locationCode = request.pickupLocation;
                vehicleObject.vaVehicleAvailabilitySearchRequestVO.vehAvailRQCore.vehRentalCore.pickUpLocation[0].codeContext = "IATA";

                vehicleObject.vaVehicleAvailabilitySearchRequestVO.vehAvailRQCore.vehRentalCore.returnDateTime = request.returnDateTime;
                vehicleObject.vaVehicleAvailabilitySearchRequestVO.vehAvailRQCore.vehRentalCore.returnLocation = new Model.VehicleSearchRequest.Returnlocation();
                vehicleObject.vaVehicleAvailabilitySearchRequestVO.vehAvailRQCore.vehRentalCore.returnLocation.locationCode = request.returnLocation;
                vehicleObject.vaVehicleAvailabilitySearchRequestVO.vehAvailRQCore.vehRentalCore.returnLocation.codeContext = "IATA";

                vehicleObject.vaVehicleAvailabilitySearchRequestVO.vehAvailRQInfo = new Model.VehicleSearchRequest.Vehavailrqinfo();
                vehicleObject.vaVehicleAvailabilitySearchRequestVO.vehAvailRQInfo.passengerQty = request.noOfPassengers;
                vehicleObject.vaVehicleAvailabilitySearchRequestVO.vehAvailRQInfo.customer = new Model.VehicleSearchRequest.Customer();
                vehicleObject.vaVehicleAvailabilitySearchRequestVO.vehAvailRQInfo.customer.primary = new Model.VehicleSearchRequest.Primary();
                vehicleObject.vaVehicleAvailabilitySearchRequestVO.vehAvailRQInfo.customer.primary.citizenCountryName = new Model.VehicleSearchRequest.Citizencountryname();
                vehicleObject.vaVehicleAvailabilitySearchRequestVO.vehAvailRQInfo.customer.primary.citizenCountryName.code = request.country;

                Model.VehicleSearchResponse.VehicleSearchResponseModel response;

                var output = Util.ServiceBridge<Model.VehicleSearchRequest.VehicleSearchRequestModel>.Run(vehicleObject, ServiceTypes.VehicleSearch, HttpMethod.Post);

                
                vehicleSearchResponse.vehicleData = new List<VehicleData>();
                vehicleSearchResponse.vehicleSearchRquest = JsonConvert.SerializeObject(vehicleObject);
                vehicleSearchResponse.vehicleSearchResponse = output;
                VehicleData obj;

                response = JsonConvert.DeserializeObject<Model.VehicleSearchResponse.VehicleSearchResponseModel>(output);

                if (response != null)
                {

                    if (response.vaVehicleAvailabilitySearchResponseVO.transactionStatus.ToUpper() == "SUCCESS")
                    { 
                        foreach(var vehVendorAvail in response.vaVehicleAvailabilitySearchResponseVO.vehAvailRSCore.vehVendorAvails.vehVendorAvail)
                        {

                            foreach (var vehicle in vehVendorAvail.vehAvails.vehAvail)
                            {
                                obj = new VehicleData();

                                obj.pickupDatetime = response.vaVehicleAvailabilitySearchResponseVO.vehAvailRSCore.vehRentalCore.pickUpDateTime;
                                obj.pickupLocation = response.vaVehicleAvailabilitySearchResponseVO.vehAvailRSCore.vehRentalCore.pickUpLocation.locationCode;
                                obj.pickupCodeContext = response.vaVehicleAvailabilitySearchResponseVO.vehAvailRSCore.vehRentalCore.pickUpLocation.codeContext;
                                obj.returnDatetime = response.vaVehicleAvailabilitySearchResponseVO.vehAvailRSCore.vehRentalCore.returnDateTime;
                                obj.returnLocation = response.vaVehicleAvailabilitySearchResponseVO.vehAvailRSCore.vehRentalCore.returnLocation.locationCode;
                                obj.returnCodeContext = response.vaVehicleAvailabilitySearchResponseVO.vehAvailRSCore.vehRentalCore.returnLocation.codeContext;
                                obj.vendorCode = vehVendorAvail.vendor.code;
                                obj.vendorName = vehVendorAvail.vendor.companyShortName;
                                obj.driverAge = request.age;
                                obj.driverQty = "1";

                                obj.airConditionAvailable = vehicle.vehAvailCore.vehicle.airConditionInd;
                                obj.vehAvailDateTime = vehicle.vehAvailCore.reference.dateTime;
                                obj.Id = vehicle.vehAvailCore.reference.id;
                                obj.id_Context = vehicle.vehAvailCore.reference.id_Context;
                                obj.type = vehicle.vehAvailCore.reference.type;
                                obj.url = vehicle.vehAvailCore.reference.url;
                                obj.rateQualifier = vehicle.vehAvailCore.rentalRate.rateQualifier.rateQualifier;
                                obj.vehCode = vehicle.vehAvailCore.vehicle.vehMakeModel.code;
                                obj.codeContext = vehicle.vehAvailCore.vehicle.codeContext;
                                obj.driveType = vehicle.vehAvailCore.vehicle.driveType;
                                obj.fuelType = vehicle.vehAvailCore.vehicle.fuelType;
                                obj.transmissionType = vehicle.vehAvailCore.vehicle.transmissionType;
                                obj.size = vehicle.vehAvailCore.vehicle.vehClass.size;
                                obj.makeModelCode = vehicle.vehAvailCore.vehicle.vehMakeModel.code;
                                obj.makeModelName = vehicle.vehAvailCore.vehicle.vehMakeModel.name;
                                obj.doorCount = vehicle.vehAvailCore.vehicle.vehType.doorCount;
                                obj.vehCategory = vehicle.vehAvailCore.vehicle.vehType.vehicleCategory;
                                //obj.purpose = vehicle.vehAvailCore.rentalRate.vehicleCharges.vehicleCharge[0].purpose;
                                obj.currencyCode = vehicle.vehAvailCore.totalCharge.currencyCode;
                                obj.estimatedTotalAmount = vehicle.vehAvailCore.totalCharge.estimatedTotalAmount.ToString();
                                obj.rateTotalAmount = vehicle.vehAvailCore.totalCharge.rateTotalAmount.ToString();
                                obj.passengerQty = request.noOfPassengers;
                                obj.country = request.country;

                                vehicleSearchResponse.vehicleData.Add(obj);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return vehicleSearchResponse;
        }

        public VehicleRentalConditionResponseModel GetRentalCondition(VehicleRentalConditionRequestModel request)
        {
            
            var rentalConditionRequest = new Model.VehicleRentalConditionRequest.VehicleRentalConditionRequestModel();
            var rentalConditionResponse = new VehicleRentalConditionResponseModel();
            try
            {

                rentalConditionRequest.vrct_RentalConditionsRQ = new Model.VehicleRentalConditionRequest.VrCt_Rentalconditionsrq();
                rentalConditionRequest.vrct_RentalConditionsRQ.POS = new Model.VehicleRentalConditionRequest.POS();
                rentalConditionRequest.vrct_RentalConditionsRQ.POS.Source = new Model.VehicleRentalConditionRequest.Source();
                rentalConditionRequest.vrct_RentalConditionsRQ.POS.Source.ISOCurrency = request.isoCurrency;
                rentalConditionRequest.vrct_RentalConditionsRQ.VehResRQCore = new Model.VehicleRentalConditionRequest.Vehresrqcore();
                rentalConditionRequest.vrct_RentalConditionsRQ.VehResRQCore.Customer = new Model.VehicleRentalConditionRequest.Customer();
                rentalConditionRequest.vrct_RentalConditionsRQ.VehResRQCore.Customer.Primary = new Model.VehicleRentalConditionRequest.Primary();
                rentalConditionRequest.vrct_RentalConditionsRQ.VehResRQCore.Customer.Primary.CitizenCountryName = new Model.VehicleRentalConditionRequest.Citizencountryname();
                rentalConditionRequest.vrct_RentalConditionsRQ.VehResRQCore.Customer.Primary.CitizenCountryName.Code = request.countryCode;
                rentalConditionRequest.vrct_RentalConditionsRQ.VehResRQCore.Status = "All";
                rentalConditionRequest.vrct_RentalConditionsRQ.VehResRQCore.VehRentalCore = new Model.VehicleRentalConditionRequest.Vehrentalcore();
                rentalConditionRequest.vrct_RentalConditionsRQ.VehResRQCore.VehRentalCore.PickUpDateTime = request.pickupDateTime;
                rentalConditionRequest.vrct_RentalConditionsRQ.VehResRQCore.VehRentalCore.PickUpLocation = new Model.VehicleRentalConditionRequest.Pickuplocation[1];
                rentalConditionRequest.vrct_RentalConditionsRQ.VehResRQCore.VehRentalCore.PickUpLocation[0] = new Model.VehicleRentalConditionRequest.Pickuplocation();
                rentalConditionRequest.vrct_RentalConditionsRQ.VehResRQCore.VehRentalCore.PickUpLocation[0].CodeContext = request.pickupCodeContext;
                rentalConditionRequest.vrct_RentalConditionsRQ.VehResRQCore.VehRentalCore.PickUpLocation[0].LocationCode = request.pickupLocationCode;
                rentalConditionRequest.vrct_RentalConditionsRQ.VehResRQCore.VehRentalCore.PickUpLocation[0].Name = request.pickupLocationName;
                rentalConditionRequest.vrct_RentalConditionsRQ.VehResRQCore.VehRentalCore.ReturnDateTime = request.returnDateTime;
                rentalConditionRequest.vrct_RentalConditionsRQ.VehResRQCore.VehRentalCore.ReturnLocation = new Model.VehicleRentalConditionRequest.Returnlocation();
                rentalConditionRequest.vrct_RentalConditionsRQ.VehResRQCore.VehRentalCore.ReturnLocation.CodeContext = request.returnCodeContext;
                rentalConditionRequest.vrct_RentalConditionsRQ.VehResRQCore.VehRentalCore.ReturnLocation.LocationCode = request.returnLocationCode;
                rentalConditionRequest.vrct_RentalConditionsRQ.VehResRQCore.VehRentalCore.ReturnLocation.Name = request.returnLocationName;
                rentalConditionRequest.vrct_RentalConditionsRQ.VehResRQInfo = new Model.VehicleRentalConditionRequest.Vehresrqinfo();
                rentalConditionRequest.vrct_RentalConditionsRQ.VehResRQInfo.Reference = new Model.VehicleRentalConditionRequest.Reference();
                rentalConditionRequest.vrct_RentalConditionsRQ.VehResRQInfo.Reference.DateTime = request.dateTime;
                rentalConditionRequest.vrct_RentalConditionsRQ.VehResRQInfo.Reference.ID = request.vehID;
                rentalConditionRequest.vrct_RentalConditionsRQ.VehResRQInfo.Reference.ID_Context = request.idContext;
                rentalConditionRequest.vrct_RentalConditionsRQ.VehResRQInfo.Reference.Type = request.vehType;
                rentalConditionRequest.vrct_RentalConditionsRQ.VehResRQInfo.Reference.URL = request.url;

                rentalConditionResponse.rentalConditionRequest = JsonConvert.SerializeObject(rentalConditionRequest);

                var output = Util.ServiceBridge<Model.VehicleRentalConditionRequest.VehicleRentalConditionRequestModel>.Run(rentalConditionRequest, ServiceTypes.RentalCondition, HttpMethod.Post);

                rentalConditionResponse.rentalConditionResponse = output;

                Model.VehicleRentalConditionResponse.VehicleRentalConditionResponseModel response;

                response = JsonConvert.DeserializeObject<Model.VehicleRentalConditionResponse.VehicleRentalConditionResponseModel>(output);

                rentalConditionResponse.rentalCondition = string.Empty;

                if (response != null)
                {
                    foreach(var section in response.ns10ctRentalConditionsRS.RentalConditions.SubSection)
                    {
                        if (section.Title!= null)
                        { 
                            rentalConditionResponse.rentalCondition = rentalConditionResponse.rentalCondition + section.Title + " - ";
                        }
                        if (section.Paragraph.Length != 0)
                        {
                            foreach (var paragraph in section.Paragraph)
                            {
                                rentalConditionResponse.rentalCondition = rentalConditionResponse.rentalCondition + paragraph.ToString() + "\n";
                            }
                        }
                        rentalConditionResponse.rentalCondition = rentalConditionResponse.rentalCondition + "\n";
                    }
                }


            }catch(Exception ex)
            {

            }
            return rentalConditionResponse;
        }
    }
}
