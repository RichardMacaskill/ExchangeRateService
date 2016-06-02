using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Management.Automation;
using System.Collections.ObjectModel;
using System.Management.Automation.Runspaces;
using ExchangeRateService.DataContracts;
using ExchangeRateService.Services;
using ExchangeRateService.Tools;

namespace ExchangeRateService
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Going to do some stuff.");

            var dataSvc = new ExchangeRateService.Services.DataService();

            //var dbSize = dataSvc.GetDatabaseSize();
            //Console.WriteLine("Found db size of {0}", dbSize);

            var ratesData = dataSvc.GetExchangeRates("EUR", DateTime.Now);
            foreach (var ex in ratesData)
            {
                Console.WriteLine("Found rate of {0} for currency {1} as of {2}",ex.CrossRate,ex.Currency,ex.AsOfDate);
            }
            
            Console.WriteLine("Did some stuff. Press key to exit.");
            Console.ReadLine();
        }
       
    }
}
