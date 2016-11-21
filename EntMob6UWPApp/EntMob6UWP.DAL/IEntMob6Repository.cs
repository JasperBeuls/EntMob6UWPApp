using System.Collections.Generic;
using EntMob6UWP.Domain;

namespace EntMob6UWP.DAL
{
    public interface IEntMob6Repository
    {
        List<Humidity> GetAllHumidities();
        List<Humidity> LoadHumidities();
        List<HumidityAverage> GetAllHumidityAveragesMinute();
        List<HumidityAverage> GetAllHumidityAveragesHour();
        List<HumidityAverage> GetAllHumidityAveragesDay();
        List<HumidityAverage> GetAllHumidityAveragesMonth();
        List<HumidityAverage> LoadHumidityAverages();
        Account GetAccount(string username, string password);
    }
}