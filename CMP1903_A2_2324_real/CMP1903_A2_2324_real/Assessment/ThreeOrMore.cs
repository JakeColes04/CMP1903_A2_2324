using System;

namespace CMP1903_A2_2324_real.Assessment
{
    internal class ThreeOrMore
    {
        private Die die1 = new Die();
        private Die die2 = new Die();
        private Die die3 = new Die();
        private Die die4 = new Die();
        private Die die5 = new Die();
        public Die[] dice;
        public int targetScore = 20;
        public int totalScore = 0;

        public ThreeOrMore()
        {
            // Creates an array for all the dies
            dice = new Die[] { die1, die2, die3, die4, die5 };
        }

        public void Play()
        {
            Console.WriteLine("Welcome to the Three Or More Game");
            Console.WriteLine("Press any key to roll the dice...");
            Console.ReadLine();
            int totalScore = PlayGame();
            Console.WriteLine($"Player's final score: {totalScore}");
            Console.WriteLine("Press any key to end the game...");
            Console.ReadLine();
        }

        private int PlayGame()
        {
            bool gameOver = false;

            while (!gameOver)
            {
                // 5 items in array
                int[] rolls = new int[5];
                // Roll each die
                for (int i = 0; i < dice.Length; i++)
                {
                    rolls[i] = dice[i].Roll();
                }

                // Display the roll results
                Console.WriteLine($"Player rolled: {string.Join(", ", rolls)}");
                break;
            }

            return totalScore;
        }
    }
}
