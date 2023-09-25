using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkTrainedAPI.Models.Controllers
{
    public class UserTrainingStatusChangeRequest
    {
        public int FacilityId { get; set; } 
        public bool IsBulk { get; set; }
        public int WorkScreen { get; set; }
        public UserTrainingLogRequest UserTrainingLogRequest { get; set; }
        public UserTrainingSessionLogRequest UserTrainingSessionLogRequest { get; set; }
        public UserTrainingStatusRequest UserTrainingStatusRequest { get;set;}
    }
}
