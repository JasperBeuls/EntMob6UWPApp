using EntMob6UWP.Domain;
using EntMob6UWPApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Mocks
    {
        public class MockFrameNavigation : IFrameNavigation
        {
            public MockFrameNavigation()
            {
                NavigationRequests = new List<NavigationRequest>();
                NavigationRequests.Clear();
            }
            public List<NavigationRequest> NavigationRequests;
            public void NavigateToFrame(Type frame)
            {
                NavigationRequests.Add(new NavigationRequest { Frame = frame });
            }

            public class NavigationRequest
            {
                public Type Frame { get; set; }
            }


        }
        public IHumidityDataService getHumidityDataService()
        {
            var x = new StubIHumidityDataService()
           .GetLatestHumidity(() =>
             new EntMob6UWP.Domain.Humidity
             {
                 ID = "hh",
                 Measured = DateTime.Today,
                 Percentage = 50d
             }
               );
            return x;
        }
        public IAirPressureDataService getAirPressureDataService()
        {
            var x = new StubIAirPressureDataService()
           .GetLatestAirPressure(() =>
             new EntMob6UWP.Domain.AirPressure
             {
                 ID = "hh",
                 Measured = DateTime.Today,
                 Value = 53d
             }
               );
            return x;
        }
        public IBrightnessDataService getBrightnessDataService()
        {
            var x = new StubIBrightnessDataService()
           .GetLatestBrightness(() =>
             new EntMob6UWP.Domain.Brightness
             {
                 ID = "hh",
                 Measured = DateTime.Today,
                 Value = 52d
             }
               );
            return x;
        }
        public ITemperatureDataService getTemperatureDataService()
        {
            var x = new StubITemperatureDataService()
           .GetLatestTemperature(() =>
             new EntMob6UWP.Domain.Temperature
             {
                 ID = "hh",
                 Measured = DateTime.Today,
                 Value = 51d
             }
               );
            return x;
        }

        public ITemperatureAverageDataService getTemperatureDataAverageService()
        {
            var x = new StubITemperatureAverageDataService()
           .GetAllTemperatureAveragesDay(() =>
                 new List<TemperatureAverage>{
                new TemperatureAverage
                {
                    ID = "hh",
                    Date = DateTime.Today,
                    AvgValue = 50d
                }
             }
               );
            return x;
        }
        public IAirPressureAverageDataService getAirPressureDataAverageService()
        {
            var x = new StubIAirPressureAverageDataService()
           .GetAllAirPressureAveragesDay(() =>
                 new List<AirPressureAverage>{
                new AirPressureAverage
                {
                    ID = "hh",
                    Date = DateTime.Today,
                    AvgValue = 51d
                }
             }
               );
            return x;
        }
        public IBrightnessAverageDataService getBrightnessDataAverageService()
        {
            var x = new StubIBrightnessAverageDataService()
           .GetAllBrightnessAveragesDay(() =>
                 new List<BrightnessAverage>{
                new BrightnessAverage
                {
                    ID = "hh",
                    Date = DateTime.Today,
                    AvgValue = 52d
                }
             }
               );
            return x;
        }
        public IHumidityAverageDataService getHumidityDataAverageService()
        {
            var x = new StubIHumidityAverageDataService()
           .GetAllHumidityAveragesDay(() =>
                 new List<HumidityAverage>{
                new HumidityAverage
                {
                    ID = "hh",
                    Date = DateTime.Today,
                    AvPer = 53d
                }
             }
               );
            return x;
        }
    }
}
