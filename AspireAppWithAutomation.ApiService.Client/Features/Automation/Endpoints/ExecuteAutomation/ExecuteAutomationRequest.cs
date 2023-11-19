using AspireAppWithAutomation.ApiService.Client.Core.Abstractions;

namespace AspireAppWithAutomation.ApiService.Client.Features.Automation.Endpoints.ExecuteAutomation;

/// <summary>
/// Request model for ExecuteAutomationHandler
/// </summary>
/// <param name="firstName">The first name of the person to search for on Google.</param>
/// <param name="lastName">The last name of the person to search for on Google.</param>
public sealed class ExecuteAutomationRequest(
    string firstName = "",
    string lastName = "")
    : IHttpRequest
{
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;
}