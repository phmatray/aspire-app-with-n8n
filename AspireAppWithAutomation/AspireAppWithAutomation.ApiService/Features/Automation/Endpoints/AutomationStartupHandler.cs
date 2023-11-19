using AspireAppWithAutomation.ApiService.Client.Features.Automation.Endpoints.GetStartupInfo;
using MediatR;

namespace AspireAppWithAutomation.ApiService.Features.Automation.Endpoints.GetStartupInfo;

public sealed class AutomationStartupHandler(IConfiguration configuration)
    : IRequestHandler<AutomationStartupRequest, IResult>
{
    public Task<IResult> Handle(AutomationStartupRequest request, CancellationToken cancellationToken)
    {
        var result = new AutomationStartupResponse(configuration["N8N_URL"]!);
        return Task.FromResult(Results.Ok(result));
    }
}