var builder = DistributedApplication.CreateBuilder(args);

var sqlServer = builder.AddSqlServer("sql-server");
var redis = builder.AddRedis("redis");

var kafka = builder.AddKafka("kafka")
    .WithKafkaUI();

var writeDb = sqlServer.AddDatabase("WriteDb");
var apiService = builder.AddProject<Projects.PracticalProject_ApiService>("apiservice")
    /*
    .WithHttpHealthCheck("/health")
    */
    .WithReference(redis)
    .WithReference(kafka)
    .WithReference(writeDb)
    .WaitFor(writeDb)
    .WaitFor(kafka)
    .WaitFor(redis);

builder.Build().Run();