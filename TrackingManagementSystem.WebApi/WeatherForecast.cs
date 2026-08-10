namespace TrackingManagementSystem.WebApi
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC * (9d / 5d));

        public string? Summary { get; set; }
    }
}
