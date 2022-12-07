using System.Collections.Generic;

namespace Api.Models
{
    public record Championship(string Name, IEnumerable<Phase> Phases);
    public record Phase(string Name, IEnumerable<Match> Matches );
    public record Match(TeamProbability Home, TeamProbability Visitor);
    public record TeamProbability(string TeamName, double Probability);
}
