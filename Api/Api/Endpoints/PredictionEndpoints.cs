using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System;
using Api.Services;

namespace Api.Endpoints;

public static class PredictionEndpoints
{
    public static void MapPredictionEndpoints(this WebApplication app)
    {
        app.MapGet("/api/predictions", GetPrediction);
    }
    public static async Task<IResult> GetPrediction(IPredictionService predictionService)
    {
        var championshipPredition = await predictionService.GetAsync();
        return Results.Ok(championshipPredition);
    }
}
