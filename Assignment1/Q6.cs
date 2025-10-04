using System;

namespace Assignment1
{
    class Q6
    {
        public void Run()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int fact = 1, i = 1;

            while (i <= num)
            {
                fact *= i;
                i++;
            }

            Console.WriteLine($"Factorial of {num} is {fact}");
            Console.ReadKey();

        }
    }
}
