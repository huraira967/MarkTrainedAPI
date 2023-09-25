using MarkTrainedAPI.Models.Brokers;
using System.Runtime.InteropServices;

namespace Services.Foundation.UserTrainings
{
    internal partial class UserTrainingService : IUserTrainingService
    {
        public ValueTask<UserTraining> GetUserTraining(int userTrainingId) =>
            TryCatch(async () =>
            {
                var storageBroker = new StorageBrokers.StorageBroker();
               return await storageBroker.GetUserTrainingAsync(userTrainingId);
            });
        

        public ValueTask<UserTraining> UpsertUserTraining(UserTraining userTraining) =>
            TryCatch(async () =>
            {
                var storageBroker = new StorageBrokers.StorageBroker();
                ValidateUserTraining(userTraining);
               return await storageBroker.InsertUserTraining(userTraining);
            });
    }
}
internal class MarkTrainedClient
{
    void MarkTrained(UserTraining userTraining)
    {

    }
}
internal class MarkTrainedOrchestratorService
{

}
internal class TrainingClassService
{

}
internal class TraingClassTopicsService
{

}
internal class QuizService
{

}

internal class TrainingMaterialService
{

}

internal class ExternalMaterialService
{




}






















