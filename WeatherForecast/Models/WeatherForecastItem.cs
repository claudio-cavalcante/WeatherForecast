using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherForecast.Models
{
    public class WeatherForecastItem
    {
        [JsonIgnore]
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public int TemperatureInCelsius { get; set; }

        public int TemperatureInFahrenheit { get; set; }

        public string Summary { get; set; }
    }
}
