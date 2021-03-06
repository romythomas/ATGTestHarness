﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
/****************************** Module Header ******************************\
Module Name     :   GetCurrencyResponseModel.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas


JSON class for currency list
\***************************************************************************/
namespace GalaxyToAir_TestHarness.Model.GetCurrency
{
   
    public class GetCurrencyResponseModel
    {
        [JsonProperty("ns9.MasterRS")]
        public Ns9Masterrs ns9MasterRS { get; set; }
    }

    public class Ns9Masterrs
    {
        public string transactionStatus { get; set; }
        [JsonProperty("ns9.currencyList")]
        public Ns9Currencylist[] ns9currencyList { get; set; }
    }

    public class Ns9Currencylist
    {
        [JsonProperty("ns9.code")]
        public string ns9code { get; set; }
        [JsonProperty("ns9.name")]
        public string ns9name { get; set; }
    }

}
