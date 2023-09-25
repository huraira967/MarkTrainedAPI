using MarkTrainedAPI.Models.Brokers;

namespace StorageBrokers
{
    internal partial class StorageBroker
    {
        public async ValueTask<UserTraining> InsertUserTraining(UserTraining userTraining)
            => await Insert(userTraining);
        public async ValueTask<UserTraining> GetUserTrainingAsync(int userTrainingId) =>
            await GetAsync<UserTraining>(userTrainingId);
    }
}
