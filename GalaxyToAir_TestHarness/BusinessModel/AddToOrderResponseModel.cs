using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaxyToAir_TestHarness.Model;
/****************************** Module Header ******************************\
Module Name     :   AddToOrderResponseModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas


Business model for Add to order response
\***************************************************************************/
namespace GalaxyToAir_TestHarness.BusinessModel
{
    public class AddToOrderResponseModel
    {
        public string addToCartRequest { get; set; }
        public string addToCartResponse { get; set; }
        public OrderData orderData;
    }

    public class OrderData
    {
        public int orderId { get; set; }
        public int externalOrderId { get; set; }
        public int externalOrderHash { get; set; }
        public int vehicleQuoteId { get; set; }
        public string pricingCurrency { get; set; }
        public float vehicletotalPrice { get; set; }
        public int airQuoteId { get; set; }
        public float airtotalPrice { get; set; }
        public int airMainId { get; set; }
        public string flightSegment { get; set; }
        public int insuranceQuoteId { get; set; }
        public int insuranceTotalPrice { get; set; }
        public int insurancePlanID { get; set; }
        public string insuranceProductCode { get; set; }
        public string driverAge { get; set; }
        public string tripCost { get; set; }
        public string airlineId { get; set; }
        public bool airlineOrderAvailable { get; set; }
        public bool vehicleOrderAvailable { get; set; }
        public bool insuranceOrderAvailable { get; set; }
    }
}
