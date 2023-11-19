namespace AspireAppWithAutomation.ApiService.Features.Weather;

public static class WeatherSummaries
{
    private static readonly string[] Summaries =
    {
        "Freezing",
        "Bracing",
        "Chilly",
        "Cool",
        "Mild",
        "Warm",
        "Balmy",
        "Hot",
        "Sweltering",
        "Scorching"
    };
    
    public static string GetRandomWeatherSummary()
        => Summaries[Random.Shared.Next(Summaries.Length)];
}