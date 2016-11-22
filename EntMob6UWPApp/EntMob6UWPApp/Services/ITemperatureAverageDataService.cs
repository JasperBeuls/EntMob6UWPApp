using EntMob6UWP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntMob6UWPApp.Services
{
    public interface ITemperatureAverageDataService
    {
        List<TemperatureAverage> GetAllTemperatureAveragesMinute();
        List<TemperatureAverage> GetAllTemperatureAveragesHour();
        List<TemperatureAverage> GetAllTemperatureAveragesDay();
        List<TemperatureAverage> GetAllTemperatureAveragesMonth();
    }
}
