using System;

namespace Assignment1
{
    class Q4
    {
        public void Run()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= number; i++)
                sum += i;

            Console.WriteLine($"Sum of numbers from 1 to {number} is {sum}");
            Console.ReadKey();

        }
    }
}
