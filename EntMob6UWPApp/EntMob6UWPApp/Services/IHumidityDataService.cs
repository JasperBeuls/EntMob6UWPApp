using System.Collections.Generic;
using EntMob6UWP.Domain;

namespace EntMob6UWPApp.Services
{
    public interface IHumidityDataService
    {
        List<Humidity> GetAllHumidities();
        Humidity GetLatestHumidity();
    }
}