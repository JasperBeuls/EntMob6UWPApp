using EntMob6UWP.DAL;
using EntMob6UWP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntMob6UWPApp.Services
{
    class BrightnessAverageDataService : IBrightnessAverageDataService
    {
        IBrightnessRepository repository = new BrightnessRepository();
        public List<BrightnessAverage> GetAllBrightnessAveragesMinute()
        {
            return repository.GetAllBrightnessAveragesMinute();
        }
        public List<BrightnessAverage> GetAllBrightnessAveragesHour()
        {
            return repository.GetAllBrightnessAveragesHour();
        }
        public List<BrightnessAverage> GetAllBrightnessAveragesDay()
        {
            return repository.GetAllBrightnessAveragesDay();
        }
        public List<BrightnessAverage> GetAllBrightnessAveragesMonth()
        {
            return repository.GetAllBrightnessAveragesMonth();
        }

    }
}
