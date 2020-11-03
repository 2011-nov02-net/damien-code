using System;

namespace ProceduralBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Comments
            /*
                numeric types:
                    int:        4 bytes in size     (use this more frequently)
                    short:      2 bytes     
                    byte:       1 byte              
                    long:       8 bytes             (use this for numbers that are > ~2 billion)

                fractional:
                    double:     8 bytes             (use this more often)
                    float:      4 bytes
                    decimal:    16 bytes            (use this with financial-based calculations)

                true/false:
                    bool

                Note: in C#, strigns are Unicode
                text:   
                    char:   one character (a, 3, any unicode character)
                    string: any number of characters
             */


            /*
             
            // Console.WriteLine("Hello World!");

            string name = "Vero";

            // arithmetic: + - * / % += -= *= /= %=
            // comparison: > < <= >= == !=
            // boolean: && || 

            // control float
            while (false) ;
            if (false) { }
            try { } catch { }
            do { } while (false);
            // setup, test condition, update statement
            for (int i = 0; i < 10; i++) { Console.WriteLine(i % 3); }

            String input = Console.ReadLine();
            int parsedNumber;
            if (int.TryParse(input, out parsedNumber))
            {
                bool negative = (parsedNumber < 0);
                if (negative)
                    Console.WriteLine("Number was negative.");
                else if (parsedNumber == 0)
                    Console.WriteLine("Number is 0.");
                else Console.WriteLine("Number must've been positive.");
                Console.WriteLine("This prints regardless.");
            }

            switch (parsedNumber)
            {
                case 0:
                    break;

                case 1:
                    break;

                default:
                    break;
            }

            // C# supports switch expressions
            // "pattern matching"

            // in C# everything is an object

            */

            /*
             // print out a triangle of some size
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();
            int size = 0;
            if(int.TryParse(userInput, out size))
            {
                for (int i = 0; i < size; i++)
                {
                    // string line = new string('#', i + 1);
                    int half = (int)MathF.Round((size - i) / 2f);
                    Console.WriteLine("".PadRight(i + 1, '#').PadLeft(half).PadRight(half));
                }
            }
            else Console.WriteLine($"Could not parse number (got {userInput}).");
             */
            #endregion
        }
    }
}
