using MarkTrainedAPI.Builders.UserTrainngBuilder;
using MarkTrainedAPI.Models.Brokers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkTrainedAPI.BuilderClients.UserTrainingBuilderClient
{
    internal class UserTrainingBuilderClient : IUserTrainngBuilderClient
    {
        private readonly IUserTrainingBuilder userTrainingBuilder;
        public UserTrainingBuilderClient()
        {
           
        }
        public UserTraining BuildSelfTrainedUserTrainining(UserTraining userTraining)
        {
            //... set properties for self trained here
            return userTrainingBuilder.GetUserTraining();
        }
        public UserTraining BuildTrainedUserTraining1(UserTraining userTraining)
        {
            //.. set properties here for that type 
            return userTrainingBuilder.GetUserTraining();
        }
        //.. other methods for specific need will be here
    }
}
