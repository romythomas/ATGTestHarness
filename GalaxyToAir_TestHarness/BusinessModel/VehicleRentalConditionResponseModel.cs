using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/****************************** Module Header ******************************\
Module Name     :   VehicleRentalConditionResponseModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas


Business model for rental condition response
\***************************************************************************/
namespace GalaxyToAir_TestHarness.BusinessModel
{
    public class VehicleRentalConditionResponseModel
    {
        public string rentalConditionRequest { get; set; }
        public string rentalConditionResponse { get; set; }
        public string rentalCondition { get; set; }
    }
}
