using System.Collections.Generic;
using EntMob6UWP.DAL;
using EntMob6UWP.Domain;

namespace EntMob6UWPApp.Services
{
    public class HumidityAverageDataService
    {
        IEntMob6Repository repository = new EntMob6APIRepository();
        public List<HumidityAverage> GetAllHumidityAverages()
        {
            return repository.GetAllHumidityAverages();
        }

        public List<HumidityAverage> GetAllHumidityAveragesTest()
        {
            return repository.LoadHumidityAverages();
        }
    }
}