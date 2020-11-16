using ConsoleIO;
using RockPaperScissors.Library;
using RockPaperScissors.Library.AI;
using System;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region Rock Paper Scissors

            /*
             // Rock Paper Scissors
            // Decide the AI Strategy type here
            int userChoice = ConsoleIO.ConsoleIO.PromptForInt("Choose AI Strategy: 0 = Random, 1 = Always Wins, 2 = Always Loses, -1 = quit: ", -1, 3, false);
            if (userChoice == -1)
                return;

            Game game = new Game((AIStrategy)userChoice, true);
                        
            game.Run();

            // Decide if the player history should be printed
            bool printHistory = ConsoleIO.ConsoleIO.PromptForBool("Do you wish to show the history? Enter 'yes' or 'no': ", "yes", "no");

            if (printHistory)
                game.GetHistories().ForEach(history => Console.WriteLine(history.ToString()));
             */

            #endregion
        }
    }
}
