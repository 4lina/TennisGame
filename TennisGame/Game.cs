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
                case 4: return HandleDeuceAndAdvantage(opportunent);
                case 5: return "60";
                default:
                    return string.Empty;
            }
        }

        private string HandleDeuceAndAdvantage(int opportunent)
        {
            // advantage
            if (opportunent == 3)
            {
                return "AD";
            }

            //deuce
            if (opportunent == 4)
            {
                ResetScoresToTie();
            }

            //won
            return "40";
        }

        private void ResetScoresToTie()
        {
            _scoreA = "40";
            _scoreB = "40";

            // in the unlike case that the game would go forever
            // reset after a deuce to avoid overload of integer
            _scorePointsA = 3;
            _scorePointsB = 3;
        }

    }
}
