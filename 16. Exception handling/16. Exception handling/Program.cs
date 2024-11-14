using System;

namespace _16._Exception_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exception handling
            // exception = errors that occur during execution
            Console.WriteLine("Exception handling : \n");

            int x;
            int y;
            double result;

            try
            {
                // try = try some code that is considered "dangerous"
                Console.Write("Enter number 1: ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter number 2: ");
                y = Convert.ToInt32(Console.ReadLine());

                result = x / y;

                Console.WriteLine("result: " + result);
            }
            catch (Exception e)
            {
                // catch = catches and handles exceptions when they occur
                // here catch will execute if both x and y are not int
                Console.WriteLine("Catch Executed : Enter ONLY Integer and b should be greater than 0 !");
            }
            finally
            {
                // finally = always executes regardless if exception is caught or not
                Console.WriteLine("finally executed !");
            }
        }
    }
}
