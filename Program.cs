using System;

namespace C__Mad_Libs_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables are declared
            string color, pluralNoun, celebrity;
            // Values are added to the variables from the user's input
            Console.Write("Enter a color: ");
            color = Console.ReadLine();
            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();
            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine("Violets are " + pluralNoun);
            Console.WriteLine("I love " + celebrity);
        }
    }
}
