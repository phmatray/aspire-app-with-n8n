namespace AspireAppWithAutomation.AppHost.Extensions;

public static class N8NBuilderExtensions
{
    /// <summary>
    /// Adds a N8N container to the application model. The default image is "n8nio/n8n".
    /// </summary>
    /// <param name="builder">The <see cref="IDistributedApplicationBuilder"/>.</param>
    /// <param name="name">The name of the resource.</param>
    /// <param name="port">The host port for N8N.</param>
    /// <returns>A reference to the <see cref="IResourceBuilder{ContainerResource}"/>.</returns>
    public static IResourceBuilder<ContainerResource> AddN8NContainer(
        this IDistributedApplicationBuilder builder,
        string name = "n8n",
        int? port = 5678)
    {
        var timeZone = GetTimeZone();

        return builder
            .AddContainer(name, "n8nio/n8n")
            .WithEnvironment("GENERIC_TIMEZONE", timeZone)
            .WithEnvironment("TZ", timeZone)
            .WithVolumeMount("../containers/n8n/data", "/home/node/.n8n")
            .WithServiceBinding(
                containerPort: 5678, // Internal port is always 5678.
                hostPort: port,
                name: $"{name}-http",
                scheme: "http");
    }
    
    private static string GetTimeZone()
    {
        var timeZone = TimeZoneInfo.Local;
        return timeZone.Id;
    }
}
