using MarkTrainedAPI.Models.Brokers;

namespace StorageBrokers
{
    internal partial interface IStorageBroker
    {
        ValueTask<ExternalSystemUserTrainingLog> InsertExternalSystemUserTrainingLog(
            ExternalSystemUserTrainingLog externalSystemTrainingLog);
    }
}
