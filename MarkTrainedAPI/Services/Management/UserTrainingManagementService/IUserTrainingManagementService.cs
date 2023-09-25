using MarkTrainedAPI.Models.Brokers;
using MarkTrainedAPI.Models.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkTrainedAPI.Services.Management.UserTrainingManagementService
{
    internal interface IUserTrainingManagementService
    {
        ValueTask<UserTrainingStatusChangeRequest> SaveUserTraining(UserTrainingStatusChangeRequest userTraining);
    }
}
