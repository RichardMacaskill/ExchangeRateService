using System;
using System.Data;
using System.Data.SqlClient;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace ExchangeRateService.Tests
{
    [TestFixture]
    public class AwTestFixture
    {
        private const string ConnectionString = "Data Source=.\\dev;Initial Catalog=_AW2014Clone;Integrated Security=true;";

        [OneTimeSetUp]
        public void AwTestFixtureSetUp()
        {
            // Create a snapshot of AW
           // CustomerAPI.InstantClone.Snapshot("AW2014Snap", "AwSnap");
        }

        [OneTimeTearDown]
        public void AwTestFixtureTearDown()
        {
            // Create a snapshot of AW
            //CustomerAPI.InstantClone.DropSnapshot("AdventureWorks", "AwSnap");
        }

        [SetUp]
        public void TestSetUp()
        {
            try
            {
                // Create AW clone before every test
                Tests.InstantClone.Clone("AW2014Snap", "_AW2014Clone");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [TearDown]
        public void TestTearDown()
        {
            // If there's been a failure, snapshot the database for later analysis
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                string cloneSnapName =
                    $"AwTest_{TestContext.CurrentContext.Test.MethodName}_{DateTime.Now.ToString("yyyy-MM-ddTHHmmss")}";
                ExchangeRateService.Tests.InstantClone.Snapshot("_AW2014Clone", cloneSnapName);
            }

            // Drop AW clone after every test
            ExchangeRateService.Tests.InstantClone.DropClone("_AW2014Clone");
        }
        
        [Test]
        public void DiscountPctIsCorrect()
        {
            RunNonQuery("INSERT INTO Sales.SpecialOffer VALUES ( 'TwentyPercentOff', 0.20, 'Seasonal Discount', 'Customer','2015-01-01', '2016-01-01', 5, 12, NEWID(), GETDATE())");
            Decimal discountPct = (Decimal)RunScalar("SELECT DiscountPct FROM Sales.SpecialOffer WHERE Description = 'TwentyPercentOff'");
            Assert.AreEqual(0.2, discountPct);
        }

        [Test]
        public void FortyPcDiscountIsBest()
        {
            RunNonQuery("INSERT INTO Sales.SpecialOffer VALUES ( 'HalfPrice', 0.40, 'Seasonal Discount', 'Customer','2015-01-01', '2016-01-01', 0, 12, NEWID(), GETDATE())");
            Decimal discountPct = (Decimal)RunScalar("SELECT TOP 1 DiscountPct FROM Sales.SpecialOffer ORDER BY DiscountPct DESC");
            Assert.AreEqual(0.4, discountPct);
        }

        private void RunNonQuery(string queryText)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var cmd = new SqlCommand(queryText, connection);
                cmd.ExecuteNonQuery();
            }
        }
        private object RunScalar(string queryText)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var cmd = new SqlCommand(queryText, connection);
                return cmd.ExecuteScalar();
            }
        }
    }
}
