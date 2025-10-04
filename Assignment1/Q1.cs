using System;

namespace Assignment1
{
    class Q1
    {
        public void Run()
        {
            Console.Write("Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
                Console.WriteLine($"{a} is Even.");
            else
                Console.WriteLine($"{a} is Odd.");
            Console.ReadKey();

        }
    }
}
