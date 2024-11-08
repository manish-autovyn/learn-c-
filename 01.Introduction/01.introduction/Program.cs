using System;

namespace _01.introduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data types in c# !");

            // data types 
            // 1. Value Data types
            //  will directly store the variable value in memory.
            //  It will also accept both signed and unsigned literals.
            //  The derived class for these data types are System.ValueType.


            // a. integers
            // signed integers
            sbyte sbyte_int = 120;       // 8 bit signed integer (-128 to 127)
            short short_int = 1000;      // 16 bit signed integer (-32768 to 32767)
            int int_1 = 254343;          // 32 bit signed integer (-2^31 to 2^31-1)
            long long_int = 3434323;     // 64 bit signed integer (-2^63 to 2^63-1)
            // unsigned integers
            byte byte_int = 221;         // 8 bit unsigned integer (0 to 255)
            ushort ushort_int = 13200;   // 16 bit unsigned integer (0 to 65535)
            uint uint_1 = 32342344;    // 32 bit unsigned integer (0 to 2^32)
            ulong ulong_int = 343244232; // 64 bit unsigned integer (0 to 2^64)

            Console.WriteLine("sbyte : " + sbyte_int);
            Console.WriteLine("short : " + short_int);
            Console.WriteLine("int : " + int_1);
            Console.WriteLine("long_int : " + long_int);

            Console.WriteLine("byte : " + byte_int);
            Console.WriteLine("ushort : " + ushort_int);
            Console.WriteLine("uint : " + uint_1);
            Console.WriteLine("ulong_int : " + ulong_int);

            //b. floating point 
            //  Float
            //      It is 32-bit single-precision floating point type. It has 7 digit Precision.
            //      To initialize a float variable, use the suffix f or F. Like, float x = 3.5F;
            float f = 3.7330645f;
            Console.WriteLine("float f : " + f);

            //   Double
            //      64-bit double-precision floating point type. It has 14 – 15 digit Precision.
            //      To initialize a double variable, use the suffix d or D.
            //      Suffix is not mandatory bcz by default fraction value is double in C#

            double d1 = 324.32D;
            Console.WriteLine("Double d1 : " + d1);
            double d2 = 234.432;
            Console.WriteLine("Double d2 : " + d2);

            //   Decimal
            //      The decimal type is a 128-bit data type suitable for financial and monetary calculations. It has 28-29 digit Precision.
            //      To initialize a decimal variable, use the suffix m or M.
            decimal dec = 43.234M;
            Console.WriteLine("decimal dec : " + dec);


            //c. Character types
            //  It represent UTF-16 code unit
            //  Represents the 16-bit Unicode character.
            char c = 'a';
            Console.WriteLine("char c : " + c);

            //d. Boolean types
            bool b = true;
            Console.WriteLine("bool b : " + b);

            // 2. Reference Data Types
            //      The Reference Data Types will contain a memory address of variable value because the reference types won’t store the variable value directly in memory.
            //      When you create a reference type variable, such as an object or a string, you are actually storing a reference (or pointer) to the location in memory where the data is held.
            //      The actual data for reference types is stored on the heap. The heap is a large pool of memory used for dynamic memory allocation.

            //a. String
            //   represents a sequence of Unicode characters.
            //   Its type name is System.String.
            //   So, string and String are equivalent.
            string s1 = "string1";
            String s2 = "String2";
            Console.WriteLine("string s1 : " + s1);
            Console.WriteLine("String s2 : " + s2);

            s1 += s2;
            Console.WriteLine("string s1 + s2 :" + s1);

            //b. Object
            //      In C#, all types, predefined and user-defined, reference types and value types, inherit directly or indirectly from Object.
            //      So basically it is the base class for all the data types in C#. Before assigning values, it needs type conversion.
            //      When a variable of a value type is converted to object, it’s called boxing.
            //      When a variable of type object is converted to a value type, it’s called unboxing.

            // declare object obj
            object obj;
            obj = 20;
            Console.WriteLine("object obj : " + obj);

            // to show type of object
            // using GetType()
            Console.WriteLine("type of obj : " + obj.GetType());

            //3. Pointer Data Type
            //      The Pointer Data Types will contain a memory address of the variable value.
            //      To get the pointer details we have a two symbols ampersand (&) and asterisk (*).
            //      ampersand (&): It is Known as Address Operator. It is used to determine the address of a variable.
            //      asterisk (*): It also known as Indirection Operator. It is used to access the value of an address.

            // have to use unsafe block to use pointer
            unsafe
            {
                int i = 20;
                int* p = &i;
                Console.WriteLine("pointer p : " + ((IntPtr)p).ToString("X"));
            }

            // const in c# 
            // Named constants must be assigned a value when they are defined.
            // Variables do not have to be assigned initial values.
            // Variables once defined may be assigned a value within the instructions of the program.
            //const int const_int; not possible
            const int const_int = 4;
            Console.WriteLine("const int :"+  const_int);
            //const_int = 6; not possible
        }
    }
}
