using System;

namespace Assignment1
{
    class Q10
    {
        public void Run()
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter 10 numbers:");
            for (int i = 0; i < 10; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number to search: ");
            int search = Convert.ToInt32(Console.ReadLine());
            bool found = false;

            for (int i = 0; i < 10; i++)
            {
                if (arr[i] == search)
                {
                    found = true;
                    break;
                }
            }

            if (found)
                Console.WriteLine($"{search} found in the array.");
            else
                Console.WriteLine($"{search} not found in the array.");
            Console.ReadKey();

        }
    }
}
