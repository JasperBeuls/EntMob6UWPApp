using EntMob6UWP.DAL;
using EntMob6UWP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntMob6UWPApp.Services
{
    public class AirPressureAverageDataService : IAirPressureAverageDataService
    {
        IAirPressureRepository repository = new AirPressureRepository();
        public List<AirPressureAverage> GetAllAirPressureAveragesMinute()
        {
            return repository.GetAllAirPressureAveragesMinute();
        }
        public List<AirPressureAverage> GetAllAirPressureAveragesHour()
        {
            return repository.GetAllAirPressureAveragesHour();
        }
        public List<AirPressureAverage> GetAllAirPressureAveragesDay()
        {
            return repository.GetAllAirPressureAveragesDay();
        }
        public List<AirPressureAverage> GetAllAirPressureAveragesMonth()
        {
            return repository.GetAllAirPressureAveragesMonth();
        }

    }
}
