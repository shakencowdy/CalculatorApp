using System;

namespace GitExercise
{
    public class Startup
    {
        public static void Main()
        {
            const string correctPassword = "abcd1234";
            Console.WriteLine("Console Calculator App");
            Console.WriteLine(new string('-', 15));
        string userInput = Console.ReadLine();

        if (userInput == correctPassword)
        {
            Console.WriteLine("Correct Password!");
             else
        {
            Console.WriteLine("Wrong Password!");
            // Optionally, exit the program
            Environment.Exit(0);
        }
        }
            Console.WriteLine("Pres any key to close the app...");
            Console.ReadKey(true);
        }
        }
            
            //123sadasdasfasf
            Console.WriteLine("Console Calculator App");
            Console.WriteLine(new string('-', 15));

            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            Console.WriteLine("Choose one from the listed options:");
            foreach (string option in OptionsManager.OptionsList)
            {
                Console.WriteLine($"\t{option}");
            }

            Console.Write("Option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "a":
                    OptionsManager.Add(a, b);
                    break;
                case "s":
                    OptionsManager.Subtract(a, b);
                    break;
                case "m":
                    OptionsManager.Multiply(a, b);
                    break;
                case "d":
                    ObtionsManager.Divide(a, b);
                    break;
                case "ad":
                    OptionsManager.AbsoluteDivide(a, b);
            }
     
       
    }
}
