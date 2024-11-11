using System;
using System.Data.SqlTypes;
using System.Globalization;

namespace _03._Strings
{
    internal class Program
    {
        static void StringBasics()
        {
            string s1 = "Hello ";

            // Reading String form User-Input
            Console.Write("Enter your first name : ");

            string fname = Console.ReadLine();
            Console.WriteLine(fname);

            Console.Write("Enter your last name : ");
            string lname = Console.ReadLine();

            //string concatenation operator
            string name = fname + " " + lname;
            Console.WriteLine(s1 + name);


            // create string using constructor

            char[] chars = { 's', 't', 'r', 'i', 'n', 'g', '1' };
            // Create a string from a character array.
            string str1 = new string(chars);
            Console.WriteLine(str1);

            // Create a string that consists of 
            // a character repeated 10 times.
            string str2 = new string('A', 10);
            Console.WriteLine("str2 : " + str2);
            // Lenght of string
            Console.WriteLine("length of str2 : " + str2.Length);
        }

        static void FormatPractice()
        {
            // Creation of string using Format method
            int no = 10;
            string cname = "BMW";
            string clr = "Red";

            // string creation using string.Format method
            string str = string.Format("{0} {1} Cars color " +
                         "are {2}", no.ToString(), cname, clr);
            Console.WriteLine("str : " + str);
        }

        static void SplitPractice()
        {
            string text = "C# is a fun programming language for programmers";

            // split string
            // The Split() method breaks up a string at the specified separator and returns its substrings.
            string[] result = text.Split(" ");

            Console.Write("Result: ");
            foreach (String str in result)
            {
                Console.Write(str + ", ");
            }
            Console.WriteLine("\n");
            // Output: Result: C#, is, a, fun, programming, language,

            // Split String Using Multiple Characters
            string text2 = "a b,c.d/e";

            string[] result2 = text2.Split(' ', ',', '.', '/');

            foreach (string str in result2)
            {
                Console.Write(str + ' ');
            }
            Console.WriteLine("\n");

            // Split() Syntax
            // Split(String separator, Int32 count, StringSplitOptions options)

            // separator - separates the substrings in a string
            // count - controls the number of resulting substrings
            // options - specifies whether to omit empty array elements or to include them
            string[] separators = { "is", "for" };

            // separates string at separators
            string[] result3 = text.Split(separators ,StringSplitOptions.None);

            foreach (string str in result3)
            {
                Console.Write(str + " ,");
            }
            Console.WriteLine("\n");

            // Specific Number of Substrings
            string[] separators2 = { "::" };
            string[] result4 = text.Split(separators2, 2, StringSplitOptions.None);

            foreach(string str in result4)
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }

        static void SubstringPractice()
        {
            // Substring() Syntax
            // Substring(int startIndex, int length)
            // startIndex - the beginning index of the substring
            // length - (optional) - length of the substring

            string text = "C# is fun";
            // Returns substring from index 2
            Console.WriteLine(text.Substring(2));
            // Returns substring of length 3 from index 2
            Console.WriteLine(text.Substring(2, 3));

            // Substring() Before Specific Character
            // Returns substring from index 0 to index before '.' 
            string result = text.Substring(3, text.IndexOf(' '));
            Console.WriteLine(result);
        }

