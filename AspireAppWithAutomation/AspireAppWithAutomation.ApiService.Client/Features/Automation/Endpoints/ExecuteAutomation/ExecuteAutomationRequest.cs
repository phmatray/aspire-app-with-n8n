namespace AspireAppWithAutomation.ApiService.Client.Features.Automation.Endpoints.ExecuteAutomation;

/// <summary>
/// Request model for ExecuteAutomationHandler
/// </summary>
public sealed class ExecuteAutomationRequest(
    string firstName = "",
    string lastName = "")
    : IRequest<ExecuteAutomationResponse>
{
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;
}
