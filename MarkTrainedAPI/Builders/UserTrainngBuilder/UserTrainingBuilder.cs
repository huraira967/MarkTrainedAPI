using MarkTrainedAPI.Configurations.Enums;
using MarkTrainedAPI.Models.Brokers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkTrainedAPI.Builders.UserTrainngBuilder
{
    internal class UserTrainingBuilder : IUserTrainingBuilder
    {
        public UserTrainingBuilder()
        {
            this.userTraining = new UserTraining();
        }
        public UserTrainingBuilder(UserTraining userTraining)
        {
            this.userTraining = userTraining;
        }
        private UserTraining userTraining { get; set; }

        public UserTraining GetUserTraining()
        {
            throw new NotImplementedException();
        }

        public IUserTrainingBuilder SetLastTrainedOnDate(DateTime lastTrainedOnDate)
        {
            throw new NotImplementedException();
        }

        public IUserTrainingBuilder SetStatus(TrainingStatus status)
        {
            throw new NotImplementedException();
        }

        public IUserTrainingBuilder SetTrainedOnDate(DateTime? trainedOnDate)
        {
            throw new NotImplementedException();
        }

        public IUserTrainingBuilder SetWhoMarkTrained(List<string> markTrainedIds)
        {
            throw new NotImplementedException();
        }
    }
}
