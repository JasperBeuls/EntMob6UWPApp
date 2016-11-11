using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using EntMob6UWPApp.View;

namespace EntMob6UWPApp.Services
{
    public class DialogService
    {
        

        public void ShowDialog()
        {
            
            var newWindow = Window.Current;
            var newAppView = ApplicationView.GetForCurrentView();
            newAppView.Title = "Main Page";

            var frame = new Frame();
            frame.Navigate(typeof(MainPage));
            newWindow.Content = frame;
            newWindow.Activate();

        }
    }
}