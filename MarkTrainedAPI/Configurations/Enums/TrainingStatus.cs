using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkTrainedAPI.Configurations.Enums
{
    internal enum TrainingStatus
    {
        StaffScreen = 1,
        TraineeLog = 2,
        DayCheckInOut = 3,
        DayClassClose = 4,
        TrainingClassManagement = 5,
        TrainingClassManagementClassCanceled = 6,
        QuizzesLog = 7,
        ByExternalSystemRelias = 8,
        ByExternalSystemOFL = 9,
        Topyx = 10,
        iCMService = 100
        //... other statuses
    }
}
