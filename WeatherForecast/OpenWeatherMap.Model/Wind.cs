using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherForecast.OpenWeatherMap.Model
{
    public class Wind
    {
        public float Speed { get; set; }
        public int Deg { get; set; }

        public float Gust { get; set; }
    }
}
