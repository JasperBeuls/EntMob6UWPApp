using System;
using Newtonsoft.Json;

namespace EntMob6UWP.Domain
{
    public class HumidityAverage : IAverage
    {
        public string ID { get; set; }
        [JsonProperty(PropertyName = "date")]
        [JsonConverter(typeof(MilisecondEpochConverter))]
        public DateTime Date { get; set; }
        public double AvPer { get; set; }

        public double Average
        {
            get
            {
                return AvPer;
            }

        }
    }
}