using System;


public class GenericsPractice
{
    public void Display<T>(string msg, T value)
    {
        Console.WriteLine("{0} : {1}", msg, value);
    }
}


namespace _10._Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generics
            Console.WriteLine("Generics : \n");

            // Generics allows us to make clsses and methods type independent or type safe.
            
            //creating object of GenericsPractice
            GenericsPractice obj = new GenericsPractice();

            // calling Generics method
            obj.Display<int>("Integer", 312);
            obj.Display<char>("Character", 'A');
            obj.Display<double>("Double", 23.532);
        }
    }
}
