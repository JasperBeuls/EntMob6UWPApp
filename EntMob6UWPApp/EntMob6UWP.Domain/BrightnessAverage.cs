using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntMob6UWP.Domain
{
    public class BrightnessAverage : IAverage
    {
        public string ID { get; set; }
        [JsonProperty(PropertyName = "date")]
        [JsonConverter(typeof(MilisecondEpochConverter))]
        public DateTime Date { get; set; }
        [JsonProperty("avVal")]
        public double AvgValue { get; set; }

        public double Average
        {
            get
            {
                return AvgValue;
            }
        }
    }
}
