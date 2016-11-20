using System.ComponentModel;
using EntMob6UWPApp.Services;

namespace EntMob6UWPApp.ViewModels
{
    public class HistoryViewModel : INotifyPropertyChanged
    {
        

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public HistoryViewModel(IFrameNavigation frameNavigation)
        {
           // frameNavigation.NavigateToFrame(typeof(MainPage));
        }
    }
}