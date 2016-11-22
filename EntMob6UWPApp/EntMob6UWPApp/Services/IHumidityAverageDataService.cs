using System.Collections.Generic;
using EntMob6UWP.Domain;

namespace EntMob6UWPApp.Services
{
    public interface IHumidityAverageDataService
    {
        List<HumidityAverage> GetAllHumidityAveragesMinute();
        List<HumidityAverage> GetAllHumidityAveragesHour();
        List<HumidityAverage> GetAllHumidityAveragesDay();
        List<HumidityAverage> GetAllHumidityAveragesMonth();
    }
}