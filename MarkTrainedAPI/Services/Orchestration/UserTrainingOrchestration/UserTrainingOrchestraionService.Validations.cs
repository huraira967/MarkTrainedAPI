using MarkTrainedAPI.Models.Brokers;
using MarkTrainedAPI.Models.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkTrainedAPI.Services.Orchestration
{
    internal partial class UserTrainingOrchestraionService
    {
       private static void ValidateAgainstPolicy(UserTrainingStatusChangeRequest userTrainingStatusChangeRequest
                                                    , TrainingPolicy trainingPolicy)
        {
            ValidateTrainingPolicyIsNotNull(trainingPolicy);
            ValidateUserTrainingStatusChangeRequestIsNotNull(userTrainingStatusChangeRequest);
            //all paramters will be pass here 
            //all models for exceptions needs to be created
        }
        public void ValidateAgainstFacilitySettings(UserTrainingStatusChangeRequest userTrainingStatusChangeRequest, FacilitySettings facilitySettings)
        {
            ValidateFacilitySettingsIsNotNull(facilitySettings);
            ValidateUserTrainingStatusChangeRequestIsNotNull(userTrainingStatusChangeRequest);
        }
        private static void ValidateFacilitySettingsIsNotNull(FacilitySettings facilitySettings)
        {
            if (facilitySettings is null)
            {
                throw new NoNullAllowedException();
            }
        }
        private static void ValidateTrainingPolicyIsNotNull(TrainingPolicy userTraining)
        {
            if (userTraining is null)
            {
                throw new NoNullAllowedException();
            }
        }
        private static void ValidateUserTrainingStatusChangeRequestIsNotNull(UserTrainingStatusChangeRequest userTrainingStatusChangeRequest)
        {
            if (userTrainingStatusChangeRequest is null)
            {
                throw new NoNullAllowedException();
            }
        }
        private static void Validate(params (dynamic Rule, string Parameter)[] validations)
        {
            var invalidExamException = new Exception();
            List<Exception> invalidExamExceptions = new List<Exception>();
            foreach ((dynamic rule, string parameter) in validations)
            {
                if (rule.Condition)
                {
                    invalidExamExceptions.Add(new Exception(rule.Message));
                }
            }

            throw invalidExamExceptions.FirstOrDefault();
        }
    }
}
