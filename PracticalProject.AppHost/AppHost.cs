var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.PracticalProject_ApiService>("apiservice")
    .WithHttpHealthCheck("/health");

builder.Build().Run();