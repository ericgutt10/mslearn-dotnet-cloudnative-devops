var builder = DistributedApplication.CreateBuilder(args);

var api = builder.AddProject<Projects.Products>("products");
builder.AddProject<Projects.Store>("store")
    .WithReference(api);

builder.Build().Run();
