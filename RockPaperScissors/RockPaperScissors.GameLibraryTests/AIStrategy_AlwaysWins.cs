using RockPaperScissors.Library;
using RockPaperScissors.Library.AI;
using System;
using Xunit;

namespace RockPaperScissors.GameLibraryTests
{
    public class AIStrategy_AlwaysWins
    {
        [Theory]
        [InlineData(GameAction.Rock)]
        [InlineData(GameAction.Paper)]
        [InlineData(GameAction.Scissors)]
        public void AIStrategy_AlwaysWins_ReturnsTrue(GameAction gameAction)
        {
            // Arrange
            AlwaysWinsAI _ai = new AlwaysWinsAI();

            // Act
            var result = _ai.Play(gameAction);

            // Assert
            Assert.False(Game.IsWin(gameAction, result), "AI did not produce a winning move");
        }
    }
}
