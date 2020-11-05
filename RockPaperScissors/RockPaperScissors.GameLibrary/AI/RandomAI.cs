using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Library.AI
{
    public class RandomAI : IAI
    {
        private static Random s_Random = new Random();

        public GameAction Play(GameAction userAction) => (GameAction)s_Random.Next(2);
    }
}
