using MarkTrainedAPI.Models.Brokers;

namespace Services.Foundation.UserTrainings
{
    internal partial class UserTrainingService
    {
        private delegate ValueTask<UserTraining> ReturningUserTrainingFunction();
        private async ValueTask<UserTraining> TryCatch(ReturningUserTrainingFunction returningUserTrainingFunction)
        {
            try
            {
                return await returningUserTrainingFunction();
            }
            catch (Exception exception)
            {
                throw;
            }
        }
    }
}
