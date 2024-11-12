using System;
using System.Collections.Generic;

namespace _05._List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // list
            Console.WriteLine("List : ");


            //Creating a list
            List<int> myList = new List<int>();

            //add elements in list
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);

            // Printing the Capacity of list
            Console.WriteLine("Capacity Is: " + myList.Capacity);
            // Printing the Count of list
            Console.WriteLine("Count Is: " + myList.Count);

            myList.Add(5);

            Console.WriteLine("\nafter update : ");
            // Printing the Capacity of list
            // It will give output 8 as internally List is resized
            Console.WriteLine("Capacity Is: " + myList.Capacity);
            // Printing the Count of list
            Console.WriteLine("Count Is: " + myList.Count);

            // print list
            foreach(int i in myList)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();


            // List of lists
            Console.WriteLine("\nList of lists : ");
            List<List<int>> firstlist = new List<List<int>>();

            List<int> myList1 = new List<int> { 1, 2, 3 };
            List<int> myList2 = new List<int> { 11, 12, 13 };

            firstlist.Add(myList);
            firstlist.Add(myList1);
            firstlist.Add(myList2);
            firstlist.Add(new List<int>{3, 5, 1, 8});

            Console.WriteLine("fistlist : ");
            foreach (List<int> i in firstlist)
            {
                foreach (int j in i)
                {
                    Console.Write(j + ", ");
                }
                Console.WriteLine();
            }
        }
    }
}
