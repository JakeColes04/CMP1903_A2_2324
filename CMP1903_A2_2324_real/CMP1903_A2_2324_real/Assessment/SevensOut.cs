using System;
using System.ComponentModel.Design;

namespace CMP1903_A2_2324_real.Assessment
{
    internal class SevensOut
    {
        // Encapsulation
        private Die die1 = new Die();
        private Die die2 = new Die();
        
        public int p1totalScore = 0;
        public int p2totalScore = 0;
        public int highest = 0;

        public void Play()
        {
            Console.WriteLine("Welcome to Sevens Out Game");
            Console.WriteLine("Are you playing multiplayer or against the computer or want stats?");
            Console.WriteLine("1. Multiplayer");
            Console.WriteLine("2. Against the computer");
            Console.WriteLine("3. Statistics ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Player 1, press any key to roll your die...");
                Console.ReadLine();
                p1totalScore = PlayGame("Player 1");


                Console.WriteLine("Player 2, press any key to roll your die...");
                Console.ReadLine();
                p2totalScore = PlayGame("Player 2");

                Console.WriteLine($"Player 1 Final Score: {p1totalScore}");
                Console.WriteLine($"Player 2 Final Score: {p2totalScore}");
                if (p1totalScore > p2totalScore)
                {
                    Console.WriteLine("Player 1 wins!");
                    // Tries to find the highest score
                    if (p1totalScore > highest)
                    {
                        // Highest should be updated 
                        highest = p1totalScore;
                    }
                }
                else if (p2totalScore > p1totalScore)
                {
                    Console.WriteLine("Player 2 wins!");
                    if (p2totalScore > highest)
                    {
                        highest = p2totalScore;
                    }
                }
                else
                {
                    Console.WriteLine("It's a tie!");
                }

                Console.WriteLine("Press any key to go back to the menu...");
                Console.ReadLine();

            }
            else if (choice == "2")
            {

                Console.WriteLine("Press any key to roll your die...");
                Console.ReadLine();
                p1totalScore = PlayGame("Player");
                Console.WriteLine($"Your Final Score: {p1totalScore}");

                p2totalScore = PlayGame("Computer");
                Console.WriteLine($"Computer's Final Score: {p2totalScore}");

                if (p1totalScore > p2totalScore)
                {
                    Console.WriteLine("Player 1 wins!");
                    if (p1totalScore > highest)
                    {
                        highest = p1totalScore;
                    }
                }
                else if (p2totalScore > p1totalScore)
                {
                    Console.WriteLine("Computer wins!");
                    if (p2totalScore > highest)
                    {
                        highest = p2totalScore;
                    }
                }
                else
                {
                    Console.WriteLine("It's a tie!");
                }
                Console.WriteLine("Press any key to go back to the menu...");
                Console.ReadLine();
            }
            else if (choice == "3")
            { 
                Console.WriteLine($"The highest score is: {highest}");
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }

        }


        private int PlayGame(string playerName)
        {
            bool gameOver = false;
            int totalScore = 0;
            int rollCount = 0;

            while (!gameOver)
            {
                int roll1 = die1.Roll();
                int roll2 = die2.Roll();
                rollCount++;
                // Adds the two rolls together
                int totalRolled = roll1 + roll2;
                // If the total is 7, the game is over
                if (totalRolled == 7)
                {
                    Console.WriteLine($"Roll {rollCount}: {roll1} + {roll2} = 7. {playerName} game over!");
                    gameOver = true;
                }
                else
                {
                    // Adds the total rolled to the total score
                    totalScore += totalRolled;
                    // Checks if the two rolls are the same
                    if (roll1 == roll2)
                    {
                        // Adds the total rolled to the total score again as if doulbing it
                        totalScore += totalRolled;
                    }

                    Console.WriteLine($"Roll {rollCount}: {roll1} + {roll2} = {totalRolled}. {playerName} Total Score: {totalScore}");
                }
            }

            return totalScore;
           
        }
    }
}
