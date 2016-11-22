using System.Collections.Generic;
using EntMob6UWP.Domain;


namespace EntMob6UWP.DAL
{
    public interface IBrightnessRepository
    {
        Brightness GetLatestBrightness();
        List<Brightness> GetAllBrightnesses();
        List<BrightnessAverage> GetAllBrightnessAveragesMinute();
        List<BrightnessAverage> GetAllBrightnessAveragesHour();
        List<BrightnessAverage> GetAllBrightnessAveragesDay();
        List<BrightnessAverage> GetAllBrightnessAveragesMonth();
    }
}
