using System.Collections.Generic;
using EntMob6UWP.Domain;
using System;
using EntMob6UWP.DAL;

namespace EntMob6UWPApp.Services
{
    public class HumidityDataService
    {
        IEntMob6Repository repository = new EntMob6APIRepository();
        public Humidity GetHumidityDetail(string Id)
        {
            return repository.GetHumidityById(Id);
        }

        public List<Humidity> GetDataHumidities()
        {
            return repository.LoadHumidities();
        } 

        public List<Humidity> GetAllHumidities()
        {
            return repository.GetAllHumidities();
        }
    }
}