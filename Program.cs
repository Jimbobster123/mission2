// See https://aka.ms/new-console-template for more information

using System;

namespace DiceThrowingSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");

            int rolls;
            while (!int.TryParse(Console.ReadLine(), out rolls) || rolls <= 0)
            {
                Console.Write("Please enter a positive whole number: ");
            }

            DiceRoller roller = new DiceRoller();
            int[] results = roller.RollDiceNTimes(rolls);

            Console.WriteLine();
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {rolls}.");
            Console.WriteLine();

            for (int total = 2; total <= 12; total++)
            {
                double percent = (results[total] / (double)rolls) * 100;
                int stars = (int)Math.Round(percent);

                Console.Write($"{total}: ");
                Console.WriteLine(new string('*', stars));
            }

            Console.WriteLine();
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}

