using System;
using System.Threading.Tasks;
using Autofac;
using RedGate.InstantClone.Services.Clone;
using RedGate.InstantClone.Services.Config;
using RedGate.InstantClone.Services.Snapshot;
using RedGate.InstantClone.Startup;

namespace ExchangeRateService.Tests
{
    public class InstantClone
    {
        static InstantClone()
        {
            // Set up Instant Clone
            var container = new InstantCloneSetup();
            
            ConfigService = container.Resolve<IConfigService>();
            SnapshotService = container.Resolve<ISnapshotService>();
            CloneService = container.Resolve<ICloneService>();
        }
        
        private static ICloneService CloneService { get; set; }
        private static ISnapshotService SnapshotService { get; set; }
        private static IConfigService ConfigService { get;  set; }

        public static void Clone(string snapshotName, string newDbName)
        {
            var snapshot = SnapshotService.GetSnapshotWithName(snapshotName);
            if (snapshot == null) throw new ApplicationException($"Unable to find snapshot {snapshotName}");

            var config = ConfigService.GetCurrentConfiguration();
            
            AwaitTaskAndHandleErrors(CloneService.CreateClone(snapshot, config.DefaultConnectionId, newDbName, config.CloneDirectory));
        }

        public static void Snapshot(string dbName, string snapshotName)
        {
            var config = ConfigService.GetCurrentConfiguration();

            AwaitTaskAndHandleErrors(SnapshotService.PerformSnapshot(config.DefaultConnectionId, dbName, snapshotName, config.SnapshotDirectory));
        }

        public static void DropClone(string dbName)
        {
            var config = ConfigService.GetCurrentConfiguration();

            var clone = CloneService.GetCloneWithDatabaseName(dbName);
            if (clone == null) throw new ApplicationException($"Unable to find clone {dbName}");

            AwaitTaskAndHandleErrors(CloneService.DropClone(clone.CloneId, false));
        }

        private static void AwaitTaskAndHandleErrors(Task<bool> action)
        {
            try
            {
                action.Wait();

                if (action.IsFaulted)
                {
                    if (action.Exception == null)
                    {
                        throw new Exception("Null task exception despite faulting.");
                    }

                    foreach (Exception e in action.Exception.InnerExceptions)
                    {
                        throw e.InnerException ?? e;
                    }
                }
            }
            catch (AggregateException aggregateException)
            {
                foreach (var e in aggregateException.InnerExceptions)
                {
                    throw e.InnerException ?? e;
                }
            }
        }
    }
}
