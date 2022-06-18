using System;

namespace CS11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int multipleThree = 3;
            int multipleFive = 5;
            int number;
            Random random = new Random();

            while (true)
            {
                number = random.Next(1, 101);
                number /= multipleThree | multipleFive;
                Console.WriteLine(number);
                Console.ReadKey();
            }
        }
    }
}