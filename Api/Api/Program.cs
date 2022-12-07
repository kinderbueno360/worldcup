using Api.Endpoints;
using Api.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IPredictionService, PredictionService>();

var app = builder.Build();

app.MapPredictionEndpoints();

app.Run();
