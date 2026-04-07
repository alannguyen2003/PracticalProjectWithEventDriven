var builder = DistributedApplication.CreateBuilder(args);

var sqlServer = builder.AddSqlServer("sql-server");
var redis = builder.AddRedis("redis");

var kafka = builder.AddKafka("kafka")
    .WithKafkaUI();

var writeDb = sqlServer.AddDatabase("WriteDb");
var readDb = sqlServer.AddDatabase("ReadDb");

var readApiService = builder.AddProject<Projects.ReadProject_ApiService>("readservice")
    .WithReference(readDb)
    .WithReference(kafka)
    .WaitFor(readDb)
    .WaitFor(kafka);
var writeApiService = builder.AddProject<Projects.PracticalProject_ApiService>("apiservice")
    /*
    .WithHttpHealthCheck("/health")
    */
    .WithReference(kafka)
    .WithReference(writeDb)
    .WaitFor(writeDb)
    .WaitFor(kafka);

builder.Build().Run();