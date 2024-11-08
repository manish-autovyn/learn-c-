using System;

namespace ControlFlowExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int number = int.Parse(Console.ReadLine());

            // If-else statement
            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }

            // Switch statement
            switch (number % 2)
            {
                case 0:
                    Console.WriteLine("The number is even.");
                    break;
                case 1:
                    Console.WriteLine("The number is odd.");
                    break;
            }

            // While loop
            Console.WriteLine("Counting down using a while loop:");
            int count = 5;
            while (count >= 0)
            {
                Console.WriteLine(count);
                count--;
            }

            // For loop
            Console.WriteLine("Counting up using a for loop:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            // Do-while loop
            Console.WriteLine("Printing 'Hello' using a do-while loop:");
            int repeat = 3;
            do
            {
                Console.WriteLine("Hello");
                repeat--;
            } while (repeat > 0);

            // Break and Continue
            Console.WriteLine("Using break and continue in a loop:");
            for (int i = 1; i <= 10; i++)
            {
                if (i % 3 == 0)
                    continue; // Skip multiples of 3
                if (i == 8)
                    break; // Exit loop when i equals 8
                Console.WriteLine(i);
            }
        }
    }
}
