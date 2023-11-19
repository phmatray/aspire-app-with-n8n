using Microsoft.Extensions.DependencyInjection;

namespace AspireAppWithAutomation.ApiService.Client;

public static class DependencyInjection
{
    public static IServiceCollection AddApiServiceHttpClient(this IServiceCollection services, string baseAddress)
    {
        services.AddHttpClient<ApiServiceHttpClient>(client =>
        {
            client.BaseAddress = new Uri(baseAddress);
        });

        return services;
    }
}