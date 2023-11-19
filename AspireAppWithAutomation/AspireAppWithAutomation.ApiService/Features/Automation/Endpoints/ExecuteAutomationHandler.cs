using AspireAppWithAutomation.ApiService.Client.Features.Automation.Endpoints.ExecuteAutomation;
using MediatR;

namespace AspireAppWithAutomation.ApiService.Features.Automation.Endpoints;

public sealed class ExecuteAutomationHandler(IConfiguration configuration)
    : IRequestHandler<ExecuteAutomationRequest, ExecuteAutomationResponse>
{
    public async Task<ExecuteAutomationResponse> Handle(ExecuteAutomationRequest request, CancellationToken cancellationToken)
    {
        HttpClient client = new();
        var url = configuration["N8N_URL"]!;
        const string webhookEnv = "webhook";
        const string webhookId = "search-on-google";
        var webhookUrl = $"{url}/{webhookEnv}/{webhookId}";
        var query = new Dictionary<string, string>
        {
            ["first_name"] = request.FirstName,
            ["last_name"] = request.LastName
        };
        var requestUri = webhookUrl + ToQueryString(query);
        var response = await client.GetAsync(requestUri);
        var message = await response.Content.ReadAsStringAsync();
        
        return new ExecuteAutomationResponse(
            request.FirstName,
            request.LastName,
            message);
    }
    
    private static string ToQueryString(Dictionary<string, string> query)
    {
        var array = query.Select(kv => $"{kv.Key}={kv.Value}").ToArray();
        return "?" + string.Join("&", array);
    }
}