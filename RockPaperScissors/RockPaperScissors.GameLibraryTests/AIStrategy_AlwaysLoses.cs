using RockPaperScissors.Library;
using RockPaperScissors.Library.AI;
using System;
using Xunit;

namespace RockPaperScissors.GameLibraryTests
{
    public class AIStrategy_AlwaysLoses
    {
        [Theory]
        [InlineData(GameAction.Rock)]
        [InlineData(GameAction.Paper)]
        [InlineData(GameAction.Scissors)]
        public void AIStrategy_AlwaysLoses_ReturnsTrue(GameAction gameAction)
        {
            // Arrange, Act, Assert
            AlwaysLosesAI _ai = new AlwaysLosesAI();

            // Act
            var result = _ai.Play(gameAction);

            // Assert
            Assert.True(Game.IsWin(gameAction, result), "AI did not produce a losing move");
        }
    }
}
