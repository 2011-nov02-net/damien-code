using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Library.AI
{
    public interface IAI
    {
        GameAction Play(GameAction userAction);
    }
}
