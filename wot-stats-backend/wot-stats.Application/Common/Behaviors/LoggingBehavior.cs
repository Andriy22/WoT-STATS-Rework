using MediatR;
using Serilog;
using wot_stats.Application.Interfaces;

namespace wot_stats.Application.Common.Behaviors;

public class LoggingBehavior<TRequest, TResponse>
    : IPipelineBehavior<TRequest, TResponse> where TRequest
    : IRequest<TResponse>
{
    private readonly ICurrentUserService _currentUserService;

    public LoggingBehavior(ICurrentUserService currentUserService)
    {
        _currentUserService = currentUserService;
    }

    public async Task<TResponse> Handle(TRequest request,
        RequestHandlerDelegate<TResponse> next,
        CancellationToken cancellation)
    {
        var requestName = typeof(TRequest).Name;
        var userId = _currentUserService.UserId;

        Log.Information("Request: {Name}, {@UserId} {@Request}",
            requestName, userId, request);

        var response = await next();

        return response;
    }
}
