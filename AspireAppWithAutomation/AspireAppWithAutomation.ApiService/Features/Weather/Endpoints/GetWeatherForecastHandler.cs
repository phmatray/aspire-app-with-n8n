using AspireAppWithAutomation.ApiService.Client.Features.Weather.Endpoints.GetWeatherForecast;
using MediatR;

namespace AspireAppWithAutomation.ApiService.Features.Weather.Endpoints;

public sealed class GetWeatherForecastHandler(WeatherForecastService service)
    : IRequestHandler<GetWeatherForecastsRequest, GetWeatherForecastsResponse>
{
    public Task<GetWeatherForecastsResponse> Handle(
        GetWeatherForecastsRequest request,
        CancellationToken cancellationToken)
    {
        var forecasts = service.GetWeatherForecasts();
        var response = new GetWeatherForecastsResponse(forecasts);
        return Task.FromResult(response);
    }
}