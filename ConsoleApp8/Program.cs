using System;

namespace RollingDie
{
    internal class Program
    {
        public static void FourTwoHeandler()
        {
            Console.WriteLine("Two fours in a row");
        }
        public static void GreatEqualsHeandler()
        {
            Console.WriteLine("Great or equal 20");
        }
        static void Main(string[] args)
        {
            Die die = new Die(6);
            die.OnFourCount += FourTwoHeandler;
            die.OnLessEquals += GreatEqualsHeandler;

            die.TestOfRolling(50);

            Console.ReadLine();
        }
    }
}
