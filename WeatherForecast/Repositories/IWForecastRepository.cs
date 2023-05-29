using WeatherForecast.OpenWeatherMap.Model;

namespace WeatherForecast.Repositories
{
    public interface IWForecastRepository
    {
        WeatherResponse GetForecast(string city);
    }
}
