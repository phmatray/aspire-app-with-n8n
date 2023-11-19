namespace AspireAppWithAutomation.ApiService.Features.Weather;

public sealed class WeatherForecastService
{
    public WeatherForecast[] GetWeatherForecasts()
        => GetRandomWeatherForecasts(5);
    
    public WeatherForecast GetRandomWeatherForecast(int index)
        => new(
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            WeatherSummaries.GetRandomWeatherSummary()
        );
    
    public WeatherForecast[] GetRandomWeatherForecasts(int count)
        => Enumerable
            .Range(1, count)
            .Select(GetRandomWeatherForecast)
            .ToArray();
}