        static void ComparePractice()
        {
            // The Compare() method compares two strings in the alphabetical order.
            // Compare() Syntax
            // String.Compare(string str1, string str2)
            // str1 - first string for comparison
            // str2 - second string for comparison

            // Compare() Return Value
            // The Compare() method returns:
            // 0 - if the strings are equal
            // positive integer - if the first string comes after the second string in the alphabetical order
            // negative integer - if the first string comes before the second string in the alphabetical order
            string str1 = "C#";
            string str2 = "C#";
            string str3 = "Programiz";
            string str4 = "programiz";

            int result;

            // compares str1 with str2
            result = String.Compare(str1, str2);
            Console.WriteLine(result);

            //compares str1 with str3
            result = String.Compare(str1, str3);
            Console.WriteLine(result);

            //compares str3 with str1
            result = String.Compare(str3, str1);
            Console.WriteLine(result);


            //C# String Compare() - Ignore Case
            bool ignoreCase = true;

            // compares by ignoring case
            result = String.Compare(str3, str4, ignoreCase);
            Console.WriteLine("ignore case : " + result);
        }
        static void ReplacePractice()
        {
            // The Replace() method returns a new string by replacing each matching character/substring in the string with the new character/substring.
            // Replace() Syntax
            // Replace(string oldValue, string newValue)
            // oldValue - the substring that we want to replace
            // newValue - new substring which will replace the old substring
            string str = "Bat";
            Console.WriteLine("Old value: " + str);

            string result;

            // replaces 'B' with 'C''
            result = str.Replace('B', 'C');
            Console.WriteLine("New value: " + result);

            str = "C# Programming";

            // replaces "C#" with "Java"
            result = str.Replace("C#", "C++");
            Console.WriteLine("New Value1: " + result);

            // Replace() Chain
            str = "AAAMMM";
            Console.WriteLine("Old Value: " + str);

            // performs multiple replacement  
            result = str.Replace("AM", "BBB").Replace("MM", "CCC");
            Console.WriteLine("New Value: " + result);
        }

        static void ContainsPractice()
        {
            // The Contains() method checks whether the specified string is present in the string or not.
            // Contains() Syntax
            // Contains(String str, StringComparison comp)
            // str - string which is to be checked
            // comp - ignores or considers case sensitivity

            // Contains() Return Value
            // True - if the string contains the specified substring
            // False - if the string doesn't contain the specified substring

            // We can also ignore case sensitivity while using Contains().

            string str = "I love ice cream";

            Console.WriteLine("Original String : " + str);

            bool check;
            // considers case sensitivity
            check = str.Contains("Ice cream", StringComparison.Ordinal);
            Console.WriteLine("considers case sensitivity: " + check);

            // ignores case sensitivity
            check = str.Contains("Ice cream", StringComparison.OrdinalIgnoreCase);
            Console.WriteLine("ignores case sensitivity: " + check);

            // Contains() With if...else
            if (str.Contains("ice"))
            {
                Console.WriteLine("str contains ice");
            }

            else
            {
                Console.WriteLine("str does not contain ice");
            }
        }

        static void JoinPractice()
        {
            // The Join() method joins the elements of an array using a specified separator.
            // Join() Syntax
            // String.Join(String separator, String[] value, Int32 startIndex, Int32 count)
            // separator - the separator to join the elements
            // value - an array of strings to join
            //startIndex - the first item in value to join
            //count - number of elements to join(starts from startIndex)

            // Join() Return Value
            // returns a string that consists of the elements separated by the separator
            
            string[] text = { "C#", "Java", "C++", "Swift", "Go" };

            //join strings
            string s = String.Join(", ", text);
            Console.WriteLine(s);

            // joins 3 strings from index 1
            string s1 = String.Join(", ", text, 1, 3);

            Console.WriteLine(s1);
        }

        static void ConcatPractice()
        {
            // The String Concat() method concatenates (joins) strings and returns them.
            // Concat() Syntax
            // String.Concat(string str0, string str1, string str2, ... string strn);
            // str0, str2, str3, .... strn - strings to concatenate
            string str0 = "Everyone";
            string str1 = " loves";
            string str2 = " ice cream";

            // concatenates str0, str1, and str2
            string result = String.Concat(str0, str1, str2);
            Console.WriteLine(result);

            // Concat() - Array Elements
            string[] str = { "Chocolate", " Ice cream", " Vanilla" };

            // concatenates string array
            result = String.Concat(str);
            Console.WriteLine(result);
        }

