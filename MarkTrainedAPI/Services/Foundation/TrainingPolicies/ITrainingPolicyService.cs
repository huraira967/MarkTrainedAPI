using MarkTrainedAPI.Models.Brokers;

namespace MarkTrainedAPI.Services.Foundation.TrainingPolicies
{
    internal interface ITrainingPolicyService
    {
        ValueTask<TrainingPolicy> GetTrainingPolicyByPolicyId(int trainingPolicyId);
        ValueTask<TrainingPolicy> GetTrainingPolicyByTrainingId(int trainingId);
    }
}
