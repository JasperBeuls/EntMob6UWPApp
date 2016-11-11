using System.Collections.Generic;
using EntMob6UWP.Domain;

namespace EntMob6UWP.DAL
{
    public interface IEntMob6Repository
    {
        Humidity GetHumidityById(string Id);
        List<Humidity> GetAllHumidities();
        List<Humidity> LoadHumidities();
        List<HumidityAverage> GetAllHumidityAverages();
        List<HumidityAverage> LoadHumidityAverages();
    }
}