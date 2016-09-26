using System;
using System.Collections.Generic;
using System.Text;
using NUnit;
using NUnit.Framework;
using System.Configuration;
using System.Diagnostics;
using ExchangeRateService.Services;

namespace ExchangeRateService.Tests
{
    [TestFixture]
    public class DataIsPopulated
    {
        [Test]
        public void GetLatestEurRateSucceedsWithData()
        {
            var dataSvc = new ExchangeRateService.Services.DataService();
            var ex = dataSvc.GetExchangeRates("EUR", DateTime.Now);
            // Debug.WriteLine("Found rate of {0} for currency {1} as of {2}", ex[0].CrossRate, ex[0].Currency, ex[0].AsOfDate);
            Assert.IsNotNull(ex);
            
        }
        [Test]
        public void GetGarbageRateSucceedsWithNoData()
        { 
            var dataSvc = new ExchangeRateService.Services.DataService();
            var ex = dataSvc.GetExchangeRates("$$$££££$$", DateTime.Now);
            // the correct behaviour is to return empty dataset for invalid ISO. Should it be?
            Assert.AreEqual(ex.Count, 0);
            //Assert.Throws<ArgumentOutOfRangeException>( (ex[0].Currency) );
        }
    }

}