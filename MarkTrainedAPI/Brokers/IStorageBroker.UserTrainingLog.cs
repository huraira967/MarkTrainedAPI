using MarkTrainedAPI.Models.Brokers;

namespace StorageBrokers
{
    internal partial interface IStorageBroker
    {
        ValueTask<UserTrainingLog> InsertUserTrainingLog(UserTrainingLog userTrainingLog);
    }
}
