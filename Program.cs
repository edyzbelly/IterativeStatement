using System;

namespace IterativeStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer value between 1 and 100 to execute an iterative statement:");
            
            try
            {
                string input = Console.ReadLine();
                int value = int.Parse(input);

                if ((value >= 1) && (value <= 100))
                {
                    int i;
                    for (i = 1; i <= value; i++)
                    {
                        Console.WriteLine("You have entered " + value.ToString() + ". This is the current integer value " +
                        "in the loop: " + i.ToString());
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an integer between 1 and 100 and try again ...");
                    Console.WriteLine("Press any key to exit the program and try again ...");
                    Console.ReadKey(true);
                }
            }
            catch
            {
                Console.WriteLine("Please enter an integer.");
                Console.WriteLine("Press any key to exit the program and try again ...");
                Console.ReadKey(true);
            }
        }
    }
}
