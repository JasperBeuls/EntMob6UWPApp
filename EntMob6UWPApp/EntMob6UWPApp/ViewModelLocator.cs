using Windows.Web.Http.Headers;
using EntMob6UWPApp.Services;
using EntMob6UWPApp.ViewModels;
using Microsoft.EntityFrameworkCore.Design;
using Windows.UI.Xaml.Data;

namespace EntMob6UWPApp
{
    [Bindable]
    public class ViewModelLocator
    {
        private static IFrameNavigation frameNavigation = new FrameNavigationService();
        private static OverviewViewModel overviewViewModel = new OverviewViewModel(
            frameNavigation,
            DataServiceLocator.HumidityDataService,
            DataServiceLocator.BrightnessDataService,
            DataServiceLocator.AirPressureDataService);
        private static HumidityAverageViewModel humidityAverageViewModel = new HumidityAverageViewModel(frameNavigation);
        private static LoginViewModel loginViewModel = new LoginViewModel(frameNavigation);
        private static MainpageViewModel mainpageViewModel = new MainpageViewModel(frameNavigation);
        private static HistoryViewModel historyViewModel = new HistoryViewModel(frameNavigation);

        public static HistoryViewModel HistoryViewModel
        {
            get { return historyViewModel; }
        }
        public static OverviewViewModel OverviewViewModel
        {
            get { return overviewViewModel; }
        }

        public static HumidityAverageViewModel HumidityAverageViewModel
        {
            get { return humidityAverageViewModel;}
        }

        public static LoginViewModel LoginViewModel
        {
            get { return loginViewModel; }
        }

        public static MainpageViewModel MainpageViewModel
        {
            get { return mainpageViewModel; }
        }
    }
}