using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaxyToAir_TestHarness.BusinessModel;
/****************************** Module Header ******************************\
Module Name     :   IOrderService.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas

Interface for Order Service
\***************************************************************************/
namespace GalaxyToAir_TestHarness.Services
{
    public interface IOrderService
    {
        AddToOrderResponseModel AddToOrder(AddToOrderRequestModel request);
    }
}
