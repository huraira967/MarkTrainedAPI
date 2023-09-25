using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkTrainedAPI.Models.Controllers
{
    public class UserTrainingSessionLogRequest
    {
        public int NewSessionId { get; set; }
        public int SessionStatus { get; set; }
        public string SessionCancelReason { get; set; }
        public string SessionChangeReason { get; set; }
        public int OldSessionId { get; set; }
        public bool IsWaitListed { get; set; }
    }
}
