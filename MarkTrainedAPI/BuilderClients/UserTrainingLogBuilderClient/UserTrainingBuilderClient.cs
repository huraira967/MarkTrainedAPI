using MarkTrainedAPI.Models.Brokers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkTrainedAPI.BuilderClients.UserTrainingLogBuilderClient
{
    internal class UserTrainingBuilderClient : IUserTrainingLogBuilderClient
    {
        public UserTrainingLog BuildSelfTrainedLog(UserTraining userTraining)
        {
            throw new NotImplementedException();
        }

        public UserTrainingLog BuildSupervisorTrainedLog(UserTraining userTraining)
        {
            throw new NotImplementedException();
        }
    }
}
