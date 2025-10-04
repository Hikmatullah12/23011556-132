using System;

namespace Assignment1
{
    class Q8
    {
        public void Run()
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter 10 numbers:");

            for (int i = 0; i < 10; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());

            int max = arr[0], min = arr[0];
            for (int i = 1; i < 10; i++)
            {
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
            }

            Console.WriteLine($"Maximum: {max}");
            Console.WriteLine($"Minimum: {min}");
            Console.ReadKey();

        }
    }
}
