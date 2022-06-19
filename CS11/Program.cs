using System;

namespace CS11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(0, 20);
            int divisibleNumber1 = 3;
            int divisibleNumber2 = 5;
            int sum = 0;

            Console.WriteLine("Случайное число: " + number);
            Console.WriteLine("Нажмите клавишу и увидите сумму всех положительных чисел меньше " + number + ", " + 
                "которые кратные " + divisibleNumber1 + " или " + divisibleNumber2);
            Console.ReadLine();

            for (int i = 0; i < number; i++)
            {
                if (i % divisibleNumber1 == 0 || i % divisibleNumber2 == 0)
                {
                     sum = sum + i;
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
