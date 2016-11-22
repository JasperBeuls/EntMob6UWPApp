using EntMob6UWPApp.Services;
using Windows.UI.Xaml.Data;

namespace EntMob6UWPApp
{

   
    public static class DataServiceLocator
    {

        public static IAccountDataService AccountDataService { get; } = new AccountDataService();
        public static IHumidityAverageDataService HumidityAverageDataService { get; } = new HumidityAverageDataService();
        public static IHumidityDataService HumidityDataService { get; } = new HumidityDataService();

        public static IAirPressureAverageDataService AirPressureAverageDataService  { get; } = new AirPressureAverageDataService();
        public static IAirPressureDataService AirPressureDataService { get; } = new AirPressureDataService();
        public static IBrightnessAverageDataService BrightnessAverageDataService { get; } = new BrightnessAverageDataService();
        public static IBrightnessDataService BrightnessDataService { get; } = new BrightnessDataService();
        public static ITemperatureAverageDataService TemperatureAverageDataService { get; } = new TemperatureAverageDataService();
        public static ITemperatureDataService TemperatureDataService { get; } = new TemperatureDataService();
    }
}