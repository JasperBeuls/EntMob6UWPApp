using System.Collections.Generic;
using EntMob6UWP.Domain;
using System;
using EntMob6UWP.DAL;

namespace EntMob6UWPApp.Services
{
    public class HumidityDataService : IHumidityDataService
    {
        IHumidityRepository repository = new HumidityRepository();

        public List<Humidity> GetAllHumidities()
        {
            return repository.GetAllHumidities();
        }

        public Humidity GetLatestHumidity()
        {
            return repository.GetLatestHumidity();
        }
    }
}