using MarkTrainedAPI.Models.Controllers;
using MarkTrainedAPI.Services.Orchestration.TrainingLogOrchestration;
using MarkTrainedAPI.Services.Orchestration.UserTrainingOrchestration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkTrainedAPI.Services.Management.UserTrainingManagementService
{
    internal partial class UserTrainingManagementService : IUserTrainingManagementService
    {
        public IUserTrainingOrchestrationService UserTrainingOrchestrationService { get; set; }
        public ITrainingLogOrchestrationService TrainingLogOrchestrationService { get; set; }
        public ValueTask<UserTrainingStatusChangeRequest> SaveUserTraining(UserTrainingStatusChangeRequest userTraining)
        {
            UserTrainingOrchestrationService.ChangeUserTrainingStatus(userTraining);
            TrainingLogOrchestrationService.SaveTrainingLog(userTraining);
            return new ValueTask<UserTrainingStatusChangeRequest>();
        }
    }
}
