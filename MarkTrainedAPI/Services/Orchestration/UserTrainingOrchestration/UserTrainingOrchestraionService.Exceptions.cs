using MarkTrainedAPI.Models.Brokers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkTrainedAPI.Services.Orchestration
{
    internal partial class UserTrainingOrchestraionService
    {
        internal delegate ValueTask<UserTraining> ReturningUserTrainingFunction();
        public async ValueTask<UserTraining> TryCatch(ReturningUserTrainingFunction returningUserTrainingFunction)
        {
            try
            {
                return await returningUserTrainingFunction();

            }
            catch (Exception ex)
            {
                throw;
            }
            
        }
    }
}
