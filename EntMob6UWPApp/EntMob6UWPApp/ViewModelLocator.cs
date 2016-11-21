using Windows.Web.Http.Headers;
using EntMob6UWPApp.Services;
using EntMob6UWPApp.ViewModels;
using Microsoft.EntityFrameworkCore.Design;

namespace EntMob6UWPApp
{
    public class ViewModelLocator
    {
        private static IFrameNavigation frameNavigation = new FrameNavigationService();
        private static  OverviewViewModel overviewViewModel = new OverviewViewModel(frameNavigation,DataServiceLocator.HumidityDataService);
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