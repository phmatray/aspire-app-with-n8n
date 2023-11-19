using AspireAppWithAutomation.ApiService.Client.Features.Automation.Endpoints.GetStartupInfo;
using MediatR;

namespace AspireAppWithAutomation.ApiService.Features.Automation.Endpoints;

public sealed class AutomationStartupHandler(IConfiguration configuration)
    : IRequestHandler<AutomationStartupRequest, AutomationStartupResponse>
{
    public Task<AutomationStartupResponse> Handle(AutomationStartupRequest request, CancellationToken cancellationToken)
    {
        var result = new AutomationStartupResponse(configuration["N8N_URL"]!);
        return Task.FromResult(result);
    }
}