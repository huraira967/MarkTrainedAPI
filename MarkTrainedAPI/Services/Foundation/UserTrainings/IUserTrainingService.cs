using MarkTrainedAPI.Models.Brokers;

namespace Services.Foundation.UserTrainings
{
    internal interface IUserTrainingService
    {
        ValueTask<UserTraining> UpsertUserTraining(UserTraining userTraining);
        ValueTask<UserTraining> GetUserTraining(int userTrainingId);
    }
}
