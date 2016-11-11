using System.Collections.ObjectModel;
using System.ComponentModel;
using EntMob6UWP.Domain;
using EntMob6UWPApp.Extensions;
using EntMob6UWPApp.Services;

namespace EntMob6UWPApp.ViewModels
{
    public class HumidityAverageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private HumidityAverageDataService humidityAverageDataService;
        private ObservableCollection<HumidityAverage> humidityAverages; 
        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
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

        public HumidityAverageViewModel()
        {
            humidityAverageDataService = new HumidityAverageDataService();
            humidityAverages = humidityAverageDataService.GetAllHumidityAveragesTest().ToObservableCollection();

        }
        
    }
}