using System;

namespace PRGweek2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            int lage = 18;
            
            if(age>=lage) 
            {
                Console.WriteLine("DRINK");
            }
            else 
            {
                Console.WriteLine("DON'T DRINK");
            }

            Console.WriteLine("PROGRAM FINISHED!");
        }
    }
}
