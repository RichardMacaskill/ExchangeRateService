using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExchangeRateService.Interfaces;

namespace ExchangeRateService.DataContracts
{
    public class ExchangeRate : IExchangeRate
    {
        public string Currency { get; set; }
        public DateTime AsOfDate { get; set; }
        public decimal CrossRate { get; set; }

    }
}
