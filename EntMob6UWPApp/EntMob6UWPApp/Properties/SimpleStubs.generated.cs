using System;
using System.Runtime.CompilerServices;
using Etg.SimpleStubs;
using System.Collections.Generic;
using EntMob6UWP.Domain;

namespace EntMob6UWP.DAL
{
    [CompilerGenerated]
    public class StubIEntMob6Repository : IEntMob6Repository
    {
        private readonly StubContainer<StubIEntMob6Repository> _stubs = new StubContainer<StubIEntMob6Repository>();

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.Humidity> global::EntMob6UWP.DAL.IEntMob6Repository.GetAllHumidities()
        {
            return _stubs.GetMethodStub<GetAllHumidities_Delegate>("GetAllHumidities").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.Humidity> GetAllHumidities_Delegate();

        public StubIEntMob6Repository GetAllHumidities(GetAllHumidities_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.Humidity> global::EntMob6UWP.DAL.IEntMob6Repository.LoadHumidities()
        {
            return _stubs.GetMethodStub<LoadHumidities_Delegate>("LoadHumidities").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.Humidity> LoadHumidities_Delegate();

        public StubIEntMob6Repository LoadHumidities(LoadHumidities_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.HumidityAverage> global::EntMob6UWP.DAL.IEntMob6Repository.GetAllHumidityAveragesMinute()
        {
            return _stubs.GetMethodStub<GetAllHumidityAveragesMinute_Delegate>("GetAllHumidityAveragesMinute").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.HumidityAverage> GetAllHumidityAveragesMinute_Delegate();

        public StubIEntMob6Repository GetAllHumidityAveragesMinute(GetAllHumidityAveragesMinute_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.HumidityAverage> global::EntMob6UWP.DAL.IEntMob6Repository.GetAllHumidityAveragesHour()
        {
            return _stubs.GetMethodStub<GetAllHumidityAveragesHour_Delegate>("GetAllHumidityAveragesHour").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.HumidityAverage> GetAllHumidityAveragesHour_Delegate();

        public StubIEntMob6Repository GetAllHumidityAveragesHour(GetAllHumidityAveragesHour_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.HumidityAverage> global::EntMob6UWP.DAL.IEntMob6Repository.GetAllHumidityAveragesDay()
        {
            return _stubs.GetMethodStub<GetAllHumidityAveragesDay_Delegate>("GetAllHumidityAveragesDay").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.HumidityAverage> GetAllHumidityAveragesDay_Delegate();

        public StubIEntMob6Repository GetAllHumidityAveragesDay(GetAllHumidityAveragesDay_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.HumidityAverage> global::EntMob6UWP.DAL.IEntMob6Repository.GetAllHumidityAveragesMonth()
        {
            return _stubs.GetMethodStub<GetAllHumidityAveragesMonth_Delegate>("GetAllHumidityAveragesMonth").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.HumidityAverage> GetAllHumidityAveragesMonth_Delegate();

        public StubIEntMob6Repository GetAllHumidityAveragesMonth(GetAllHumidityAveragesMonth_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.List<global::EntMob6UWP.Domain.HumidityAverage> global::EntMob6UWP.DAL.IEntMob6Repository.LoadHumidityAverages()
        {
            return _stubs.GetMethodStub<LoadHumidityAverages_Delegate>("LoadHumidityAverages").Invoke();
        }

        public delegate global::System.Collections.Generic.List<global::EntMob6UWP.Domain.HumidityAverage> LoadHumidityAverages_Delegate();

        public StubIEntMob6Repository LoadHumidityAverages(LoadHumidityAverages_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::EntMob6UWP.Domain.Account global::EntMob6UWP.DAL.IEntMob6Repository.GetAccount(string username, string password)
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