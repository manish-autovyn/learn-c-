using System;

public static class stringExtensions
{
    public static String RightSubstring(this String str, int count)
    {
        return str.Substring(str.Length - count, count);
    }
}

// there is no method named RightSubstring in class "String" 
// but with the help of above code we can bind the method with class string

namespace _09._Extension_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Extension Methods
            Console.WriteLine("Extension Methods :");

            // Extension Method allows to add new methods in the existing class
            // without modifying the source code of the original class.

            // this keyword is used for binding this method with the main class.

            String str = "hello world!";

            // now we can use RightSubstring method here
            String last5chars = str.RightSubstring(5);

            Console.WriteLine($"last five chars of string \"{str}\" are \"{last5chars}\"");

        }
    }
}
