using EntMob6UWP.DAL;
using EntMob6UWP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntMob6UWPApp.Services
{
    public class BrightnessDataService : IBrightnessDataService
    {
        IBrightnessRepository repository = new BrightnessRepository();

        public List<Brightness> GetAllBrightnesses()
        {
            return repository.GetAllBrightnesses();
        }

        public Brightness GetLatestBrightness()
        {
            return repository.GetLatestBrightness();
        }
    }
}
