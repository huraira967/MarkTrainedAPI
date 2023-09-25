using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkTrainedAPI.Models.Brokers
{
    internal class StaffTrainingExam
    {
        public int Id { get; set; }
        public int StaffId { get; set; }
        public int ExamId { get; set; }
        public int TrainingId { get; set; }
        public int UserTrainingId { get; set; }
    }
}
