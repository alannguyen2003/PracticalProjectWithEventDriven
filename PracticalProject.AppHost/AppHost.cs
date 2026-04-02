var builder = DistributedApplication.CreateBuilder(args);

var sqlServer = builder.AddSqlServer("sql-server");

var writeDb = sqlServer.AddDatabase("WriteDb");
var apiService = builder.AddProject<Projects.PracticalProject_ApiService>("apiservice")
    /*
    .WithHttpHealthCheck("/health")
    */
    .WithReference(writeDb)
    .WaitFor(writeDb);

builder.Build().Run();