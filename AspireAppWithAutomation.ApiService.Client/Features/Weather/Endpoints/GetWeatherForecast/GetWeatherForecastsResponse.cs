using AspireAppWithAutomation.ApiService.Client.Features.Weather.Models;

namespace AspireAppWithAutomation.ApiService.Client.Features.Weather.Endpoints.GetWeatherForecast;

public record GetWeatherForecastsResponse(WeatherForecast[] Forecasts);