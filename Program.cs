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

                int i;
                for(i = 0; i < value; i++)
                { 
                    Console.WriteLine("You have entered" + value.ToString() + ". This is the current integer value " +
                        "in the loop: " + i.ToString()); 
                }
               
            }
            catch
            {
                Console.WriteLine("Please enter an integer.");
            }
        }
    }
}
