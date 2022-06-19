using System;

namespace CS11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int divisibleNumber1 = 3;
            int divisibleNumber2 = 5;
            int number;
            Random random = new Random();

            for(number = 0; number < 1; number++)
            {
                number /= divisibleNumber1 | divisibleNumber2;
                Console.WriteLine(random.Next(0,101));
            }
        }
    }
}
