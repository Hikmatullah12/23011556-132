using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Name Hikmat Ullah");
            Console.WriteLine("Enter question No:(1-10)");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: new Q1().Run(); break;
                case 2: new Q2().Run(); break;
                case 3: new Q3().Run(); break;
                case 4: new Q4().Run(); break;
                case 5: new Q5().Run(); break;
                case 6: new Q6().Run(); break;
                case 7: new Q7().Run(); break;
                case 8: new Q8().Run(); break;
                case 9: new Q9().Run(); break;
                case 10: new Q10().Run(); break;
                default: Console.WriteLine("Invalid question number!"); break;
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
