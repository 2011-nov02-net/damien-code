using System;
using System.Linq;

namespace AcronymGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // write a program and use git to keep track of it, uploading it to your personal code repo.
            // the program should: ask the user for some multi-word term, like "central processing unit", and print the acronym for that term (in this case, "CPU").
            
            Console.Write("Please enter a multi-word term that is separated by spaces:\n>");
            string userInput = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(userInput))
            {
                string[] terms = userInput.Split(' ');
                string acronymifiedResult = string.Join("", terms.Select(str => char.ToUpper(str[0])));
                Console.WriteLine($"Generated: {acronymifiedResult}.");
            }
            else Console.WriteLine($"Invalid input received (got{userInput}).");
        }
    }
}
