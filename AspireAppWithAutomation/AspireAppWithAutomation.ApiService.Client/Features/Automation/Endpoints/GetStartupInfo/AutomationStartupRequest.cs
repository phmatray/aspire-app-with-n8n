using AspireAppWithAutomation.ApiService.Client.Core.Abstractions;
using MediatR;

namespace AspireAppWithAutomation.ApiService.Client.Features.Automation.Endpoints.GetStartupInfo;

public record AutomationStartupRequest
    : IRequest<AutomationStartupResponse>;