using MarkTrainedAPI.Models.Brokers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkTrainedAPI.BuilderClients.UserTrainingLogBuilderClient
{
    internal interface IUserTrainingLogBuilderClient
    {
        UserTrainingLog BuildSelfTrainedLog(UserTraining userTraining);
        UserTrainingLog BuildSupervisorTrainedLog(UserTraining userTraining);
    }
}
