using EntMob6UWPApp.Services;

namespace EntMob6UWPApp
{
    public static class DataServiceLocator
    {
        public static IAccountDataService AccountDataService { get; } = new AccountDataService();
        public static IHumidityAverageDataService HumidityAverageDataService { get; } = new HumidityAverageDataService();
        public static IHumidityDataService HumidityDataService { get; } = new HumidityDataService();
    }
}