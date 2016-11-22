using EntMob6UWP.DAL;
using EntMob6UWP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntMob6UWPApp.Services
{
    public class TemperatureDataService : ITemperatureDataService
    {
        ITemperatureRepository repository = new TemperatureRepository();

        public List<Temperature> GetAllTemperatures()
        {
            return repository.GetAllTemperatures();
        }

        public Temperature GetLatestTemperature()
        {
            return repository.GetLatestTemperature();
        }
    }
}