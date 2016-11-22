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
        private Account loggedInUser;
        public event PropertyChangedEventHandler PropertyChanged;

        private IHumidityDataService humidityDataService;
        private IAirPressureDataService airPressureDataService;
        private IBrightnessDataService brightnessDataService;
        private ITemperatureDataService temperateDataService;
      //todo: TEMP  private IHumidityDataService humidityDataService;



        private IFrameNavigation frameNavigation;
        public ICommand OverviewCommand { get; set; }
        public ICommand HistoryCommand { get; set; }
        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


       

        
        public OverviewViewModel(IFrameNavigation frameNavigation,
            IHumidityDataService humidityDataService,
            IBrightnessDataService brightnessDataService,
              IAirPressureDataService airPressureDataService,
              ITemperatureDataService temperateDataService
            )
        {
            this.frameNavigation = frameNavigation;
            Messenger.Default.Register<Account>(this, OnUserReceived);
            this.humidityDataService = humidityDataService;
            this.airPressureDataService = airPressureDataService;
            this.brightnessDataService = brightnessDataService;
            this.temperateDataService = temperateDataService;
            LoadCommands();    
        }

        public void LoadData()
        {
         
            //humidities = humidityDataService.GetDataHumidities().ToObservableCollection();
            latestHumidity =humidityDataService.GetLatestHumidity();
            latestAirPressure = airPressureDataService.GetLatestAirPressure();
            latestBrightness = brightnessDataService.GetLatestBrightness();
            latestTemperature = temperateDataService.GetLatestTemperature();
        }
        private void LoadCommands()
        {
            OverviewCommand = new CustomCommand(ShowOverview, CanShowValues);
            HistoryCommand = new CustomCommand(ShowHistoryView, CanShowValues);
        }
        private void ShowHistoryView(object obj)
        {
            frameNavigation.NavigateToFrame(typeof(AverageView));
        }

        private void ShowOverview(object obj)
        {
          //  frameNavigation.NavigateToFrame(typeof(OverviewView));
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


        //WEATHER

        private Humidity latestHumidity;

        public Humidity LatestHumidity
        {
            get { return latestHumidity; }
            set
            {
                latestHumidity = value;
                RaisePropertyChanged("LatestHumidity");
            }
        }

        private Temperature latestTemperature;

        public Temperature LatestTemperature
        {
            get { return latestTemperature; }
            set
            {
                latestTemperature = value;
                RaisePropertyChanged("LatestTemperature");
            }
        }
        private Brightness latestBrightness;

        public Brightness LatestBrightness
        {
            get { return latestBrightness; }
            set
            {
                latestBrightness = value;
                RaisePropertyChanged("LatestBrightness");
            }
        }
        private AirPressure latestAirPressure;

        public AirPressure LatestAirPressure
        {
            get { return latestAirPressure; }
            set
            {
                latestAirPressure = value;
                RaisePropertyChanged("LatestAirPressure");
            }
        }
    }
}