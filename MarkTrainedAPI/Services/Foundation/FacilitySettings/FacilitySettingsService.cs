namespace MarkTrainedAPI.Services.Foundation.FacilitySettings
{
    internal partial class FacilitySettingsService : IFacilitySettingsService
    {
        public ValueTask<Models.Brokers.FacilitySettings> GetFacilityTrainingSettings(int facilityId)
        {
            return new ValueTask<Models.Brokers.FacilitySettings>();
        }
    }
}
