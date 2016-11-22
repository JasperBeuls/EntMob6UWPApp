using System;
using System.Runtime.CompilerServices;
using Etg.SimpleStubs;
using EntMob6UWP.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntMob6UWP.DAL
{
    [CompilerGenerated]
    public class StubIAccountRepository : IAccountRepository
    {
        private readonly StubContainer<StubIAccountRepository> _stubs = new StubContainer<StubIAccountRepository>();

        global::EntMob6UWP.Domain.Account global::EntMob6UWP.DAL.IAccountRepository.GetAccount(string username, string password)
        {
            return _stubs.GetMethodStub<GetAccount_String_String_Delegate>("GetAccount").Invoke(username, password);
        }

        public delegate global::EntMob6UWP.Domain.Account GetAccount_String_String_Delegate(string username, string password);

        public StubIAccountRepository GetAccount(GetAccount_String_String_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace EntMob6UWP.DAL
{
    [CompilerGenerated]
    public class StubIAirPressureRepository : IAirPressureRepository
    {
        private readonly StubContainer<StubIAirPressureRepository> _stubs = new StubContainer<StubIAirPressureRepository>();

        global::EntMob6UWP.Domain.AirPressure global::EntMob6UWP.DAL.IAirPressureRepository.GetLatestAirPressure()
        {
            return _stubs.GetMethodStub<GetLatestAirPressure_Delegate>("GetLatestAirPressure").Invoke();
        }

        public delegate global::EntMob6UWP.Domain.AirPressure GetLatestAirPressure_Delegate();

        public StubIAirPressureRepository GetLatestAirPressure(GetLatestAirPressure_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.AirPressure> global::EntMob6UWP.DAL.IAirPressureRepository.GetAllAirPressures()
        {
            return _stubs.GetMethodStub<GetAllAirPressures_Delegate>("GetAllAirPressures").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.AirPressure> GetAllAirPressures_Delegate();

        public StubIAirPressureRepository GetAllAirPressures(GetAllAirPressures_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.AirPressureAverage> global::EntMob6UWP.DAL.IAirPressureRepository.GetAllAirPressureAveragesMinute()
        {
            return _stubs.GetMethodStub<GetAllAirPressureAveragesMinute_Delegate>("GetAllAirPressureAveragesMinute").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.AirPressureAverage> GetAllAirPressureAveragesMinute_Delegate();

        public StubIAirPressureRepository GetAllAirPressureAveragesMinute(GetAllAirPressureAveragesMinute_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.AirPressureAverage> global::EntMob6UWP.DAL.IAirPressureRepository.GetAllAirPressureAveragesHour()
        {
            return _stubs.GetMethodStub<GetAllAirPressureAveragesHour_Delegate>("GetAllAirPressureAveragesHour").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.AirPressureAverage> GetAllAirPressureAveragesHour_Delegate();

        public StubIAirPressureRepository GetAllAirPressureAveragesHour(GetAllAirPressureAveragesHour_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.AirPressureAverage> global::EntMob6UWP.DAL.IAirPressureRepository.GetAllAirPressureAveragesDay()
        {
            return _stubs.GetMethodStub<GetAllAirPressureAveragesDay_Delegate>("GetAllAirPressureAveragesDay").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.AirPressureAverage> GetAllAirPressureAveragesDay_Delegate();

        public StubIAirPressureRepository GetAllAirPressureAveragesDay(GetAllAirPressureAveragesDay_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.AirPressureAverage> global::EntMob6UWP.DAL.IAirPressureRepository.GetAllAirPressureAveragesMonth()
        {
            return _stubs.GetMethodStub<GetAllAirPressureAveragesMonth_Delegate>("GetAllAirPressureAveragesMonth").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.AirPressureAverage> GetAllAirPressureAveragesMonth_Delegate();

        public StubIAirPressureRepository GetAllAirPressureAveragesMonth(GetAllAirPressureAveragesMonth_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace EntMob6UWP.DAL
{
    [CompilerGenerated]
    public class StubIBrightnessRepository : IBrightnessRepository
    {
        private readonly StubContainer<StubIBrightnessRepository> _stubs = new StubContainer<StubIBrightnessRepository>();

        global::EntMob6UWP.Domain.Brightness global::EntMob6UWP.DAL.IBrightnessRepository.GetLatestBrightness()
        {
            return _stubs.GetMethodStub<GetLatestBrightness_Delegate>("GetLatestBrightness").Invoke();
        }

        public delegate global::EntMob6UWP.Domain.Brightness GetLatestBrightness_Delegate();

        public StubIBrightnessRepository GetLatestBrightness(GetLatestBrightness_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.Brightness> global::EntMob6UWP.DAL.IBrightnessRepository.GetAllBrightnesses()
        {
            return _stubs.GetMethodStub<GetAllBrightnesses_Delegate>("GetAllBrightnesses").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.Brightness> GetAllBrightnesses_Delegate();

        public StubIBrightnessRepository GetAllBrightnesses(GetAllBrightnesses_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.BrightnessAverage> global::EntMob6UWP.DAL.IBrightnessRepository.GetAllBrightnessAveragesMinute()
        {
            return _stubs.GetMethodStub<GetAllBrightnessAveragesMinute_Delegate>("GetAllBrightnessAveragesMinute").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.BrightnessAverage> GetAllBrightnessAveragesMinute_Delegate();

        public StubIBrightnessRepository GetAllBrightnessAveragesMinute(GetAllBrightnessAveragesMinute_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.BrightnessAverage> global::EntMob6UWP.DAL.IBrightnessRepository.GetAllBrightnessAveragesHour()
        {
            return _stubs.GetMethodStub<GetAllBrightnessAveragesHour_Delegate>("GetAllBrightnessAveragesHour").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.BrightnessAverage> GetAllBrightnessAveragesHour_Delegate();

        public StubIBrightnessRepository GetAllBrightnessAveragesHour(GetAllBrightnessAveragesHour_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.BrightnessAverage> global::EntMob6UWP.DAL.IBrightnessRepository.GetAllBrightnessAveragesDay()
        {
            return _stubs.GetMethodStub<GetAllBrightnessAveragesDay_Delegate>("GetAllBrightnessAveragesDay").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.BrightnessAverage> GetAllBrightnessAveragesDay_Delegate();

        public StubIBrightnessRepository GetAllBrightnessAveragesDay(GetAllBrightnessAveragesDay_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.BrightnessAverage> global::EntMob6UWP.DAL.IBrightnessRepository.GetAllBrightnessAveragesMonth()
        {
            return _stubs.GetMethodStub<GetAllBrightnessAveragesMonth_Delegate>("GetAllBrightnessAveragesMonth").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.BrightnessAverage> GetAllBrightnessAveragesMonth_Delegate();

        public StubIBrightnessRepository GetAllBrightnessAveragesMonth(GetAllBrightnessAveragesMonth_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace EntMob6UWP.DAL
{
    [CompilerGenerated]
    public class StubIHumidityRepository : IHumidityRepository
    {
        private readonly StubContainer<StubIHumidityRepository> _stubs = new StubContainer<StubIHumidityRepository>();

        global::EntMob6UWP.Domain.Humidity global::EntMob6UWP.DAL.IHumidityRepository.GetLatestHumidity()
        {
            return _stubs.GetMethodStub<GetLatestHumidity_Delegate>("GetLatestHumidity").Invoke();
        }

        public delegate global::EntMob6UWP.Domain.Humidity GetLatestHumidity_Delegate();

        public StubIHumidityRepository GetLatestHumidity(GetLatestHumidity_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.Humidity> global::EntMob6UWP.DAL.IHumidityRepository.GetAllHumidities()
        {
            return _stubs.GetMethodStub<GetAllHumidities_Delegate>("GetAllHumidities").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.Humidity> GetAllHumidities_Delegate();

        public StubIHumidityRepository GetAllHumidities(GetAllHumidities_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.HumidityAverage> global::EntMob6UWP.DAL.IHumidityRepository.GetAllHumidityAveragesMinute()
        {
            return _stubs.GetMethodStub<GetAllHumidityAveragesMinute_Delegate>("GetAllHumidityAveragesMinute").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.HumidityAverage> GetAllHumidityAveragesMinute_Delegate();

        public StubIHumidityRepository GetAllHumidityAveragesMinute(GetAllHumidityAveragesMinute_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.HumidityAverage> global::EntMob6UWP.DAL.IHumidityRepository.GetAllHumidityAveragesHour()
        {
            return _stubs.GetMethodStub<GetAllHumidityAveragesHour_Delegate>("GetAllHumidityAveragesHour").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.HumidityAverage> GetAllHumidityAveragesHour_Delegate();

        public StubIHumidityRepository GetAllHumidityAveragesHour(GetAllHumidityAveragesHour_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.HumidityAverage> global::EntMob6UWP.DAL.IHumidityRepository.GetAllHumidityAveragesDay()
        {
            return _stubs.GetMethodStub<GetAllHumidityAveragesDay_Delegate>("GetAllHumidityAveragesDay").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.HumidityAverage> GetAllHumidityAveragesDay_Delegate();

        public StubIHumidityRepository GetAllHumidityAveragesDay(GetAllHumidityAveragesDay_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.HumidityAverage> global::EntMob6UWP.DAL.IHumidityRepository.GetAllHumidityAveragesMonth()
        {
            return _stubs.GetMethodStub<GetAllHumidityAveragesMonth_Delegate>("GetAllHumidityAveragesMonth").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.HumidityAverage> GetAllHumidityAveragesMonth_Delegate();

        public StubIHumidityRepository GetAllHumidityAveragesMonth(GetAllHumidityAveragesMonth_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace EntMob6UWP.DAL
{
    [CompilerGenerated]
    public class StubITemperatureRepository : ITemperatureRepository
    {
        private readonly StubContainer<StubITemperatureRepository> _stubs = new StubContainer<StubITemperatureRepository>();

        global::EntMob6UWP.Domain.Temperature global::EntMob6UWP.DAL.ITemperatureRepository.GetLatestTemperature()
        {
            return _stubs.GetMethodStub<GetLatestTemperature_Delegate>("GetLatestTemperature").Invoke();
        }

        public delegate global::EntMob6UWP.Domain.Temperature GetLatestTemperature_Delegate();

        public StubITemperatureRepository GetLatestTemperature(GetLatestTemperature_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.Temperature> global::EntMob6UWP.DAL.ITemperatureRepository.GetAllTemperatures()
        {
            return _stubs.GetMethodStub<GetAllTemperatures_Delegate>("GetAllTemperatures").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.Temperature> GetAllTemperatures_Delegate();

        public StubITemperatureRepository GetAllTemperatures(GetAllTemperatures_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.TemperatureAverage> global::EntMob6UWP.DAL.ITemperatureRepository.GetAllTemperatureAveragesMinute()
        {
            return _stubs.GetMethodStub<GetAllTemperatureAveragesMinute_Delegate>("GetAllTemperatureAveragesMinute").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.TemperatureAverage> GetAllTemperatureAveragesMinute_Delegate();

        public StubITemperatureRepository GetAllTemperatureAveragesMinute(GetAllTemperatureAveragesMinute_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.TemperatureAverage> global::EntMob6UWP.DAL.ITemperatureRepository.GetAllTemperatureAveragesHour()
        {
            return _stubs.GetMethodStub<GetAllTemperatureAveragesHour_Delegate>("GetAllTemperatureAveragesHour").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.TemperatureAverage> GetAllTemperatureAveragesHour_Delegate();

        public StubITemperatureRepository GetAllTemperatureAveragesHour(GetAllTemperatureAveragesHour_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.TemperatureAverage> global::EntMob6UWP.DAL.ITemperatureRepository.GetAllTemperatureAveragesDay()
        {
            return _stubs.GetMethodStub<GetAllTemperatureAveragesDay_Delegate>("GetAllTemperatureAveragesDay").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.TemperatureAverage> GetAllTemperatureAveragesDay_Delegate();

        public StubITemperatureRepository GetAllTemperatureAveragesDay(GetAllTemperatureAveragesDay_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.TemperatureAverage> global::EntMob6UWP.DAL.ITemperatureRepository.GetAllTemperatureAveragesMonth()
        {
            return _stubs.GetMethodStub<GetAllTemperatureAveragesMonth_Delegate>("GetAllTemperatureAveragesMonth").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.TemperatureAverage> GetAllTemperatureAveragesMonth_Delegate();

        public StubITemperatureRepository GetAllTemperatureAveragesMonth(GetAllTemperatureAveragesMonth_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace EntMob6UWP.Domain
{
    [CompilerGenerated]
    public class StubIAverage : IAverage
    {
        private readonly StubContainer<StubIAverage> _stubs = new StubContainer<StubIAverage>();

        global::System.DateTime global::EntMob6UWP.Domain.IAverage.Date
        {
            get
            {
                return _stubs.GetMethodStub<Date_Get_Delegate>("get_Date").Invoke();
            }

            set
            {
                _stubs.GetMethodStub<Date_Set_Delegate>("set_Date").Invoke(value);
            }
        }

        double global::EntMob6UWP.Domain.IAverage.Average
        {
            get
            {
                return _stubs.GetMethodStub<Average_Get_Delegate>("get_Average").Invoke();
            }
        }

        public delegate global::System.DateTime Date_Get_Delegate();

        public StubIAverage Date_Get(Date_Get_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        public delegate void Date_Set_Delegate(global::System.DateTime value);

        public StubIAverage Date_Set(Date_Set_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        public delegate double Average_Get_Delegate();

        public StubIAverage Average_Get(Average_Get_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace EntMob6UWPApp.Services
{
    [CompilerGenerated]
    public class StubIAccountDataService : IAccountDataService
    {
        private readonly StubContainer<StubIAccountDataService> _stubs = new StubContainer<StubIAccountDataService>();

        global::EntMob6UWP.Domain.Account global::EntMob6UWPApp.Services.IAccountDataService.GetAccount(string username, string password)
        {
            return _stubs.GetMethodStub<GetAccount_String_String_Delegate>("GetAccount").Invoke(username, password);
        }

        public delegate global::EntMob6UWP.Domain.Account GetAccount_String_String_Delegate(string username, string password);

        public StubIAccountDataService GetAccount(GetAccount_String_String_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace EntMob6UWPApp.Services
{
    [CompilerGenerated]
    public class StubIAirPressureAverageDataService : IAirPressureAverageDataService
    {
        private readonly StubContainer<StubIAirPressureAverageDataService> _stubs = new StubContainer<StubIAirPressureAverageDataService>();

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.AirPressureAverage> global::EntMob6UWPApp.Services.IAirPressureAverageDataService.GetAllAirPressureAveragesMinute()
        {
            return _stubs.GetMethodStub<GetAllAirPressureAveragesMinute_Delegate>("GetAllAirPressureAveragesMinute").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.AirPressureAverage> GetAllAirPressureAveragesMinute_Delegate();

        public StubIAirPressureAverageDataService GetAllAirPressureAveragesMinute(GetAllAirPressureAveragesMinute_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.AirPressureAverage> global::EntMob6UWPApp.Services.IAirPressureAverageDataService.GetAllAirPressureAveragesHour()
        {
            return _stubs.GetMethodStub<GetAllAirPressureAveragesHour_Delegate>("GetAllAirPressureAveragesHour").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.AirPressureAverage> GetAllAirPressureAveragesHour_Delegate();

        public StubIAirPressureAverageDataService GetAllAirPressureAveragesHour(GetAllAirPressureAveragesHour_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.AirPressureAverage> global::EntMob6UWPApp.Services.IAirPressureAverageDataService.GetAllAirPressureAveragesDay()
        {
            return _stubs.GetMethodStub<GetAllAirPressureAveragesDay_Delegate>("GetAllAirPressureAveragesDay").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.AirPressureAverage> GetAllAirPressureAveragesDay_Delegate();

        public StubIAirPressureAverageDataService GetAllAirPressureAveragesDay(GetAllAirPressureAveragesDay_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.AirPressureAverage> global::EntMob6UWPApp.Services.IAirPressureAverageDataService.GetAllAirPressureAveragesMonth()
        {
            return _stubs.GetMethodStub<GetAllAirPressureAveragesMonth_Delegate>("GetAllAirPressureAveragesMonth").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.AirPressureAverage> GetAllAirPressureAveragesMonth_Delegate();

        public StubIAirPressureAverageDataService GetAllAirPressureAveragesMonth(GetAllAirPressureAveragesMonth_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace EntMob6UWPApp.Services
{
    [CompilerGenerated]
    public class StubIAirPressureDataService : IAirPressureDataService
    {
        private readonly StubContainer<StubIAirPressureDataService> _stubs = new StubContainer<StubIAirPressureDataService>();

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.AirPressure> global::EntMob6UWPApp.Services.IAirPressureDataService.GetAllAirPressures()
        {
            return _stubs.GetMethodStub<GetAllAirPressures_Delegate>("GetAllAirPressures").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.AirPressure> GetAllAirPressures_Delegate();

        public StubIAirPressureDataService GetAllAirPressures(GetAllAirPressures_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::EntMob6UWP.Domain.AirPressure global::EntMob6UWPApp.Services.IAirPressureDataService.GetLatestAirPressure()
        {
            return _stubs.GetMethodStub<GetLatestAirPressure_Delegate>("GetLatestAirPressure").Invoke();
        }

        public delegate global::EntMob6UWP.Domain.AirPressure GetLatestAirPressure_Delegate();

        public StubIAirPressureDataService GetLatestAirPressure(GetLatestAirPressure_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace EntMob6UWPApp.Services
{
    [CompilerGenerated]
    public class StubIBrightnessAverageDataService : IBrightnessAverageDataService
    {
        private readonly StubContainer<StubIBrightnessAverageDataService> _stubs = new StubContainer<StubIBrightnessAverageDataService>();

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.BrightnessAverage> global::EntMob6UWPApp.Services.IBrightnessAverageDataService.GetAllBrightnessAveragesMinute()
        {
            return _stubs.GetMethodStub<GetAllBrightnessAveragesMinute_Delegate>("GetAllBrightnessAveragesMinute").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.BrightnessAverage> GetAllBrightnessAveragesMinute_Delegate();

        public StubIBrightnessAverageDataService GetAllBrightnessAveragesMinute(GetAllBrightnessAveragesMinute_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.BrightnessAverage> global::EntMob6UWPApp.Services.IBrightnessAverageDataService.GetAllBrightnessAveragesHour()
        {
            return _stubs.GetMethodStub<GetAllBrightnessAveragesHour_Delegate>("GetAllBrightnessAveragesHour").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.BrightnessAverage> GetAllBrightnessAveragesHour_Delegate();

        public StubIBrightnessAverageDataService GetAllBrightnessAveragesHour(GetAllBrightnessAveragesHour_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.BrightnessAverage> global::EntMob6UWPApp.Services.IBrightnessAverageDataService.GetAllBrightnessAveragesDay()
        {
            return _stubs.GetMethodStub<GetAllBrightnessAveragesDay_Delegate>("GetAllBrightnessAveragesDay").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.BrightnessAverage> GetAllBrightnessAveragesDay_Delegate();

        public StubIBrightnessAverageDataService GetAllBrightnessAveragesDay(GetAllBrightnessAveragesDay_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.BrightnessAverage> global::EntMob6UWPApp.Services.IBrightnessAverageDataService.GetAllBrightnessAveragesMonth()
        {
            return _stubs.GetMethodStub<GetAllBrightnessAveragesMonth_Delegate>("GetAllBrightnessAveragesMonth").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.BrightnessAverage> GetAllBrightnessAveragesMonth_Delegate();

        public StubIBrightnessAverageDataService GetAllBrightnessAveragesMonth(GetAllBrightnessAveragesMonth_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace EntMob6UWPApp.Services
{
    [CompilerGenerated]
    public class StubIBrightnessDataService : IBrightnessDataService
    {
        private readonly StubContainer<StubIBrightnessDataService> _stubs = new StubContainer<StubIBrightnessDataService>();

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.Brightness> global::EntMob6UWPApp.Services.IBrightnessDataService.GetAllBrightnesses()
        {
            return _stubs.GetMethodStub<GetAllBrightnesses_Delegate>("GetAllBrightnesses").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.Brightness> GetAllBrightnesses_Delegate();

        public StubIBrightnessDataService GetAllBrightnesses(GetAllBrightnesses_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::EntMob6UWP.Domain.Brightness global::EntMob6UWPApp.Services.IBrightnessDataService.GetLatestBrightness()
        {
            return _stubs.GetMethodStub<GetLatestBrightness_Delegate>("GetLatestBrightness").Invoke();
        }

        public delegate global::EntMob6UWP.Domain.Brightness GetLatestBrightness_Delegate();

        public StubIBrightnessDataService GetLatestBrightness(GetLatestBrightness_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace EntMob6UWPApp.Services
{
    [CompilerGenerated]
    public class StubIFrameNavigation : IFrameNavigation
    {
        private readonly StubContainer<StubIFrameNavigation> _stubs = new StubContainer<StubIFrameNavigation>();

        void global::EntMob6UWPApp.Services.IFrameNavigation.NavigateToFrame(global::System.Type frame)
        {
            _stubs.GetMethodStub<NavigateToFrame_Type_Delegate>("NavigateToFrame").Invoke(frame);
        }

        public delegate void NavigateToFrame_Type_Delegate(global::System.Type frame);

        public StubIFrameNavigation NavigateToFrame(NavigateToFrame_Type_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace EntMob6UWPApp.Services
{
    [CompilerGenerated]
    public class StubIHumidityAverageDataService : IHumidityAverageDataService
    {
        private readonly StubContainer<StubIHumidityAverageDataService> _stubs = new StubContainer<StubIHumidityAverageDataService>();

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.HumidityAverage> global::EntMob6UWPApp.Services.IHumidityAverageDataService.GetAllHumidityAveragesMinute()
        {
            return _stubs.GetMethodStub<GetAllHumidityAveragesMinute_Delegate>("GetAllHumidityAveragesMinute").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.HumidityAverage> GetAllHumidityAveragesMinute_Delegate();

        public StubIHumidityAverageDataService GetAllHumidityAveragesMinute(GetAllHumidityAveragesMinute_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.HumidityAverage> global::EntMob6UWPApp.Services.IHumidityAverageDataService.GetAllHumidityAveragesHour()
        {
            return _stubs.GetMethodStub<GetAllHumidityAveragesHour_Delegate>("GetAllHumidityAveragesHour").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.HumidityAverage> GetAllHumidityAveragesHour_Delegate();

        public StubIHumidityAverageDataService GetAllHumidityAveragesHour(GetAllHumidityAveragesHour_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.HumidityAverage> global::EntMob6UWPApp.Services.IHumidityAverageDataService.GetAllHumidityAveragesDay()
        {
            return _stubs.GetMethodStub<GetAllHumidityAveragesDay_Delegate>("GetAllHumidityAveragesDay").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.HumidityAverage> GetAllHumidityAveragesDay_Delegate();

        public StubIHumidityAverageDataService GetAllHumidityAveragesDay(GetAllHumidityAveragesDay_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.HumidityAverage> global::EntMob6UWPApp.Services.IHumidityAverageDataService.GetAllHumidityAveragesMonth()
        {
            return _stubs.GetMethodStub<GetAllHumidityAveragesMonth_Delegate>("GetAllHumidityAveragesMonth").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.HumidityAverage> GetAllHumidityAveragesMonth_Delegate();

        public StubIHumidityAverageDataService GetAllHumidityAveragesMonth(GetAllHumidityAveragesMonth_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace EntMob6UWPApp.Services
{
    [CompilerGenerated]
    public class StubIHumidityDataService : IHumidityDataService
    {
        private readonly StubContainer<StubIHumidityDataService> _stubs = new StubContainer<StubIHumidityDataService>();

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.Humidity> global::EntMob6UWPApp.Services.IHumidityDataService.GetAllHumidities()
        {
            return _stubs.GetMethodStub<GetAllHumidities_Delegate>("GetAllHumidities").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.Humidity> GetAllHumidities_Delegate();

        public StubIHumidityDataService GetAllHumidities(GetAllHumidities_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::EntMob6UWP.Domain.Humidity global::EntMob6UWPApp.Services.IHumidityDataService.GetLatestHumidity()
        {
            return _stubs.GetMethodStub<GetLatestHumidity_Delegate>("GetLatestHumidity").Invoke();
        }

        public delegate global::EntMob6UWP.Domain.Humidity GetLatestHumidity_Delegate();

        public StubIHumidityDataService GetLatestHumidity(GetLatestHumidity_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace EntMob6UWPApp.Services
{
    [CompilerGenerated]
    public class StubITemperatureAverageDataService : ITemperatureAverageDataService
    {
        private readonly StubContainer<StubITemperatureAverageDataService> _stubs = new StubContainer<StubITemperatureAverageDataService>();

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.TemperatureAverage> global::EntMob6UWPApp.Services.ITemperatureAverageDataService.GetAllTemperatureAveragesMinute()
        {
            return _stubs.GetMethodStub<GetAllTemperatureAveragesMinute_Delegate>("GetAllTemperatureAveragesMinute").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.TemperatureAverage> GetAllTemperatureAveragesMinute_Delegate();

        public StubITemperatureAverageDataService GetAllTemperatureAveragesMinute(GetAllTemperatureAveragesMinute_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.TemperatureAverage> global::EntMob6UWPApp.Services.ITemperatureAverageDataService.GetAllTemperatureAveragesHour()
        {
            return _stubs.GetMethodStub<GetAllTemperatureAveragesHour_Delegate>("GetAllTemperatureAveragesHour").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.TemperatureAverage> GetAllTemperatureAveragesHour_Delegate();

        public StubITemperatureAverageDataService GetAllTemperatureAveragesHour(GetAllTemperatureAveragesHour_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.TemperatureAverage> global::EntMob6UWPApp.Services.ITemperatureAverageDataService.GetAllTemperatureAveragesDay()
        {
            return _stubs.GetMethodStub<GetAllTemperatureAveragesDay_Delegate>("GetAllTemperatureAveragesDay").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.TemperatureAverage> GetAllTemperatureAveragesDay_Delegate();

        public StubITemperatureAverageDataService GetAllTemperatureAveragesDay(GetAllTemperatureAveragesDay_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.TemperatureAverage> global::EntMob6UWPApp.Services.ITemperatureAverageDataService.GetAllTemperatureAveragesMonth()
        {
            return _stubs.GetMethodStub<GetAllTemperatureAveragesMonth_Delegate>("GetAllTemperatureAveragesMonth").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.TemperatureAverage> GetAllTemperatureAveragesMonth_Delegate();

        public StubITemperatureAverageDataService GetAllTemperatureAveragesMonth(GetAllTemperatureAveragesMonth_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace EntMob6UWPApp.Services
{
    [CompilerGenerated]
    public class StubITemperatureDataService : ITemperatureDataService
    {
        private readonly StubContainer<StubITemperatureDataService> _stubs = new StubContainer<StubITemperatureDataService>();

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.Temperature> global::EntMob6UWPApp.Services.ITemperatureDataService.GetAllTemperatures()
        {
            return _stubs.GetMethodStub<GetAllTemperatures_Delegate>("GetAllTemperatures").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.Temperature> GetAllTemperatures_Delegate();

        public StubITemperatureDataService GetAllTemperatures(GetAllTemperatures_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::EntMob6UWP.Domain.Temperature global::EntMob6UWPApp.Services.ITemperatureDataService.GetLatestTemperature()
        {
            return _stubs.GetMethodStub<GetLatestTemperature_Delegate>("GetLatestTemperature").Invoke();
        }

        public delegate global::EntMob6UWP.Domain.Temperature GetLatestTemperature_Delegate();

        public StubITemperatureDataService GetLatestTemperature(GetLatestTemperature_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}