using MarkTrainedAPI.Models.Brokers;
using MarkTrainedAPI.Models.Controllers;

namespace MarkTrainedAPI.Clients.UserTrainingClient
{
    internal class TrainingClient : ITrainingClient
    {
        public object TrainingPolicyService { get; set; }
        public object FacilitySettingsService { get; set; }
        public object SignaureService { get; set; }
        public object UserTrainingService { get; set; }
        public object FacilityTrainingService { get; set; }
        public object UserTrainingLogService { get; set; }
        public object ExternalSystemUserTrainingLogService { get; set; }
        public UserTraining UpdateUserTraining(UserTrainingStatusChangeRequest userTrainingStatusChangeRequest)
        {
            this.UserTrainingService.UpdateUserTraining(userTrainingStatusChangeRequest);
        }
    }
}
