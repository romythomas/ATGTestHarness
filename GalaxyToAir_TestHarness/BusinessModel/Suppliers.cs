using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/****************************** Module Header ******************************\
Module Name     :   Suppliers.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas


Business model for suppliers
\***************************************************************************/
namespace GalaxyToAir_TestHarness.BusinessModel
{

    public class Suppliers
    {
        public Supplierlist[] supplierList { get; set; }
    }

    public class Supplierlist
    {
        public string code { get; set; }
        public string name { get; set; }
    }

}
