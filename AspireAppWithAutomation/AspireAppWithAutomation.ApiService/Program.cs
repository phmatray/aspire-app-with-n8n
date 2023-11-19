using AspireAppWithAutomation.ApiService.Core.Extensions;
using AspireAppWithAutomation.ApiService.Features.Automation.Endpoints;
using AspireAppWithAutomation.ApiService.Features.Weather.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.RegisterServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseExceptionHandler();

app.RegisterMiddlewares();
app.RegisterAutomationEndpoints();
app.RegisterWeatherEndpoints();

app.Run();