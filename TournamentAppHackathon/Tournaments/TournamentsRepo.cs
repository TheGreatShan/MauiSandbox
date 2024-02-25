namespace TournamentAppHackathon.Tournaments;

public record Tournament(string Title, string Game, string? Winner);

public class TournamentsRepo
{
    public static List<Tournament> Get()
    {
        return new List<Tournament>(new[]
        {
            new Tournament("Tournament 1", "Game 1", "Winner 1"),
            new Tournament("Tournament 2", "Game 2", "Winner 2"),
            new Tournament("Tournament 3", "Game 3", "Winner 3"),
            new Tournament("Tournament 4", "Game 4", "Winner 4"),
            new Tournament("Tournament 5", "Game 5", "Winner 5"),
            new Tournament("Tournament 6", "Game 6", "Winner 6"),
            new Tournament("Tournament 7", "Game 7", "Winner 7"),
            new Tournament("Tournament 8", "Game 8", "Winner 8"),
            new Tournament("Tournament 9", "Game 9", "Winner 9"),
            new Tournament("Tournament 10", "Game 10", "Winner 10"),
        });
    }
}