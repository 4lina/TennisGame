using System.Globalization;
using TennisGame;
using TennisGame.Properties;

internal class Program
{
    private static void Main(string[] args)
    {
        var game = new Game();
        Console.WriteLine(Resources.UserInteraction_StartNewGame);

        while (!game.IsGameWon())
        {
            var winnerOfTheSet = Console.ReadLine()?.ToLower();
            if (!string.IsNullOrEmpty(winnerOfTheSet))
            {
                game.Play(winnerOfTheSet);
            }

            Console.WriteLine(game.GetScore());
        }

        Console.WriteLine(string.Format(Resources.UserInteraction_PlayerWon, game.GetWinner(), CultureInfo.InvariantCulture));
    }
}