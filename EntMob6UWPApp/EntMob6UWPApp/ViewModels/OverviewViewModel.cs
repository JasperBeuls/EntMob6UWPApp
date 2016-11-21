using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using EntMob6UWP.Domain;
using EntMob6UWPApp.Extensions;
using EntMob6UWPApp.Services;
using EntMob6UWPApp.Utility;
using EntMob6UWPApp.View;

namespace EntMob6UWPApp.ViewModels
{
    public class OverviewViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private IHumidityDataService humidityDataService;
        private ObservableCollection<Humidity> humidities;
        private Account loggedInUser;
        private IFrameNavigation frameNavigation;
        public ICommand OverviewCommand { get; set; }
        public ICommand HistoryCommand { get; set; }
        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
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
        public OverviewViewModel(IFrameNavigation frameNavigation,IHumidityDataService humidityDataService)
        {
            this.frameNavigation = frameNavigation;
            Messenger.Default.Register<Account>(this, OnUserReceived);
            //humidityDataService = new HumidityDataService();
            this.humidityDataService = humidityDataService;
            LoadCommands();    
        }

        public void LoadData()
        {
            humidities = humidityDataService.GetAllHumidities().ToObservableCollection();
            //humidities = humidityDataService.GetDataHumidities().ToObservableCollection();
            latestHumidity = humidities.LastOrDefault();
        }
        private void LoadCommands()
        {
            OverviewCommand = new CustomCommand(ShowOverview, CanShowValues);
            HistoryCommand = new CustomCommand(ShowHistoryView, CanShowValues);
        }
        private void ShowHistoryView(object obj)
        {
            frameNavigation.NavigateToFrame(typeof(HumidityAverageView));
        }

        private void ShowOverview(object obj)
        {
            frameNavigation.NavigateToFrame(typeof(OverviewView));
        }

        private bool CanShowValues(object obj)
        {
            return true;
        }

        private void OnUserReceived(Account user)
        {

            LoggedInUser = user;

            LoadData();
        }
        public Account LoggedInUser
        {
            get { return loggedInUser; }
            set
            {
                loggedInUser = value;
                RaisePropertyChanged("LoggedInUser");

            }
        }
    }
}