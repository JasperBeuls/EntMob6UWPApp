using EntMob6UWP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntMob6UWP.DAL
{
    public interface IAirPressureRepository
    {

        AirPressure GetLatestAirPressure();
        List<AirPressure> GetAllAirPressures();
        List<AirPressureAverage> GetAllAirPressureAveragesMinute();
        List<AirPressureAverage> GetAllAirPressureAveragesHour();
        List<AirPressureAverage> GetAllAirPressureAveragesDay();
        List<AirPressureAverage> GetAllAirPressureAveragesMonth();
    }
}
