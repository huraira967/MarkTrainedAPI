using MarkTrainedAPI.Models.Brokers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkTrainedAPI.Services.Foundation.ExternalSystemUserTrainingLogs
{
    internal interface IExternalSystemUserTrainingLoggerService
    {
        ValueTask<ExternalSystemUserTrainingLog> UpSertExternalSystemUserTrainingLog(ExternalSystemUserTrainingLog userTrainingLog);
    }
}
