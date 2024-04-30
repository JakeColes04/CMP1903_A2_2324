using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A2_2324_real.Assessment
{
    internal class Testing
    {
        public void Test()
        {
            Console.WriteLine("Testing");
            SevensOut sevensOut = new SevensOut();
            sevensOut.Play();
            Debug.Assert(sevensOut.p1totalScore > -1, "Player 1's final score should be positive or 0.");
            Debug.Assert(sevensOut.p2totalScore > -1, "Player 2's final score should be positive or 0.");
            Debug.Assert(sevensOut.highest >= 0, "Highest score should be more than 0 depending on if the game has been played.");
            Console.WriteLine("Sevens Out game tested");
            ThreeOrMore threeOrMore = new ThreeOrMore();
            threeOrMore.Play();
            Debug.Assert(threeOrMore.totalScore >= 0, "Player's final score should be positive.");
            Debug.Assert(threeOrMore.targetScore == 20, "Target score should be 20.");
            Debug.Assert(threeOrMore.dice.Length == 5, "There should be 5 dice.");
            Console.WriteLine("Three Or More game tested");
        }
    }
}
