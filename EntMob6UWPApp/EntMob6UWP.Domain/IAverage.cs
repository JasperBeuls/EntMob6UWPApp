using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntMob6UWP.Domain
{
   public interface IAverage
    {
        
         DateTime Date { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        double Average { get;  }
    }
}
