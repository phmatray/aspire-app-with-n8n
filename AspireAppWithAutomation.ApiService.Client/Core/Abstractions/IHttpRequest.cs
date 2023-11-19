using MediatR;
using Microsoft.AspNetCore.Http;

namespace AspireAppWithAutomation.ApiService.Client.Core.Abstractions;

public interface IHttpRequest
    : IRequest<IResult>;