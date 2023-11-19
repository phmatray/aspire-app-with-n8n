var builder = DistributedApplication.CreateBuilder(args);

var apiservice = builder.AddProject<Projects.AspireAppWithAutomation_ApiService>("apiservice");

builder.AddProject<Projects.AspireAppWithAutomation_Web>("webfrontend")
    .WithReference(apiservice);

builder.Build().Run();