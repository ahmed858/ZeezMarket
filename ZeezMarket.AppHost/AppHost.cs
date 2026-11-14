var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.ZeezMarket_Api>("zeezmarket-api");

builder.Build().Run();
