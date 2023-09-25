namespace MarkTrainedAPI.Services.Foundation.FacilitySettings
{
    internal interface IFacilitySettingsService
    {
        ValueTask<MarkTrainedAPI.Models.Brokers.FacilitySettings> GetFacilityTrainingSettings(int facilityId);
    }
}
