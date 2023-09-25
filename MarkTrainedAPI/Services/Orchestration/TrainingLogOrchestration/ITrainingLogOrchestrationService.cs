using MarkTrainedAPI.Models.Controllers;
using MarkTrainedAPI.Models.Orchestrations.TrainingLogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkTrainedAPI.Services.Orchestration.TrainingLogOrchestration
{
    internal interface ITrainingLogOrchestrationService
    {
        ValueTask<UserTrainingStatusChangeRequest> SaveTrainingLog(UserTrainingStatusChangeRequest trainingLog);
    }
}
