using EntMob6UWP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntMob6UWP.DAL
{
    public interface ITemperatureRepository
    {
        Temperature GetLatestTemperature();
        List<Temperature> GetAllTemperatures();
        List<TemperatureAverage> GetAllTemperatureAveragesMinute();
        List<TemperatureAverage> GetAllTemperatureAveragesHour();
        List<TemperatureAverage> GetAllTemperatureAveragesDay();
        List<TemperatureAverage> GetAllTemperatureAveragesMonth();
    }
}