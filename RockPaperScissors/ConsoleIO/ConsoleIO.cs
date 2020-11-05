using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleIO
{
    public class ConsoleIO
    {
        public static string PromptForInput(string message, bool allowEmpty)
        {
            string userInput = null;

            while (string.IsNullOrWhiteSpace(userInput))
            {
                Console.Write(message);
                userInput = Console.ReadLine();
            }

            return userInput;
        }

        public static int PromptForInt(string message, int min, int max, bool verbose)
        {
            string userInput = null;
            int userChoice;

            bool success = false;

            do
            {
                userInput = PromptForInput(message, false);

                if (int.TryParse(userInput, out userChoice))
                {
                    bool tooLow = userChoice < min;
                    bool tooHigh = max <= userChoice;
                    if (verbose)
                    {
                        if (tooLow)
                            Console.WriteLine("Your choice is too low.");
                        else if (tooHigh)
                            Console.WriteLine("Your choice is too high.");
                    }
                    else if(tooLow || tooHigh)
                       Console.WriteLine("Your choice is invalid.");
                    else success = true;
                }
            }
            while (!success);

            return userChoice;
        }

        public static bool PromptForBool(string message, string trueString, string falseString)
        {
            string userInput;

            do
            {
                userInput = PromptForInput(message, false);

                if (userInput == trueString)
                    return true;
                else if (userInput == falseString)
                    return false;
            }
            while (string.IsNullOrWhiteSpace(userInput));

            return false;
        }
    }
}
