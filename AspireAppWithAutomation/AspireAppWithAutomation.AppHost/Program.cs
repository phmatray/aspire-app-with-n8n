using AspireAppWithAutomation.AppHost.Extensions;

var builder = DistributedApplication.CreateBuilder(args);

// add n8n container
var n8n = builder.AddN8NContainer();

// add api service project (backend)
var apiservice = builder
    .AddProject<Projects.AspireAppWithAutomation_ApiService>("apiservice")
    .WithEnvironment("N8N_URL", n8n.GetEndpoint("n8n-http"));

// add web frontend project (frontend with a reference to the backend)
builder
    .AddProject<Projects.AspireAppWithAutomation_Web>("webfrontend")
    .WithReference(apiservice);

builder.Build().Run();