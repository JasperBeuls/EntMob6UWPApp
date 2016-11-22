using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntMob6UWP.Domain
{
    public class AirPressure
    {
        public string ID { get; set; }

        public double Value { get; set; }
        [JsonProperty(PropertyName = "measured")]
        [JsonConverter(typeof(MilisecondEpochConverter))]
        public DateTime Measured { get; set; }
    }
}
