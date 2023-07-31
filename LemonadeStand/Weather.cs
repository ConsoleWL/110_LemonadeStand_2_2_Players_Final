using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Weather
    {
        public string condition;
        public int temperature;
        public List<string> weatherConditions;
        public string predictedForecast;
        public bool isWeatherChanged = false;

        public Weather()
        {
            weatherConditions = new List<string>
            {
                "Hot. Sunny. Clear Sky",
                "Warm. Sunny. Cloudy",
                "Cold. No sun. Cloudy"
            };
        }
    }
}
