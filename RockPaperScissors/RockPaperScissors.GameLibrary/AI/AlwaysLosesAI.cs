using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Library.AI
{
    public class AlwaysLosesAI : IAI
    {
        public GameAction Play(GameAction userAction)
        {
            return userAction switch
            {
                GameAction.Rock => GameAction.Scissors,
                GameAction.Paper => GameAction.Rock,
                GameAction.Scissors => GameAction.Paper,
                _ => throw new Exception("This block should not have been met."),
            };
        }
    }
}
