using MarkTrainedAPI.Models.Brokers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkTrainedAPI.Services.Foundation.TrainingPolicies
{
    internal partial class TrainingPolicyService
    {
        public delegate ValueTask<TrainingPolicy> ReturningTrainingPolicyDelegate();
        public async ValueTask<TrainingPolicy> TryCatch(ReturningTrainingPolicyDelegate policy)
        {
            try
            {
                return await policy();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
