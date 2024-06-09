using NUnit.Framework;
using TennisGame;

namespace TennisGameFixture
{
    public class GameFixture
    {
        private string _userA = "a";
        private string _userB = "b";

        [Test]
        public void Play_EnterPlayerA_ScoreIsUpdated()
        {
            // Arrange
            var testee = new Game();

            // Act
            testee.Play(_userA);
            var score = testee.GetScore();

            // Assert
            Assert.That(score, Is.EqualTo("Current Score: 15:0"));
        }

        [Test]
        public void Play_EnterPlayerAEnterPlayerB_ScoreIsUpdated()
        {
            var testee = new Game();
            testee.Play(_userA);
            testee.Play(_userB);
            var score = testee.GetScore();

            Assert.That(score, Is.EqualTo("Current Score: 15:15"));
        }

        [Test]
        public void Play_EnterInvalidUserName_ScoreIsUpdated()
        {
            var testee = new Game();
            testee.Play("Peter");
            var score = testee.GetScore();

            Assert.That(score, Is.EqualTo("Current Score: 0:0"));
        }

        [Test]
        public void Play_EnterPlayerAWins_ScoreIsUpdated()
        {
            var testee = new Game();
            testee.Play(_userA);
            testee.Play(_userA);
            testee.Play(_userA);
            testee.Play(_userA);
            var score = testee.GetScore();

            Assert.That(score, Is.EqualTo("Current Score: 40:0"));
        }

        [Test]
        public void Play_AdvantageAfterDeuce_ScoreIsUpdated()
        {
            var testee = new Game();
            testee.Play(_userA);
            testee.Play(_userA);
            testee.Play(_userA);

            testee.Play(_userB);
            testee.Play(_userB);
            testee.Play(_userB); // deuce

            // advantage
            testee.Play(_userA);

            var score = testee.GetScore();
            Assert.That(score, Is.EqualTo("Current Score: AD:40"));
        }

        [Test]
        public void Play_WinAfterDeuce_ScoreIsUpdated()
        {
            var testee = new Game();
            testee.Play(_userA);
            testee.Play(_userA);
            testee.Play(_userA);

            testee.Play(_userB);
            testee.Play(_userB);
            testee.Play(_userB); // deuce

            // advantage
            testee.Play(_userA);

            // win
            testee.Play(_userA);

            var score = testee.GetScore();
            Assert.That(score, Is.EqualTo("Current Score: 60:40"));
        }

        [Test]
        public void Play_DeuceAfterAdvantage_ScoreIsUpdated()
        {
            var testee = new Game();
            testee.Play(_userA);
            testee.Play(_userA);
            testee.Play(_userA);

            testee.Play(_userB);
            testee.Play(_userB);
            testee.Play(_userB); // deuce

            // advantage
            testee.Play(_userA);

            // deuce
            testee.Play(_userB);

            var score = testee.GetScore();
            Assert.That(score, Is.EqualTo("Current Score: 40:40"));
        }

        [Test]
        public void Play_WinAfterDeuceAfterAdvantageAfterDeuce_ScoreIsUpdated()
        {
            var testee = new Game();
            testee.Play(_userA);
            testee.Play(_userA);
            testee.Play(_userA);

            testee.Play(_userB);
            testee.Play(_userB);
            testee.Play(_userB); // deuce

            // advantage
            testee.Play(_userA);

            // deuce
            testee.Play(_userB);

            // advantage
            testee.Play(_userA);

            // win
            testee.Play(_userA);

            var score = testee.GetScore();
            Assert.That(score, Is.EqualTo("Current Score: 60:40"));
        }
    }
}