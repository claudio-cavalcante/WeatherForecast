using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherForecast.Models;

namespace WeatherForecast.Data
{
    public class WeatherForecastItemDbContext : DbContext
    {
        public WeatherForecastItemDbContext(DbContextOptions<WeatherForecastItemDbContext> options) : base(options)
        {
        }

        public virtual DbSet<WeatherForecastItem> WeatherForecastItem { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WeatherForecastItem>().HasData(
                    new WeatherForecastItem { Id = 1, Date = new DateTime(2018,6,24), TemperatureInCelsius = 32, TemperatureInFahrenheit = 89, Summary = "Scorching" },
                    new WeatherForecastItem { Id = 2, Date = new DateTime(2018, 6, 24), TemperatureInCelsius = 45, TemperatureInFahrenheit = 112, Summary = "Mild" },
                    new WeatherForecastItem { Id = 3, Date = new DateTime(2018, 6, 24), TemperatureInCelsius = -4, TemperatureInFahrenheit = 25, Summary = "Mild" },
                    new WeatherForecastItem { Id = 4, Date = new DateTime(2018, 6, 24), TemperatureInCelsius = 16, TemperatureInFahrenheit = 60, Summary = "Balmy" },
                    new WeatherForecastItem { Id = 5, Date = new DateTime(2018, 6, 24), TemperatureInCelsius = 53, TemperatureInFahrenheit = 127, Summary = "Hot" }
                );
        }
    }
}
