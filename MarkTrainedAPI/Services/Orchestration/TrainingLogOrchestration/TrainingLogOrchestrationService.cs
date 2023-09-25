using MarkTrainedAPI.Models.Controllers;
using MarkTrainedAPI.Models.Orchestrations.TrainingLogs;
using MarkTrainedAPI.Services.Foundation.ExternalSystemUserTrainingLogs;
using MarkTrainedAPI.Services.Foundation.UserTrainingLogs;
using Services.Foundation.UserTrainings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkTrainedAPI.Services.Orchestration.TrainingLogOrchestration
{
    internal partial class TrainingLogOrchestrationService : ITrainingLogOrchestrationService
    {
        public IUserTrainingService userTrainingLogService { get; set; }
        public IExternalSystemUserTrainingLoggerService externalSystemUserTrainingLoggerService { get; set; }
        public IUserTrainingLoggerService userTrainingLoggerService { get; set; }

        public TrainingLogOrchestrationService(IUserTrainingLoggerService userTrainingLoggerService
            , IExternalSystemUserTrainingLoggerService externalSystemUserTrainingLoggerService)
        {
            this.userTrainingLoggerService = userTrainingLoggerService;
            this.externalSystemUserTrainingLoggerService = externalSystemUserTrainingLoggerService;
        }

        public ValueTask<UserTrainingStatusChangeRequest> SaveTrainingLog(UserTrainingStatusChangeRequest trainingLog)
        {
            switch (trainingLog.WorkScreen)
            {
                case 0:
                    return new ValueTask<UserTrainingStatusChangeRequest>();
                case 1: 
                    return new ValueTask<UserTrainingStatusChangeRequest>();
                default: 
                    return new ValueTask<UserTrainingStatusChangeRequest>();
            }
        }
    }
}
