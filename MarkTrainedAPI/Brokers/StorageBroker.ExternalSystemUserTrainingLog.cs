using MarkTrainedAPI.Models.Brokers;

namespace StorageBrokers
{
    internal partial class StorageBroker
    {
        //Db table
        //  public DbSet<ExternalSystemUserTrainingLog> ExternalSystemTrainingLogs { get; set; }
        public async ValueTask<ExternalSystemUserTrainingLog> InsertExternalSystemUserTrainingLog(
            ExternalSystemUserTrainingLog externalSystemTrainingLog) => await Insert(externalSystemTrainingLog);

    }
}
