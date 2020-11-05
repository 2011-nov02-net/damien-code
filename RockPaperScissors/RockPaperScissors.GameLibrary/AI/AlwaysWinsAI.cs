using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Library.AI
{
    public class AlwaysWinsAI : IAI
    {
        public GameAction Play(GameAction userAction)
        {
            return userAction switch
            {
                GameAction.Rock => GameAction.Paper,
                GameAction.Paper => GameAction.Scissors,
                GameAction.Scissors => GameAction.Rock,
                _ => throw new Exception("This block should not have been met."),
            };
        }
    }
}
