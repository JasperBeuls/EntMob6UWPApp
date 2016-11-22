using EntMob6UWP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntMob6UWPApp.Services
{
    public interface IAirPressureAverageDataService
    {
        List<AirPressureAverage> GetAllAirPressureAveragesMinute();
        List<AirPressureAverage> GetAllAirPressureAveragesHour();
        List<AirPressureAverage> GetAllAirPressureAveragesDay();
        List<AirPressureAverage> GetAllAirPressureAveragesMonth();
    }
}
