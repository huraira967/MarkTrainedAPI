using MarkTrainedAPI.Models.Brokers;
using MarkTrainedAPI.Models.Controllers;
using MarkTrainedAPI.Services.Management.UserTrainingManagementService;
using StorageBrokers;
using System.ComponentModel;
using System.Data;

namespace MarkTrainedAPI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserTrainingStatusChangeRequest request = new UserTrainingStatusChangeRequest();
            IUserTrainingManagementService managementService = new UserTrainingManagementService();
            managementService.SaveUserTraining(request);
            Console.WriteLine("Hello, World!");
        }
    }
}
