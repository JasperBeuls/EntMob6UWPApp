using System;
using System.Runtime.CompilerServices;
using Etg.SimpleStubs;
using System.Collections.Generic;
using EntMob6UWP.Domain;

namespace EntMob6UWP.DAL
{
    [CompilerGenerated]
    public class StubIEntMob6Repository : IHumidityRepository
    {
        private readonly StubContainer<StubIEntMob6Repository> _stubs = new StubContainer<StubIEntMob6Repository>();

        global::EntMob6UWP.Domain.Humidity global::EntMob6UWP.DAL.IHumidityRepository.GetLatestHumidity()
        {
            return _stubs.GetMethodStub<GetLatestHumidity_Delegate>("GetLatestHumidity").Invoke();
        }

        public delegate global::EntMob6UWP.Domain.Humidity GetLatestHumidity_Delegate();

        public StubIEntMob6Repository GetLatestHumidity(GetLatestHumidity_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.Humidity> global::EntMob6UWP.DAL.IHumidityRepository.GetAllHumidities()
        {
            return _stubs.GetMethodStub<GetAllHumidities_Delegate>("GetAllHumidities").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.Humidity> GetAllHumidities_Delegate();

        public StubIEntMob6Repository GetAllHumidities(GetAllHumidities_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.Humidity> global::EntMob6UWP.DAL.IHumidityRepository.LoadHumidities()
        {
            return _stubs.GetMethodStub<LoadHumidities_Delegate>("LoadHumidities").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.Humidity> LoadHumidities_Delegate();

        public StubIEntMob6Repository LoadHumidities(LoadHumidities_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.HumidityAverage> global::EntMob6UWP.DAL.IHumidityRepository.GetAllHumidityAveragesMinute()
        {
            return _stubs.GetMethodStub<GetAllHumidityAveragesMinute_Delegate>("GetAllHumidityAveragesMinute").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.HumidityAverage> GetAllHumidityAveragesMinute_Delegate();

        public StubIEntMob6Repository GetAllHumidityAveragesMinute(GetAllHumidityAveragesMinute_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.HumidityAverage> global::EntMob6UWP.DAL.IHumidityRepository.GetAllHumidityAveragesHour()
        {
            return _stubs.GetMethodStub<GetAllHumidityAveragesHour_Delegate>("GetAllHumidityAveragesHour").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.HumidityAverage> GetAllHumidityAveragesHour_Delegate();

        public StubIEntMob6Repository GetAllHumidityAveragesHour(GetAllHumidityAveragesHour_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.HumidityAverage> global::EntMob6UWP.DAL.IHumidityRepository.GetAllHumidityAveragesDay()
        {
            return _stubs.GetMethodStub<GetAllHumidityAveragesDay_Delegate>("GetAllHumidityAveragesDay").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.HumidityAverage> GetAllHumidityAveragesDay_Delegate();

        public StubIEntMob6Repository GetAllHumidityAveragesDay(GetAllHumidityAveragesDay_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.HumidityAverage> global::EntMob6UWP.DAL.IHumidityRepository.GetAllHumidityAveragesMonth()
        {
            return _stubs.GetMethodStub<GetAllHumidityAveragesMonth_Delegate>("GetAllHumidityAveragesMonth").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.HumidityAverage> GetAllHumidityAveragesMonth_Delegate();

        public StubIEntMob6Repository GetAllHumidityAveragesMonth(GetAllHumidityAveragesMonth_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.HumidityAverage> global::EntMob6UWP.DAL.IHumidityRepository.LoadHumidityAverages()
        {
            return _stubs.GetMethodStub<LoadHumidityAverages_Delegate>("LoadHumidityAverages").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.HumidityAverage> LoadHumidityAverages_Delegate();

        public StubIEntMob6Repository LoadHumidityAverages(LoadHumidityAverages_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::EntMob6UWP.Domain.Account global::EntMob6UWP.DAL.IHumidityRepository.GetAccount(string username, string password)
        {
            return _stubs.GetMethodStub<GetAccount_String_String_Delegate>("GetAccount").Invoke(username, password);
        }

        public delegate global::EntMob6UWP.Domain.Account GetAccount_String_String_Delegate(string username, string password);

        public StubIEntMob6Repository GetAccount(GetAccount_String_String_Delegate del, int count = Times.Forever, bool overwrite = false)
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

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.HumidityAverage> global::EntMob6UWPApp.Services.IHumidityAverageDataService.GetAllHumidityAveragesTest()
        {
            return _stubs.GetMethodStub<GetAllHumidityAveragesTest_Delegate>("GetAllHumidityAveragesTest").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.HumidityAverage> GetAllHumidityAveragesTest_Delegate();

        public StubIHumidityAverageDataService GetAllHumidityAveragesTest(GetAllHumidityAveragesTest_Delegate del, int count = Times.Forever, bool overwrite = false)
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