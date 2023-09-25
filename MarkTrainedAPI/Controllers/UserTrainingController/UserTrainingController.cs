using MarkTrainedAPI.Clients.UserTrainingClient;
using MarkTrainedAPI.Models.Brokers;
using MarkTrainedAPI.Models.Controllers;
using System.Web.Http;

namespace MarkTrainedAPI.Controllers.UserTrainingController
{
    [Route("userTraining")]
    public class UserTrainingController
    {
        [HttpPost]
        [Route("log/update")]
        public object ChangeUserTrainingStatus(UserTrainingStatusChangeRequest userTrainingStatusChangeRequest)
        {
            object UserTrainingClient = new object();

            return null;
        }
        //[HttpPost]
        //[Route("change/status/multiple")]
        //public object MarkTrainedMultiple(ChangeStatusMultiple userTraining)
        //{
        //    IUserTrainingClient UserTrainingClient = new UserTrainingClient();



        //    return null;
        //}
        //[HttpPost]
        //[Route("export")]
        //public object ExportMarkTrained(ExportStatusChange userTraining)
        //{
        //    return null;
        //}
    }
}
