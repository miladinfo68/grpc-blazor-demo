using GrpcServer.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGrpc();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<UploaderServiceImpl>();

app.MapGet("/", () => "healthy");

app.Run();
