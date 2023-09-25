using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkTrainedAPI.Models.Controllers
{
    public class UserTrainingStatusRequest
    {
        public int UserTrainingId { get; set; }
        public int StaffId { get; set; }
        public int ActualTrainingId { get; set; }
        public int ParentTrainingId { get; set; }
        public int DocId { get; set; }
    }
}
