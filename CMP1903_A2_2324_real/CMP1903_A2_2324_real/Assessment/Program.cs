using System;
using System.Diagnostics;

namespace CMP1903_A2_2324_real.Assessment
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool menu = true;
            while (menu)
            {
                Console.WriteLine("Welcome to the Dice Games Menu");
                Console.WriteLine("1. Sevens Out game");
                Console.WriteLine("2. Three Or More game");
                Console.WriteLine("3. Testing");
                Console.WriteLine("4. Exit");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    SevensOut sevensOut = new SevensOut();
                    sevensOut.Play();
                }
                else if (choice == "2")
                {
                    ThreeOrMore Threeormore = new ThreeOrMore();
                    Threeormore.Play();
                }
                else if (choice == "3")
                {
                    Testing testing = new Testing();
                    testing.Test();
                }

                else if (choice == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
            }

        }
    }
}
                