using MarkTrainedAPI.Models.Brokers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkTrainedAPI.Services.Foundation.UserTrainingLogs
{
    internal interface IUserTrainingLoggerService
    {
        ValueTask<UserTrainingLog> UpSertUserTrainingLog(UserTrainingLog userTrainingLog);
    }
}
