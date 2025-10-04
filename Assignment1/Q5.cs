using System;

namespace Assignment1
{
    class Q5
    {
        public void Run()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{num} x {i} = {num * i}");
            Console.ReadKey();

        }
    }
}
