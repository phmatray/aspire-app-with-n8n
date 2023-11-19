using AspireAppWithAutomation.ApiService.Core.Extensions;
using AspireAppWithAutomation.ApiService.Features.Automation.Endpoints.ExecuteAutomation;
using AspireAppWithAutomation.ApiService.Features.Automation.Endpoints.GetStartupInfo;

namespace AspireAppWithAutomation.ApiService.Features.Automation.Endpoints;

/// <summary>
/// Automation endpoints registration.
/// </summary>
public static class AutomationEndpoints
{
    /// <summary>
    /// Register automation endpoints.
    /// </summary>
    /// <param name="app">Web application.</param>
    public static void RegisterAutomationEndpoints(this WebApplication app)
    {
        app
            // Define the base path for all endpoints in this group.
            .MapGroup("/api")
            .MapGroup("/v1")
            .MapGroup("/automation")
            // GET - startup info
            .MediateGet<AutomationStartupRequest>("startup")
            // GET - execute automation
            .MediateGet<ExecuteAutomationRequest>("execute-automation/{firstName}/{lastName}");
    }
}
