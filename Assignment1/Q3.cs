using System;

namespace Assignment1
{
    class Q3
    {
        public void Run()
        {
            Console.Write("Enter marks (0–100): ");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks >= 85)
                Console.WriteLine("Grade: A");
            else if (marks >= 70)
                Console.WriteLine("Grade: B");
            else if (marks >= 60)
                Console.WriteLine("Grade: C");
            else if (marks >= 50)
                Console.WriteLine("Grade: D");
            else
                Console.WriteLine("Grade: F");
            Console.ReadKey();

        }
    }
}
