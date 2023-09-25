using MarkTrainedAPI.Models.Brokers;

namespace MarkTrainedAPI.Brokers
{
    internal interface IStorageBroker
    {
       ValueTask<UserTraining> InsertUserTraining(UserTraining userTraining);
        ValueTask<UserTraining> GetUserTrainingAsync(int id);
    }
}
