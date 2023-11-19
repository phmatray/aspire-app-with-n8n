using AspireAppWithAutomation.ApiService.Client.Features.Weather.Endpoints.GetWeatherForecast;
using AspireAppWithAutomation.ApiService.Core.Extensions;
using AspireAppWithAutomation.ApiService.Features.Weather.Endpoints.GetWeatherForecast;

namespace AspireAppWithAutomation.ApiService.Features.Weather.Endpoints;

/// <summary>
/// Weather endpoints registration.
/// </summary>
public static class WeatherEndpoints
{
    /// <summary>
    /// Register weather endpoints.
    /// </summary>
    /// <param name="app">Web application.</param>
    public static void RegisterWeatherEndpoints(this WebApplication app)
    {
        app
            // Define the base path for all endpoints in this group.
            .MapGroup("/api")
            .MapGroup("/v1")
            .MapGroup("/weather")
            // GET - weather forecasts
            .MediateGet<GetWeatherForecastsRequest>("weatherforecast");
    }
}