using System;

namespace _04._Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare an array
            //int[] int_arr;

            // to insert values to it we use an array literal
            int[] int_arr = { 1, 2, 3, 4, 5 };

            // access print array elements
            Console.WriteLine("int_arr : ");
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"index : {i}, value : {int_arr[i]}");
            }

            // change array elements
            for(int i = 0; i < int_arr.Length; i++)
            {
                int_arr[i] = i * 2;
            }

            Console.WriteLine("\nint_arr after update : ");
            // foreach loop
            foreach(int i in int_arr)
            {
                Console.Write(i + ", ");
            }


            // create an array with predefined size
            int[] int_arr2 = new int[5];
            for (int i = 0; i < int_arr2.Length; i++)
            {
                int_arr2[i] = i * 2;
            }

            Console.WriteLine("\nint_arr2 : ");
            // foreach loop
            foreach (int i in int_arr2)
            {
                Console.Write(i + ", ");
            }


            // Multidimensional array
            // Two-dimensional array
            Console.WriteLine("Two-dimensional array :");
            int[,] x = new int[2, 3];
            // it creates an array of 2*3


            //update values in array x
            for(int i = 0; i< x.GetLength(0); i++)
            {
                for(int j = 0; j < x.GetLength(1); j++)
                {
                    x[i, j] = i +j;
                }
            }

            Console.WriteLine("array x : ");
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write(x[i, j] + ", ");
                }
                Console.WriteLine();
            }



            // Jagged Array
            // A jagged array consists of multiple arrays as its element. However,
            // unlike multidimensional arrays, each array inside a jagged array can be of different sizes.
            // declare jagged array
            int[][] jaggedArray = new int[4][];
            jaggedArray[0] = new int[] { 11, 12, 13 };
            jaggedArray[1] = new int[] { 21, 22 };
            jaggedArray[2] = new int[] { 31, 32, 33 };
            jaggedArray[3] = new int[] { 41, 42, 43, 44, 45 };

            // Iterating through a jagged array
            Console.WriteLine("\njaggedArray using for loop :");
            for(int i = 0; i < jaggedArray.Length; i++)
            {
                for(int j = 0; j< jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + ", ");
                }
                Console.WriteLine() ;
            }

            //using foreach loop
            Console.WriteLine("\njaggedArray using foreach loop :");
            foreach(int[] i in jaggedArray)
            {
                foreach(int j in i)
                {
                    Console.Write(j + ", ");
                }
                Console.WriteLine();
            }
        }
    }
}
