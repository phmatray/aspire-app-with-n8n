namespace AspireAppWithAutomation.ApiService.Features.Weather.Endpoints.GetWeatherForecast;

public record GetWeatherForecastsResponse(
    IEnumerable<WeatherForecast> Forecasts);