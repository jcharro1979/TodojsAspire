var builder = DistributedApplication.CreateBuilder(args);

var db = builder.AddSqlite("db")
    .WithSqliteWeb();

var apiService = builder.AddProject<Projects.TodojsAspire_ApiService>("apiservice")
    .WithReference(db)
    .WithHttpHealthCheck("/health");

builder.Build().Run();