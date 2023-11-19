namespace AspireAppWithAutomation.ApiService.Core.Extensions;

// based on Write cleaner APIs in .NET 7 with MediatR by Nick Chapsas
// https://youtu.be/euUg_IHo7-s?si=WieVrF4tM8FVADLH&t=497

public static class MinimalApiMediatrExtensions
{
    public static IEndpointRouteBuilder MediateGet<TRequest>(
        this IEndpointRouteBuilder app, string template)
        where TRequest : IBaseRequest
    {
        app.MapGet(template, (IMediator mediator, [AsParameters] TRequest request)
            => mediator.Send(request));
        
        return app;
    }
    
    public static IEndpointRouteBuilder MediatePost<TRequest>(
        this IEndpointRouteBuilder app, string template)
        where TRequest : IBaseRequest
    {
        app.MapPost(template, (IMediator mediator, [AsParameters] TRequest request)
            => mediator.Send(request));
        
        return app;
    }
}