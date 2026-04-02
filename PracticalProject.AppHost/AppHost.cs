var builder = DistributedApplication.CreateBuilder(args);

var sqlServer = builder.AddSqlServer("sql-server");

var readDb = sqlServer.AddDatabase("read-db");
var writeDb = sqlServer.AddDatabase("write-db");
var apiService = builder.AddProject<Projects.PracticalProject_ApiService>("apiservice")
    .WithHttpHealthCheck("/health")
    .WithReference(readDb)
    .WithReference(writeDb)
    .WaitFor(readDb)
    .WaitFor(writeDb);

builder.Build().Run();