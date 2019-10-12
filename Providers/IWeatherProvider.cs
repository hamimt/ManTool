using System.Collections.Generic;
using NetVue.Models;

namespace NetVue.Providers
{
    public interface IWeatherProvider
    {
        List<WeatherForecast> GetForecasts();
    }
}
