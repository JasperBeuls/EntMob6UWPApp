using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using EntMob6UWP.Domain;
using EntMob6UWPApp.Extensions;
using EntMob6UWPApp.Services;
using EntMob6UWPApp.Utility;
using EntMob6UWPApp.View;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using Windows.UI.Popups;

namespace EntMob6UWPApp.ViewModels
{
    public class AverageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string currentClass;
        private string currentFilter;

        private IHumidityAverageDataService humidityAverageDataService;
        private IAirPressureAverageDataService airPressureAverageDataService;
        private IBrightnessAverageDataService brightnessAverageDataService;
        private ITemperatureAverageDataService temperatureAverageDataService;


        private ObservableCollection<IAverage> averages;


        private IFrameNavigation frameNavigation;


        public ICommand MinuteCommand { get; set; }
        public ICommand HourCommand { get; set; }
        public ICommand DayCommand { get; set; }
        public ICommand MonthCommand { get; set; }
        public ICommand OverviewCommand { get; set; }

        public ICommand SwitchClassCommand { get; set; }

        private void RaisePropertyChanged(string propertyName)
        {
            Debug.WriteLine("PROPERTY CHANGED");
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<IAverage> Averages
        {
            get { return averages; }
            set
            {
                averages = value;
                RaisePropertyChanged("Averages");

            }
        }

        public string CurrentClass
        {
            get
            {
                return currentClass;
            }

            set
            {
                currentClass = value;
            }
        }

        public string CurrentFilter
        {
            get
            {
                return currentFilter;
            }

            set
            {
                currentFilter = value;
            }
        }

        public AverageViewModel(IFrameNavigation frameNavigation,
            IHumidityAverageDataService humidityAverageDataService,
            IBrightnessAverageDataService brightnessAverageDataService,
            ITemperatureAverageDataService temperatureAverageDataService,
            IAirPressureAverageDataService airPressureAverageDataService)
        {
            this.frameNavigation = frameNavigation;
            this.humidityAverageDataService = humidityAverageDataService;
            this.brightnessAverageDataService = brightnessAverageDataService;
            this.temperatureAverageDataService = temperatureAverageDataService;
            this.airPressureAverageDataService = airPressureAverageDataService;
           
            LoadCommands();
        }
        private void LoadCommands()
        {
            MinuteCommand = new CustomCommand(LoadAveragesMinute, CanLoad);
            HourCommand = new CustomCommand(LoadAveragesHour, CanLoad);
            DayCommand = new CustomCommand(LoadAveragesDay, CanLoad);
            MonthCommand = new CustomCommand(LoadAveragesMonth, CanLoad);
            OverviewCommand = new CustomCommand(OverviewLoad, CanLoad);
            SwitchClassCommand = new CustomCommand(SwitchClass, CanLoad);
        }
        
        private bool CanLoad(object obj)
        {
            return true;
        }

        private void OverviewLoad(object obj)
        {
            frameNavigation.NavigateToFrame(typeof(OverviewView));
        }
        private void SwitchClass(object obj)
        {
            string s = obj as string;
            CurrentClass = s;

            switch (CurrentFilter)
            {
                case "Minute":
                    LoadAveragesMinute(null);
                    break;
                case "Hour":
                    LoadAveragesHour(null);
                    break;
                case "Month":
                    LoadAveragesMonth(null);
                    break;
                case "Day":
                    LoadAveragesDay(null);
                    break;
            }
        }
        private void LoadAveragesMinute(object obj)
        {
            CurrentFilter = "Minute";
            switch (CurrentClass)
            {
                case "Humidity":
                    Averages = humidityAverageDataService.GetAllHumidityAveragesMinute().Cast<IAverage>().ToList().ToObservableCollection();
                    break;
                case "Temperature":
                    Averages = temperatureAverageDataService.GetAllTemperatureAveragesMinute().Cast<IAverage>().ToList().ToObservableCollection();
                    break;
                case "Brightness":
                    Averages = brightnessAverageDataService.GetAllBrightnessAveragesMinute().Cast<IAverage>().ToList().ToObservableCollection();
                    break;
                case "AirPressure":
                    Averages = airPressureAverageDataService.GetAllAirPressureAveragesMinute().Cast<IAverage>().ToList().ToObservableCollection();
                    break;
            }
          
            
        }
        private void LoadAveragesHour(object obj)
        {
            CurrentFilter = "Hour";
            switch (CurrentClass)
            {
                case "Humidity":
                    Averages = humidityAverageDataService.GetAllHumidityAveragesHour().Cast<IAverage>().ToList().ToObservableCollection();
                    break;
                case "Temperature":
                    Averages = temperatureAverageDataService.GetAllTemperatureAveragesHour().Cast<IAverage>().ToList().ToObservableCollection();
                    break;
                case "Brightness":
                    Averages = brightnessAverageDataService.GetAllBrightnessAveragesHour().Cast<IAverage>().ToList().ToObservableCollection();
                    break;
                case "AirPressure":
                    Averages = airPressureAverageDataService.GetAllAirPressureAveragesHour().Cast<IAverage>().ToList().ToObservableCollection();
                    break;
            }
        }
        private void LoadAveragesDay(object obj)
        {
            CurrentFilter = "Day";
            switch (CurrentClass)
            {
                case "Humidity":
                    Averages = humidityAverageDataService.GetAllHumidityAveragesDay().Cast<IAverage>().ToList().ToObservableCollection();
                    break;
                case "Temperature":
                    Averages = temperatureAverageDataService.GetAllTemperatureAveragesDay().Cast<IAverage>().ToList().ToObservableCollection();
                    break;
                case "Brightness":
                    Averages = brightnessAverageDataService.GetAllBrightnessAveragesDay().Cast<IAverage>().ToList().ToObservableCollection();
                    break;
                case "AirPressure":
                    Averages = airPressureAverageDataService.GetAllAirPressureAveragesDay().Cast<IAverage>().ToList().ToObservableCollection();
                    break;
            }
        }
        private void LoadAveragesMonth(object obj)
        {
            CurrentFilter = "Month";
            switch (CurrentClass)
            {
                case "Humidity":
                    Averages = humidityAverageDataService.GetAllHumidityAveragesMonth().Cast<IAverage>().ToList().ToObservableCollection();
                    break;
                case "Temperature":
                    Averages = temperatureAverageDataService.GetAllTemperatureAveragesMonth().Cast<IAverage>().ToList().ToObservableCollection();
                    break;
                case "Brightness":
                    Averages = brightnessAverageDataService.GetAllBrightnessAveragesMonth().Cast<IAverage>().ToList().ToObservableCollection();
                    break;
                case "AirPressure":
                    Averages = airPressureAverageDataService.GetAllAirPressureAveragesMonth().Cast<IAverage>().ToList().ToObservableCollection();
                    break;
            }
        }
    }
}