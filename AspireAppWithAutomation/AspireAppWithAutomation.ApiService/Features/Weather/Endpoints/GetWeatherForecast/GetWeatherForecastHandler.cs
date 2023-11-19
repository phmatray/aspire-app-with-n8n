using MediatR;

namespace AspireAppWithAutomation.ApiService.Features.Weather.Endpoints.GetWeatherForecast;

public sealed class GetWeatherForecastHandler(WeatherForecastService service)
    : IRequestHandler<GetWeatherForecastsRequest, IResult>
{
    public Task<IResult> Handle(
        GetWeatherForecastsRequest request,
        CancellationToken cancellationToken)
    {
        var forecasts = service.GetWeatherForecasts();
        var response = new GetWeatherForecastsResponse(forecasts);
        return Task.FromResult(Results.Ok(response));
    }
}