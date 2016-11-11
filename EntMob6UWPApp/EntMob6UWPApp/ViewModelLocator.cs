using Windows.Web.Http.Headers;
using EntMob6UWPApp.ViewModels;
using Microsoft.EntityFrameworkCore.Design;

namespace EntMob6UWPApp
{
    public class ViewModelLocator
    {
        private static  OverviewViewModel overviewViewModel = new OverviewViewModel();
        private static HumidityAverageViewModel humidityAverageViewModel = new HumidityAverageViewModel();
        private static LoginViewModel loginViewModel = new LoginViewModel();
        private static MainpageViewModel mainpageViewModel = new MainpageViewModel();
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