using RockPaperScissors.Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.GameLibrary
{
    public class Player
    {
        public static GameAction PromptAction(string message) => (GameAction)ConsoleIO.ConsoleIO.PromptForInt(message, -1, 3, false);
    }
}
