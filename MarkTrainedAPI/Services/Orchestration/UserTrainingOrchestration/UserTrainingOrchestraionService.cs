using MarkTrainedAPI.BuilderClients.FilePathBuilderClient;
using MarkTrainedAPI.Models.Brokers;
using MarkTrainedAPI.Models.Controllers;
using MarkTrainedAPI.Services.Foundation.FacilitySettings;
using MarkTrainedAPI.Services.Foundation.Signatures;
using MarkTrainedAPI.Services.Foundation.TrainingPolicies;
using MarkTrainedAPI.Services.Foundation.UserService;

namespace MarkTrainedAPI.Services.Orchestration
{
    internal partial class UserTrainingOrchestraionService : IUserTrainingOrchestrationService
    {
        private readonly ITrainingPolicyService trainingPolicyService;
        private readonly IFacilitySettingsService facilitySettingsService;
        private readonly ISignatureService signatureService;
        private readonly IFilePathBuilderClient pathBuilderClient;
        private readonly IUserService userService;

        public UserTrainingOrchestraionService(ITrainingPolicyService trainingPolicy,
            IFacilitySettingsService facilitySettingsService, ISignatureService signatureService,
            IFilePathBuilderClient filePathBuilder, IUserService userService)
        {
            this.trainingPolicyService = trainingPolicy;
            this.facilitySettingsService = facilitySettingsService;
            this.signatureService = signatureService;
            this.pathBuilderClient = filePathBuilder;
            this.userService = userService;
        }

        public ValueTask<UserTraining> ChangeUserTrainingStatus(UserTrainingStatusChangeRequest userTrainingStatusChangeRequest) =>
            TryCatch(async () =>
            {
                var traininhId = GetTrainingId(userTrainingStatusChangeRequest);
                var trainingPolicy = await trainingPolicyService.GetTrainingPolicyByTrainingId(traininhId);

                if (ShouldGetTrainerSignatureFromProfile(userTrainingStatusChangeRequest))
                {
                    var trainerSignature = this.userService.GetUesrSignature(90);

                    string filePath = pathBuilderClient.GetAwsFilePath();
                    await this.signatureService.UploadFile(filePath, new byte[90]);
                }
                if (ShouldValidateAgainstPolicyRequirements(userTrainingStatusChangeRequest))
                    ValidateAgainstPolicy(userTrainingStatusChangeRequest, trainingPolicy);

                var facilitySettings = await facilitySettingsService.GetFacilityTrainingSettings(userTrainingStatusChangeRequest.FacilityId);
                ValidateAgainstFacilitySettings(userTrainingStatusChangeRequest, facilitySettings);


                return await new ValueTask<UserTraining>();
            });
        private static int GetTrainingId(UserTrainingStatusChangeRequest userTrainingStatusChangeRequest) =>
            userTrainingStatusChangeRequest.UserTrainingStatusRequest.ActualTrainingId;
        //if there is other logic to get then please do here
        private static bool ShouldValidateAgainstPolicyRequirements(UserTrainingStatusChangeRequest userTrainingStatusChangeRequest) => true; 
        private static bool ShouldGetTrainerSignatureFromProfile(UserTrainingStatusChangeRequest userTrainingStatusChangeRequest) => true;//signautre fetch from user profile 

    }
}