        static void TrimPractice()
        {
            // The Trim() method removes any leading(starting) and
            // trailing(ending) whitespaces from the specified string.

            // Trim() Syntax
            // Trim(params char[]? trimChars)
            // trimChars - an array of characters to remove

            // Trim() Return Value
            // a string with leading and trailing whitespace or specified characters removed

            string text1 = "\n\n\n Ice\ncream  \n\n";
            string text2 = "\n\n\n Chocolate  \n\n";

            // trims leading and trailing whitespaces 
            string s1 = text1.Trim();
            Console.WriteLine(s1);

            // trims leading and trailing whitespaces 
            string s2 = text2.Trim();
            Console.WriteLine(s2);


            // Trim() - Trim Characters
            char[] charsToTrim = { '(', ')', '^' };

            string text = "(^^Everyone loves ice cream^^)";
            Console.WriteLine("Before trim: " + text);

            // trims leading and trailing specified chars
            s1 = text.Trim(charsToTrim);
            Console.WriteLine("After trim: " + s1);

            // Here, we have used the Trim() method to remove leading
            // and trailing '(', ')', and '^' characters.

            //TrimStart() and TrimEnd()
            text = "  Everyone loves ice cream  \n\n";
            string result;

            // trims starting whitespace
            result = text.TrimStart();
            Console.WriteLine(result);

            // trims ending whitespace
            result = text.TrimEnd();
            Console.WriteLine(result);
        }

