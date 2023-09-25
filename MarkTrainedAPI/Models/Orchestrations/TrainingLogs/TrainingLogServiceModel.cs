using MarkTrainedAPI.Models.Brokers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkTrainedAPI.Models.Orchestrations.TrainingLogs
{
    public class TrainingLogServiceModel
    {
        public UserTrainingLog UserTrainingLog { get; set; }
        public ExternalSystemUserTrainingLog ExternalSystemUserTraining { get; set; }
        public int Type { get; set; }
    }
}
