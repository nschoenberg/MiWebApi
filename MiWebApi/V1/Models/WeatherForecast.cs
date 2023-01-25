namespace MiWebApi.V1.Models
{
    /// <summary>
    /// Represents the forecast data for weather.
    /// </summary>
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        /// <summary>
        /// Temp in celsius
        /// </summary>
        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        /// <summary>
        /// The summary
        /// </summary>
        public string? Summary { get; set; }
    }
}