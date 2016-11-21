using System.Collections.Generic;
using EntMob6UWP.Domain;
using System;
using EntMob6UWP.DAL;

namespace EntMob6UWPApp.Services
{
    public class HumidityDataService : IHumidityDataService
    {
        IEntMob6Repository repository = new EntMob6APIRepository();

        public List<Humidity> GetAllHumidities()
        {
            return repository.GetAllHumidities();
        }
    }
}