using NUnit.Framework;
using TennisGame;

namespace TennisGameFixture
{
    public class GameFixture
    {
        private string _userA = "A";

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
    }
}