using MediatR;

namespace AspireAppWithAutomation.ApiService.Client.Core.Abstractions;

public interface IHttpRequest
    : IRequest<HttpResponseMessage>;