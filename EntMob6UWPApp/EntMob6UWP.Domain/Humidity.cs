using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace EntMob6UWP.Domain
{
    public class Humidity
    {
     
        public string ID { get; set; }

        public double Percentage { get; set; }
        public DateTime Measured { get; set; }
    }
}
