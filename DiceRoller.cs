using System;

namespace DiceThrowingSimulator
{
    internal class DiceRoller
    {
        private readonly Random _rand = new Random();

        public int[] RollDiceNTimes(int numberOfRolls)
        {
            int[] counts = new int[13];

            for (int i = 0; i < numberOfRolls; i++)
            {
                int die1 = _rand.Next(1, 7);
                int die2 = _rand.Next(1, 7);
                int total = die1 + die2;

                counts[total]++;
            }

            return counts;
        }
    }
}