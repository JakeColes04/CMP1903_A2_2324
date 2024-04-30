using System;

namespace CMP1903_A2_2324_real.Assessment
{
    internal class Die
    {

        static Random random = new Random();
        int dieroll;

        public int Roll()
        {
            dieroll = random.Next(1, 7);
            return dieroll;
        }
    }
}