using MarkTrainedAPI.Models.Brokers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkTrainedAPI.Services.Foundation.TrainingPolicies
{
    internal partial class TrainingPolicyService : ITrainingPolicyService
    {
        public ValueTask<TrainingPolicy> GetTrainingPolicyByPolicyId(int trainingPolicyId) => 
            TryCatch(async () =>
            {
                   return  await new ValueTask<TrainingPolicy>();
            });



        public ValueTask<TrainingPolicy> GetTrainingPolicyByTrainingId(int trainingId) =>
            TryCatch(async () =>
            {
                return await new ValueTask<TrainingPolicy>();
            });
       
    }
}
