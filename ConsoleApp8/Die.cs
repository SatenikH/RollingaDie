using System;

namespace RollingDie
{
    /// <summary>
    /// Rolling die description
    /// </summary>
    internal class Die
    {
        public delegate void Action();
        public event Action OnFourCount;
        public event Action OnLessEquals;

        private int value = 1;
        private int sides = 6;
        public Die(int sides)
        {
            this.sides = sides;
        }
        public int getValue()
        {
            return value;
        }
        public int getSides()
        {
            return sides;
        }
        public int Roll()
        {
            Random rand = new Random();
            value = rand.Next(1, sides+1);
            return value;
        }
        public void TestOfRolling(int count)
        {
            int[] diesArr = new int[50];
            for (int i = 0; i < count; i++)
            {
                diesArr[i] = Roll();
                Console.WriteLine(diesArr[i]);
                if (i >= 1 && diesArr[i] == 4 && diesArr[i - 1] == 4)
                {
                    OnFourCount();
                }

                if (i >= 4 && diesArr[i] + diesArr[i - 1] + diesArr[i - 2] + diesArr[i - 3] + diesArr[i - 4] >= 20)
                {
                    OnLessEquals();
                }
            }
        }
    }
}
