using EntMob6UWP.DAL;
using EntMob6UWP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntMob6UWPApp.Services
{
    class AirPressureDataService : IAirPressureDataService
    {
        IAirPressureRepository repository = new AirPressureRepository();

        public List<AirPressure> GetAllAirPressures()
        {
            return repository.GetAllAirPressures();
        }

        public AirPressure GetLatestAirPressure()
        {
            return repository.GetLatestAirPressure();
        }
    }
}
