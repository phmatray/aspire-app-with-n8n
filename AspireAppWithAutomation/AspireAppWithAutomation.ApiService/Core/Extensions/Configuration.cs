using AspireAppWithAutomation.ApiService.Features.Weather;

namespace AspireAppWithAutomation.ApiService.Core.Extensions;

public static class Configuration
{
    public static void RegisterServices(this WebApplicationBuilder builder)
    {
        // Add service defaults & Aspire components.
        builder.AddServiceDefaults();

        // Adds services required for creation of ProblemDetails for failed requests.
        builder.Services.AddProblemDetails();
        
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer().AddSwaggerGen();
        
        // Add MediatR
        builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<Program>());
        
        // Add application services.
        builder.Services.AddTransient<WeatherForecastService>();
    }

    public static void RegisterMiddlewares(this WebApplication app)
    {
        // Register .NET Aspire middlewares
        app.MapDefaultEndpoints();
        
        if (app.Environment.IsDevelopment())
        {
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();
            app.UseSwaggerUI();
        }
    }
}
