using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkTrainedAPI.Models.Controllers
{
    public class UserTrainingLogRequest
    {
        public DateTime TrainedOn { get; set; }
        public int Status { get; set; }
        public string TrainedBySystemId { get; set; }
        public string TrainedByExternalId { get; set; }
        public string TraineeSignature { get; set; }
        public string TrainerSignature { get; set; }
        public string Comment { get; set; }
        public DateTime ExternalTrainingDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Topics { get; set; }
    }
}
