using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRateService.Interfaces
{
    internal interface IExchangeRate
    {
        string Currency { get; set; }
        DateTime AsOfDate { get; set; }
        decimal CrossRate { get; set; }

    }
}
