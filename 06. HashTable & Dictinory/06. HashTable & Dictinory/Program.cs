using System;
using System.Collections.Generic;
using System.Collections;

namespace _06._HashTable___Dictinory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HashTable & Dictinory
            Console.WriteLine("HashTable & Dictinory :");

            // In hashTables type of the key and value is not specified

            // Create a hashtable
            // Using Hashtable class
            Hashtable myHashtable = new Hashtable();

            myHashtable.Add("key1", "value1");
            myHashtable.Add("key2", "value2");
            myHashtable.Add("myInt", 55);


            // access key values in hashtable
            Console.WriteLine("Key and Value pairs from myHashtable:");
            foreach (dynamic ele in myHashtable.Keys)
            {
                Console.WriteLine("{0} and {1}", ele, myHashtable[ele]);
            }

            // clear hashtable
            myHashtable.Clear();
            Console.WriteLine("myHashtable after clear :");
            foreach (dynamic ele in myHashtable.Keys)
            {
                Console.WriteLine("{0} and {1}", ele, myHashtable[ele]);
            }


            Hashtable myHashtable2 = new Hashtable() {
                                      {1, "hello"},
                                          {2, 234},
                                        {3, 230.45},
                                         {4, null} };

            Console.WriteLine("\nKey and Value pairs from myHashtable2:");

            foreach (var ele in myHashtable2.Keys)
            {
                Console.WriteLine("{0} and {1}", ele,
                                myHashtable2[ele]);
            }


            // remove element from hashtable
            myHashtable2.Remove(4);
            Console.WriteLine("\nmyHashtable2(after removing 4) :");
            foreach (var ele in myHashtable2.Keys)
            {
                Console.WriteLine("{0} and {1}", ele,
                                myHashtable2[ele]);
            }


            //Dictionary :
            Console.WriteLine("\n\nDictionary :\n");

            // In Dictionary type of the key and value is specified

            // Creating a dictionary
            // using Dictionary<TKey,TValue> class
            Dictionary<int, string> MyDict = new Dictionary<int, string>();

            // Adding key/value pairs in the Dictionary Using Add() method
            MyDict.Add(1, "value1");
            MyDict.Add(2, "value2");
            MyDict.Add(3, "value3");

            Console.WriteLine("myDic :");
            foreach (dynamic ele1 in MyDict)
            {
                Console.WriteLine("{0} and {1}", ele1.Key, ele1.Value);
            }
            Console.WriteLine();

            //remove a key value
            MyDict.Remove(3);

            Console.WriteLine("myDic(after removing 3) :");
            foreach (dynamic ele1 in MyDict)
            {
                Console.WriteLine("{0} and {1}", ele1.Key, ele1.Value);
            }
            Console.WriteLine();

            // clear
            MyDict.Clear();
            Console.WriteLine("myDic(after clear()) :");
            foreach (dynamic ele1 in MyDict)
            {
                Console.WriteLine("{0} and {1}", ele1.Key, ele1.Value);
            }
            Console.WriteLine();

        }
    }
}
