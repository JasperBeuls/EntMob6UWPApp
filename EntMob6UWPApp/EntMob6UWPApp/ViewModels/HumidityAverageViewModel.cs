using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using EntMob6UWP.Domain;
using EntMob6UWPApp.Extensions;
using EntMob6UWPApp.Services;
using EntMob6UWPApp.Utility;
using EntMob6UWPApp.View;

namespace EntMob6UWPApp.ViewModels
{
    public class HumidityAverageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private HumidityAverageDataService humidityAverageDataService;
        private ObservableCollection<HumidityAverage> humidityAverages;
        private IFrameNavigation frameNavigation;
        public ICommand MinuteCommand { get; set; }
        public ICommand HourCommand { get; set; }
        public ICommand DayCommand { get; set; }
        public ICommand MonthCommand { get; set; }
        public ICommand OverviewCommand { get; set; }
        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<HumidityAverage> HumidityAverages
        {
            get { return humidityAverages; }
            set
            {
                humidityAverages = value;
                RaisePropertyChanged("HumidityAverages");

            }
        }

        public HumidityAverageViewModel(IFrameNavigation frameNavigation)
        {
            this.frameNavigation = frameNavigation;
            humidityAverageDataService = new HumidityAverageDataService();
            //humidityAverages = humidityAverageDataService.GetAllHumidityAveragesMinute().ToObservableCollection();
            LoadCommands();
        }
        private void LoadCommands()
        {
            MinuteCommand = new CustomCommand(LoadHumidityAveragesMinute, CanLoad);
            HourCommand = new CustomCommand(LoadHumidityAveragesHour, CanLoad);
            DayCommand = new CustomCommand(LoadHumidityAveragesDay, CanLoad);
            MonthCommand = new CustomCommand(LoadHumidityAveragesMonth, CanLoad);
            OverviewCommand = new CustomCommand(OverviewLoad, CanLoad);
        }
        
        private bool CanLoad(object obj)
        {
            return true;
        }

        private void OverviewLoad(object obj)
        {
            frameNavigation.NavigateToFrame(typeof(OverviewView));
        }
        private void LoadHumidityAveragesMinute(object obj)
        {
            HumidityAverages = humidityAverageDataService.GetAllHumidityAveragesMinute().ToObservableCollection();
        }
        private void LoadHumidityAveragesHour(object obj)
        {
            HumidityAverages = humidityAverageDataService.GetAllHumidityAveragesHour().ToObservableCollection();
        }
        private void LoadHumidityAveragesDay(object obj)
        {
            HumidityAverages = humidityAverageDataService.GetAllHumidityAveragesDay().ToObservableCollection();
        }
        private void LoadHumidityAveragesMonth(object obj)
        {
            HumidityAverages = humidityAverageDataService.GetAllHumidityAveragesMonth().ToObservableCollection();
        }
    }
}