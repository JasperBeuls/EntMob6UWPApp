﻿using System.Collections.Generic;
using EntMob6UWP.DAL;
using EntMob6UWP.Domain;

namespace EntMob6UWPApp.Services
{
    public class HumidityAverageDataService
    {
        IEntMob6Repository repository = new EntMob6APIRepository();
        public List<HumidityAverage> GetAllHumidityAveragesMinute()
        {
            return repository.GetAllHumidityAveragesMinute();
        }
        public List<HumidityAverage> GetAllHumidityAveragesHour()
        {
            return repository.GetAllHumidityAveragesHour();
        }
        public List<HumidityAverage> GetAllHumidityAveragesDay()
        {
            return repository.GetAllHumidityAveragesDay();
        }
        public List<HumidityAverage> GetAllHumidityAveragesMonth()
        {
            return repository.GetAllHumidityAveragesMonth();
        }
        public List<HumidityAverage> GetAllHumidityAveragesTest()
        {
            return repository.LoadHumidityAverages();
        }
    }
}