        static void EqualsPractice()
        {
            // The String Equals() method checks whether
            // two strings have the same value or not.

            // Equals() Syntax
            // String.Equals(string a, string b)
            // a - first string to compare
            // b - second string to compare

            //Equals() Return Value
            //True - if the strings are equal
            //False - if the strings are not equal

            string str1 = "Ice cream";
            string str2 = "Ice cream";
            string str3 = "Chocolate";
            string str4 = "chocolate";

            bool result;

            // comparing str1 with str2
            result = String.Equals(str1, str2);
            Console.WriteLine("str1 and str2 are equal: " + result);

            // comparing str1 with str3
            result = String.Equals(str1, str3);
            Console.WriteLine("str1 and str3 are equal: " + result);

            // compare str3 with str4 checking case
            result = String.Equals(str3, str4);
            Console.WriteLine("str3 and str4 are equal checking case: " + result);

            // compare str3 with str4 with ignoring case
            result = String.Equals(str3, str4, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine("str3 and str4 are equal ignoring case: " + result);
        }

        static void IndexOfPractice()
        {
            // The String IndexOf() method returns the index
            // of the first occurrence of the specified
            // character/substring within the string.

            // IndexOf() Syntax
            // String.IndexOf(string value, int startindex, int count)
            // value - string to search
            // startIndex - starting position of the search
            // count - number of character positions to examine

            // IndexOf() Return Value
            // index of the first occurrence of the specified character/string
            // -1 if the specified character/ string is not found

            string str = "Ice cream";
            int result;

            // returns -1
            result = str.IndexOf('m', 1, 1);
            Console.WriteLine("Index of m: " + result);

            // returns index of c
            result = str.IndexOf('c', 0, 9);
            Console.WriteLine("Index of c: " + result);

            // returns index of c starts from 2 within 6 characters
            result = str.IndexOf('c', 2, 6);
            Console.WriteLine("Index of c: "+ result);

            // returns index of c starts from 2 within 2 characters
            result = str.IndexOf('c', 2, 2);
            Console.WriteLine("Index of c: " + result);
        }

        static void LastIndexOfPractice()
        {
            string str = "Icecream";
            // returns last index of 'c'
            int index = str.LastIndexOf('c');

            Console.WriteLine($"Last index 0f c in {str} is {index}");

            // LastIndexOf() Syntax
            // LastIndexOf(String value, int startIndex, int count, StringComparison comparisonType);
            // value = substring to seek
            // startIndex = starting position of the search.
            // count = number of character positions to examine.
            // comparisonType = enumeration values that specifies the rules for the search.


            int startIndex = 2;
            int count = 3;

            StringComparison comparisonType1 = StringComparison.CurrentCultureIgnoreCase;
            StringComparison comparisonType2 = StringComparison.CurrentCulture;

            // ignores letter case
            int index1 = str.LastIndexOf("CE", startIndex, count, comparisonType1);
            Console.WriteLine("ignore letter case : " + index1);

            // considers letter case
            int index2 = str.LastIndexOf("CE", startIndex, count, comparisonType2);
            Console.WriteLine("considers letter case : " + index2);
        }

        static void RemovePractice()
        {
            // The String Remove() method removes a specified number
            // of characters from the string.

            // Remove() Syntax
            // Remove(int startIndex, int count)
            // startIndex - index to begin deleting characters
            // count(optional) - number of characters to delete

            // Remove() Return Value
            // string after removing characters
            string str = "Chocolate";

            // removes 2 chars from index 5
            string result = str.Remove(5, 2);
            Console.WriteLine(result);
        }

        static void ToUpper_ToLower_Practice()
        {
            // ToUpper()
            // The String ToUpper() method converts
            // all characters in the string to uppercase.

            // ToUpper() Syntax

            // ToUpper() Return Value
            // a copy of the string after converting it to uppercase

            string str = "chocolate";

            Console.WriteLine("before : " + str);

            // converts str to upper case 
            string result = str.ToUpper();
            Console.WriteLine("after : " + result);

            // ToUpper() With CultureInfo Parameter
            // ToUpper(System.Globalization.CultureInfo culture)

            str = "ice cream";
            result = str.ToUpper(new CultureInfo("tr-TR", false));
            Console.WriteLine("ToUpper with CultureInfo " + result);

            // tr-TR - uses Turkish - Turkey culture
            // false - denotes default culture settings
            // As a result, the lowercase "i" is converted to the Turkish "İ"
            // instead of the US-English "I"


            //ToLower()
            // similar to ToLower()
            result = str.ToLower(new CultureInfo("tr-TR", false));
            Console.WriteLine("ToLower with CultureInfo : " + result);
        }

        static void EndsWith_StartsWith_Practice()
        {
            // EndsWith()
            // The String EndsWith() method checks whether the string
            // ends with the specified string or not.

            // Syntax
            // EndsWith(string value, StringComparison comparisonType)
            // value - string to compare to the substring at the end of the given string
            // comparisonType - determines how the given string and value are compared

            // Return Value
            // True - if the string ends with the given string
            // False - if the string doesn't end with the given string
            
            string text = "Chocolate";
            bool result;

            Console.WriteLine("text : " + text);

            // checks if text ends with late
            result = text.EndsWith("late");
            Console.WriteLine("Ends with late: " + result);

            // checks if text ends with gate
            result = text.EndsWith("gate");
            Console.WriteLine("Ends with gate: " + result);

            // Case Sensitivity
            text = "Ice cream";

            Console.WriteLine("text : " + text);

            // ignores case
            result = text.EndsWith("Cream", StringComparison.OrdinalIgnoreCase);
            Console.WriteLine("Ends with Cream (ignore case): " + result);

            // considers case
            result = text.EndsWith("Cream", StringComparison.Ordinal);
            Console.WriteLine("Ends with Cream (consider case): " + result);


            //StartsWith()
            // similar to  EndsWith()
            string str = "Icecream";
            
            Console.WriteLine("str : " + str);

            // ignores letter case
            result = str.StartsWith("ice", StringComparison.InvariantCultureIgnoreCase);
            Console.WriteLine("Starts with ice (ignore case) : " + result);
            
            // considers letter case
            result = str.StartsWith("ice", StringComparison.InvariantCulture);
            Console.WriteLine("Starts with ice (consider case) : " + result);

        }

        static void ToCharArrayPractice()
        {
            // The ToCharArray() method copies the characters in the
            // string to a character array.

            // ToCharArray() Syntax
            // ToCharArray(int startIndex, int length)
            // startIndex - starting position of a substring in the string
            // length - length of the substring in the string

            string str = "Icecream";
            char[] result;

            Console.WriteLine("str : "+  str);
            // copies 4 chars from index 3 of str
            result = str.ToCharArray(3, 4);

            // prints result
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }

        static void PadLeft_PadRight_Practice()
        {
            // The String PadLeft() method returns a new string of a
            // specified length in which the beginning of the
            // current string is padded with spaces or with
            // a specified character.

            // PadLeft() Syntax
            // PadLeft(int totalWidth, char paddingChar)
            // totalWidth - number of characters in the resulting string (number of characters in given string plus additional padding characters)
            // paddingChar - padding character

            // Return Value
            // new string with left padding
            string str = "Icecream";
            char pad = '^';
            string result;

            // returns string with length 9 
            // padded with '^' at left
            result = str.PadLeft(9, pad);
            Console.WriteLine("Result: " + result);

            // returns original string
            result = str.PadLeft(2, pad);
            Console.WriteLine("Result: " + result);

            // returns string with length 20
            // padded with '^' at left
            result = str.PadLeft(20, pad);
            Console.WriteLine("Result: " + result);


            Console.WriteLine("\nPadRight()");
            // PadRight()
            // similar to PadLeft()
            // returns new string with length 20 
            // padded with '^' at right
            result = str.PadRight(20, pad);
            Console.WriteLine("|{0}|", result);

            // returns given string
            result = str.PadRight(2, pad);
            Console.WriteLine("|{0}|", result);

            // returns new string with length 8
            // padded with '^' at right
            result = str.PadRight(8, pad);
            Console.WriteLine("|{0}|", result);

        }


        static void Main(string[] args)
        {
            //string basics
            StringBasics();


            // String Methods
            //Console.WriteLine("\n\nString Methods :");

            // Format()
            //Console.WriteLine("\nFormat() :");
            //FormatPractice();

            // Split()
            //Console.WriteLine("\nSplit :");
            //SplitPractice();

            // Substring()
            //Console.WriteLine("\nSubstring() :");
            //SubstringPractice();

            // Compare()
            //Console.WriteLine("\nCompare() :");
            //ComparePractice();

            // Replace()
            //Console.WriteLine("\nReplace() :");
            //ReplacePractice();

            // Contains()
            //Console.WriteLine("\nContains() :");
            //ContainsPractice();

            // Join()
            //Console.WriteLine("\nJoin() :");
            //JoinPractice();

            // Concat()
            //Console.WriteLine("\nConcat() :");
            //ConcatPractice();

            // Trim()
            //Console.WriteLine("\nTrim() :");
            //TrimPractice();

            // Equals()
            //Console.WriteLine("\nEquals() :");
            //EqualsPractice();

            // IndexOf()
            //Console.WriteLine("\nIndexOf() :");
            //IndexOfPractice();

            // LastIndexOf()
            //Console.WriteLine("\nLastIndexOf() ");
            //LastIndexOfPractice();

            // Remove()
            //Console.WriteLine("\nRemove() :");
            //RemovePractice();

            // ToUpper() ToLower()
            //Console.WriteLine("\nToUpper() :");
            //ToUpper_ToLower_Practice();

            // EndsWith() StartsWith()
            //Console.WriteLine("\nEndsWith() and StartsWith() :");
            //EndsWith_StartsWith_Practice();

            // ToCharArray()
            //Console.WriteLine("\nToCharArray() :");
            //ToCharArrayPractice();

            // PadLeft() PadRight
            //Console.WriteLine("\nPadLeft() PadRight() :");
            //PadLeft_PadRight_Practice();
        }
    }
}
