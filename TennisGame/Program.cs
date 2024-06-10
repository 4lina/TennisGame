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
            var winnerOfThePoint = Console.ReadLine()?.ToLower();
            if (IsInputValid(winnerOfThePoint))
            {
                game.Play(winnerOfThePoint);
                game.DisplayScore();
            }
            else
            {
                Console.WriteLine(Resources.UserInteraction_ThisPlayerDoesNotExist);
            }
        }
    }

    private static bool IsInputValid(string winnerOfThePoint)
        => !string.IsNullOrEmpty(winnerOfThePoint) && winnerOfThePoint == "a" || winnerOfThePoint == "b";
}