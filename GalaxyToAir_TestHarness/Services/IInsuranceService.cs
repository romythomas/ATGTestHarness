using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaxyToAir_TestHarness.BusinessModel;
/****************************** Module Header ******************************\
Module Name     :   IInsuranceService.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas

Interface for Insurance Service
\***************************************************************************/
namespace GalaxyToAir_TestHarness.Services
{
    public interface IInsuranceService
    {
        InsuranceSearchResponseModel GetInsuranceDetails(InsuranceSearchModel request);
    }
}
