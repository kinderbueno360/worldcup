using Api.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Services;

public sealed class PredictionService : IPredictionService
{
    public async Task<Championship> GetAsync() =>
        new Championship("WorldCup", Enumerable.Empty<Phase>());
}

