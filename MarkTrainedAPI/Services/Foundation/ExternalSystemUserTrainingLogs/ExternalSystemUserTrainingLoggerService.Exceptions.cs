using MarkTrainedAPI.Models.Brokers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkTrainedAPI.Services.Foundation.ExternalSystemUserTrainingLogs
{
    internal partial class ExternalSystemUserTrainingLoggerService
    {
        private delegate ValueTask<ExternalSystemUserTrainingLog> ReturningUserTrainingLoggerFunction();

        private async ValueTask<ExternalSystemUserTrainingLog> TryCatch(ReturningUserTrainingLoggerFunction returningUserTrainingLogFunction)
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
