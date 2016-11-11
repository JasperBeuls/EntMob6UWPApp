using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using EntMob6UWP.Domain;
using EntMob6UWPApp.Extensions;
using EntMob6UWPApp.Services;

namespace EntMob6UWPApp.ViewModels
{
    public class OverviewViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private HumidityDataService humidityDataService;
        private ObservableCollection<Humidity> humidities;
        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        

        public ObservableCollection<Humidity> Humidities
        {
            get { return Humidities; }
            set
            {
                Humidities = value;
                RaisePropertyChanged("Humidities");
            }
        }

        private Humidity latestHumidity;

        public Humidity LatestHumidity
        {
            get { return latestHumidity;}
            set
            {
                latestHumidity = value;
                RaisePropertyChanged("LatestHumidity");
            }
        }
        public OverviewViewModel()
        {
            humidityDataService = new HumidityDataService();
                
            LoadData();
        }

        public void LoadData()
        {
            //TODO humidities = humidityDataService.GetAllHumidities().ToObservableCollection();
            humidities = humidityDataService.GetDataHumidities().ToObservableCollection();
            latestHumidity = humidities.LastOrDefault();
        }
    }
}