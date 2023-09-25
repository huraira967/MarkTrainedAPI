using MarkTrainedAPI.Builders.UserTrainngBuilder;
using MarkTrainedAPI.Models.Brokers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkTrainedAPI.BuilderClients.UserTrainingBuilderClient
{
    internal interface IUserTrainngBuilderClient
    {
        public UserTraining BuildSelfTrainedUserTrainining(UserTraining userTraining);
        public UserTraining BuildTrainedUserTraining1(UserTraining userTraining);
    }
}
