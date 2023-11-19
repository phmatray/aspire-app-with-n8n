using AspireAppWithAutomation.ApiService.Core.Abstractions;

namespace AspireAppWithAutomation.ApiService.Features.Automation.Endpoints.ExecuteAutomation;

/// <summary>
/// Request model for ExecuteAutomationHandler
/// </summary>
/// <param name="firstName">The first name of the person to search for on Google.</param>
/// <param name="lastName">The last name of the person to search for on Google.</param>
public sealed class ExecuteAutomationRequest(string firstName, string lastName)
    : IHttpRequest
{
    public string FirstName { get; } = firstName;
    public string LastName { get; } = lastName;
}