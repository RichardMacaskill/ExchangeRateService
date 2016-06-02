using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Text;
using ExchangeRateService.DataContracts;
using static System.Char;
using static System.Configuration.ConfigurationSettings;

//using System.Data.Linq;


namespace ExchangeRateService.Services
{
    public class DataService
    {
        private readonly string _forex;

        public DataService()
        {
            _forex = AppSettings["Forex"];
        }

        private const string Getexrate = "GetRates_ForISO";

        public List<ExchangeRate> GetExchangeRates(string isoCode, DateTime asOfDate)
        {
            var retval = new List<ExchangeRate>();

            using (var conn = new SqlConnection(_forex))
            {
                try
                {
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        var cmd = new SqlCommand(Getexrate, conn) {CommandType = CommandType.StoredProcedure};
                        cmd.Parameters.Add(new SqlParameter("@ISO", isoCode));
                        cmd.Parameters.Add(new SqlParameter("@AsOfDate", asOfDate));

                        using (var rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                
                                retval.Add(new ExchangeRate()
                                {
                                    Currency = rdr.GetString(0),
                                    AsOfDate = rdr.GetDateTime(1),
                                    CrossRate = Convert.ToDecimal( rdr.GetValue(2))
                                }
                                );
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                   Console.WriteLine(ex.Message);
                }
            }
            return retval;
        }

        /*

            Get DB Size

        */  
        public string GetDatabaseSize()
        {
            string retval = null;

            using (var conn = new SqlConnection(_forex))
            {
                try
                {
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        var cmd = new SqlCommand(Getexrate, conn)
                        {
                            CommandType = CommandType.Text,
                            CommandText =
                                "SELECT DB_NAME() AS DbName, sum(size) / 128.0 AS File_Size_MB from sys.database_files  where type = 0 group by type "
                        };

                        using (var rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {

                                retval  =  rdr.GetString(1);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return retval;
        }

    }
}
