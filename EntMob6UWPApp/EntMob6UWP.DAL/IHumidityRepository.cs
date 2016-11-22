using System.Collections.Generic;
using EntMob6UWP.Domain;

namespace EntMob6UWP.DAL
{
    public interface IHumidityRepository
    {
        Humidity GetLatestHumidity();
        List<Humidity> GetAllHumidities();
        List<HumidityAverage> GetAllHumidityAveragesMinute();
        List<HumidityAverage> GetAllHumidityAveragesHour();
        List<HumidityAverage> GetAllHumidityAveragesDay();
        List<HumidityAverage> GetAllHumidityAveragesMonth();
    }
}