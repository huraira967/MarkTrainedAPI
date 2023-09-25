using MarkTrainedAPI.Models.Brokers;
using StorageBrokers;

namespace MarkTrainedAPI.Services.Foundation.ExternalSystemUserTrainingLogs
{
    internal partial class ExternalSystemUserTrainingLoggerService : IExternalSystemUserTrainingLoggerService
    {
        private readonly StorageBroker storageBroker;

        public ExternalSystemUserTrainingLoggerService(StorageBroker storageBroker)
        {
            this.storageBroker = storageBroker;
        }

        public ValueTask<ExternalSystemUserTrainingLog> UpSertExternalSystemUserTrainingLog(ExternalSystemUserTrainingLog userTrainingLog) =>
            TryCatch(async () =>
            {
                ValidateUserTrainingLog(userTrainingLog);
                return await this.storageBroker.InsertExternalSystemUserTrainingLog(userTrainingLog);
            });

    }
}
