using MediatR;

namespace AspireAppWithAutomation.ApiService.Core.Abstractions;

public interface IHttpRequest
    : IRequest<IResult>;