using Microsoft.Extensions.Diagnostics.HealthChecks;

using ProtoBuf.Grpc.Server;

using Server.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCodeFirstGrpc();

//https://docs.microsoft.com/en-us/aspnet/core/grpc/health-checks?view=aspnetcore-6.0
builder.Services.AddGrpcHealthChecks().AddCheck("health", () => HealthCheckResult.Healthy());

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<HelloService>();
app.MapGrpcHealthChecksService();

app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.UseHttpsRedirection();

app.Run();
