using System;

namespace _07._Methods
{
    class PracticeMethods
    {
        public int add_num(int num1, int num2)
        {
            return num1 + num2;
        }
        public int add_num(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public int fact(int num)
        {
            if(num <= 1)
            {
                return 1;
            }
            return num*fact(num-1);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // methods
            Console.WriteLine("Methods :");

            PracticeMethods p = new PracticeMethods();
            int sum1 = p.add_num(1, 2);
            int sum2 = p.add_num(1, 2, 3);
            //here add_num function is example of overloading

            Console.WriteLine("sum1 :" + sum1);
            Console.WriteLine("sum2 :" + sum2);


            // recursion
            Console.WriteLine("factorial of 3 : " + p.fact(3));

        }
    }
}
