using System.Globalization;
using TennisGame.Properties;

namespace TennisGame
{
    public class Game
    {
        private Score _scorePointsA;
        private string _scoreA = "0";
        private Score _scorePointsB;
        private string _scoreB = "0";
        private bool _gameWon;

        private enum Score
        {
            Zero = 0,
            FirstPoint,
            SecondPoint,
            ThirdPoint,
            WinPoint,
            WinPointAfterAd
        }

        public void Play(string playerScored)
        {
            switch (playerScored)
            {
                case "a":
                    _scorePointsA++;
                    _scoreA = MapScore(_scorePointsA, _scorePointsB);
                    break;
                case "b":
                    _scorePointsB++;
                    _scoreB = MapScore(_scorePointsB, _scorePointsA);
                    break;
                default:
                    // will never happen
                    break;
            }
        }

        public string GetScore() => string.Format(Resources.UserInteraction_Score, _scoreA, _scoreB, CultureInfo.InvariantCulture);

        public bool IsGameWon() => _gameWon;

        public void DisplayScore()
        {
            if (IsGameWon())
            {
                Console.WriteLine(string.Format(Resources.UserInteraction_PlayerWon, GetWinner(), CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine(GetScore());
            }
        }

        private string GetWinner() => _scorePointsA > _scorePointsB ? "A" : "B";

        private string MapScore(Score scorePlayer, Score scoreOpportunent)
        {
            switch (scorePlayer)
            {
                case Score.Zero: return "0";
                case Score.FirstPoint: return "15";
                case Score.SecondPoint: return "30";
                case Score.ThirdPoint: return "40";
                case Score.WinPoint: return HandleLastPoint(scoreOpportunent);
                case Score.WinPointAfterAd:
                    _gameWon = true;
                    return "60";
                default:
                    return string.Empty;
            }
        }

        private string HandleLastPoint(Score scoreOpportunent)
        {
            if (scoreOpportunent == Score.ThirdPoint)
            {
                return "AD";
            }

            if (scoreOpportunent == Score.WinPoint)
            {
                ResetScoresToTie();
                return "40";
            }

            _gameWon = true;
            return "60";
        }

        private void ResetScoresToTie()
        {
            _scoreA = "40";
            _scoreB = "40";

            _scorePointsA = Score.ThirdPoint;
            _scorePointsB = Score.ThirdPoint;
        }
    }
}
