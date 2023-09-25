using MarkTrainedAPI.Models.Brokers;

namespace MarkTrainedAPI.Services.Foundation.UserTrainingLogs
{
    internal partial class UserTrainingLoggerService
    {
        private delegate ValueTask<UserTrainingLog> ReturningUserTrainingLoggerFunction();

        private async ValueTask<UserTrainingLog> TryCatch(ReturningUserTrainingLoggerFunction returningUserTrainingLogFunction)
        {
            try
            {
                return await returningUserTrainingLogFunction();
            }
            catch (Exception exception)
            {
                throw;
            }
        }
    }
}
