using System.Net.Http.Json;
using AspireAppWithAutomation.ApiService.Client.Features.Automation.Endpoints.ExecuteAutomation;
using AspireAppWithAutomation.ApiService.Client.Features.Automation.Endpoints.GetStartupInfo;
using AspireAppWithAutomation.ApiService.Client.Features.Weather.Endpoints.GetWeatherForecast;

namespace AspireAppWithAutomation.ApiService.Client;

public class ApiServiceHttpClient(HttpClient httpClient)
{
    public Task<AutomationStartupResponse?> GetStartupInfoAsync()
        => httpClient.GetFromJsonAsync<AutomationStartupResponse>(
            "/api/v1/automation/startup");
    
    public Task<ExecuteAutomationResponse?> ExecuteAutomationAsync(ExecuteAutomationRequest request)
        => httpClient.GetFromJsonAsync<ExecuteAutomationResponse>(
            $"/api/v1/automation/execute-automation/{request.FirstName}/{request.LastName}");
    
    public Task<GetWeatherForecastsResponse?> GetWeatherAsync()
        => httpClient.GetFromJsonAsync<GetWeatherForecastsResponse>(
            "/api/v1/weather/weatherforecast");
}