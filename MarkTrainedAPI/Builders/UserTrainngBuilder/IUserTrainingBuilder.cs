using MarkTrainedAPI.Configurations.Enums;
using MarkTrainedAPI.Models.Brokers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkTrainedAPI.Builders.UserTrainngBuilder
{
    internal interface IUserTrainingBuilder
    {

        public IUserTrainingBuilder SetWhoMarkTrained(List<string> markTrainedIds);
        public IUserTrainingBuilder SetLastTrainedOnDate(DateTime lastTrainedOnDate);
        public IUserTrainingBuilder SetTrainedOnDate(DateTime? trainedOnDate);
        public IUserTrainingBuilder SetStatus(TrainingStatus status);
        public UserTraining GetUserTraining();
    }
}
