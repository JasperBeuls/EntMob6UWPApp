using System;

namespace EntMob6UWP.Domain
{
    public class HumidityAverage
    {
        public string ID { get; set; }
        public DateTime Date { get; set; }
        public double AvgPercent { get; set; }
    }
}