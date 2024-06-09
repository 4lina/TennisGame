using System.Globalization;
using TennisGame.Properties;

namespace TennisGame
{
    public class Game
    {
        private int _scorePointsA;
        private string _scoreA = "0";
        private int _scorePointsB;
        private string _scoreB = "0";


        public void Play(string playerScored)
        {
            switch (playerScored)
            {
                case "A":
                    _scorePointsA++;
                    _scoreA = MapScore(_scorePointsA, _scorePointsB);
                    break;
                case "B":
                    _scorePointsB++;
                    _scoreB = MapScore(_scorePointsB, _scorePointsA);
                    break;
                default:
                    Console.WriteLine(Resources.UserInteraction_ThisPlayerDoesNotExist);
                    break;
            }
        }

        public string GetScore() => string.Format(Resources.UserInteraction_Score, _scoreA, _scoreB, CultureInfo.InvariantCulture);


        private string MapScore(int player, int opportunent)
        {
            switch (player)
            {
                case 0: return "0";
                case 1: return "15";
                case 2: return "30";
                case 3: return "40";
            }

            return string.Empty;
        }

    }
}
