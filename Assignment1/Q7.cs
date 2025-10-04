using System;

namespace Assignment1
{
    class Q7
    {
        public void Run()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int rev = 0;

            while (num > 0)
            {
                int digit = num % 10;
                rev = rev * 10 + digit;
                num /= 10;
            }

            Console.WriteLine($"Reversed number: {rev}");
            Console.ReadKey();

        }
    }
}
