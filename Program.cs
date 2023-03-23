using Microsoft.VisualBasic;
using System;
namespace ConsoleApp3
{
    class Example
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 3] { { 4, 1, 7 }, { 3, 8, 2 } };
            int i, j;
            Console.WriteLine("The elements in the 2-D array are:");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            //Finding length of a string

            string str = "Laptops and Mobiles";
            Console.WriteLine("The Length of the string \"{0}\" is : {1} ", str, str.Length);

            //Comparing Two Strings

            string s1 = "Apple";
            string s2 = "Apple";
            if (String.Compare(s1, s2) == 0)
            {
                Console.WriteLine("The strings are equal");
            }
            else
            {
                Console.WriteLine("The strings are not equal");
            }

            //Obtain last 4 characters from string in C#

            string x = "Strings in C#";
            string resultStr = x.Substring(x.Length - 4);
            Console.WriteLine("Original string: {0}", x);
            Console.WriteLine("Resultant string: {0}", resultStr);

            //Find the index of a word in a string

            string[] y = new string[]
            {
           "Mango",
           "Apple",
           "Guava",
           "Orange",
           "Peach"
            };
            Console.WriteLine("The given array is:");
            for (int k = 0; k < str.Length;k++)
            {
                Console.WriteLine(str[k]);
            }
            int index = Array.IndexOf(y, "Peach");
            Console.Write("The element Peach is found the index: ");
            Console.WriteLine(index);

        }
    }
}