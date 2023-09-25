using MarkTrainedAPI.Models.Brokers;
using StorageBrokers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkTrainedAPI.Services.Foundation.UserTrainingLogs 
{ 
    internal partial class UserTrainingLoggerService : IUserTrainingLoggerService
    {
        private readonly StorageBroker storageBroker;

        public UserTrainingLoggerService(StorageBroker storageBroker)
        {
            this.storageBroker = storageBroker;
        }

        public ValueTask<UserTrainingLog> UpSertUserTrainingLog(UserTrainingLog userTrainingLog) =>
            TryCatch(async () =>
            {
                ValidateUserTrainingLog(userTrainingLog);
                return await this.storageBroker.InsertUserTrainingLog(userTrainingLog);
            });

    }
}
