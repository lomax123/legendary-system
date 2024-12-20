namespace FrontEnd.Data
{
    public class WeatherForecastClient(HttpClient httpClient, ILogger<WeatherForecastClient> logger)
    {
        private readonly HttpClient _httpClient = httpClient;
        private readonly ILogger<WeatherForecastClient> _logger = logger;

        public async Task<WeatherForecast[]> GetForecastAsync(DateTime? startDate)
        {
            var result = await _httpClient.GetFromJsonAsync<WeatherForecast[]>($"WeatherForecast?startDate={startDate}");
            return result ?? throw new Exception("Weather forecast data is null.");
        }
    }
}