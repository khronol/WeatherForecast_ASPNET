using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherForecast.OpenWeatherMap.Model
{
    public class Main
    {
        public float Temp { get; set; }
        public float FeelsLike { get; set; }

        public float TempMin { get; set; }
        public float TempMax { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
    }
}
