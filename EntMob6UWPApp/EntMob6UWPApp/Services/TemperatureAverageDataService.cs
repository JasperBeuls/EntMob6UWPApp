using EntMob6UWP.DAL;
using EntMob6UWP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntMob6UWPApp.Services
{
    class TemperatureAverageDataService : ITemperatureAverageDataService
    {
        ITemperatureRepository repository = new TemperatureRepository();
        public List<TemperatureAverage> GetAllTemperatureAveragesMinute()
        {
            return repository.GetAllTemperatureAveragesMinute();
        }
        public List<TemperatureAverage> GetAllTemperatureAveragesHour()
        {
            return repository.GetAllTemperatureAveragesHour();
        }
        public List<TemperatureAverage> GetAllTemperatureAveragesDay()
        {
            return repository.GetAllTemperatureAveragesDay();
        }
        public List<TemperatureAverage> GetAllTemperatureAveragesMonth()
        {
            return repository.GetAllTemperatureAveragesMonth();
        }

    }
}

