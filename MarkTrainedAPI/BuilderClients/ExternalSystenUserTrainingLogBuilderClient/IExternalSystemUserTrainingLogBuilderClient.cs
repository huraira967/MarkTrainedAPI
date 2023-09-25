using MarkTrainedAPI.Models.Brokers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkTrainedAPI.BuilderClients.ExternalSystenUserTrainingLogBuilderClient
{
    internal interface IExternalSystemUserTrainingLogBuilderClient
    {
        ExternalSystemUserTrainingLog BuildReliseUserTrainingLog(UserTraining userTrainingLog);
        ExternalSystemUserTrainingLog BuildTopyxUserTrainingLog(UserTraining userTrainingLog);
    }
}
