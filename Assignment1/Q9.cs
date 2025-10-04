using System;

namespace Assignment1
{
    class Q9
    {
        public void Run()
        {
            int[] arr = new int[10];
            int even = 0, odd = 0;

            Console.WriteLine("Enter 10 numbers:");
            for (int i = 0; i < 10; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                if (arr[i] % 2 == 0)
                    even++;
                else
                    odd++;
            }

            Console.WriteLine($"Even numbers: {even}");
            Console.WriteLine($"Odd numbers: {odd}");
            Console.ReadKey();

        }
    }
}
