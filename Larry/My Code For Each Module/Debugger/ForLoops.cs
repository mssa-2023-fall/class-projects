using System;
using System.ComponentModel;
using System.Security.Cryptography;

namespace Leetcode
{
    public class Iterations
    {
        public void ForLoopsReverse()
        {
///Hello World in Reverse
            string s = "Hello World";
///counter begins at max length of Hello World(11) - 1. Because of INDEXES in the ARRAY (string) start at 0. You have to MINUS 1 on the INTEGER
///counter ends when it is equal to 0
///counter will began going down from the MAX INDEX
            for (int counter = s.Length - 1; counter == 0; counter--)
            {
                Console.WriteLine(s[counter]);
            }

        }
        public void ForLoopAddition(int[] nums, int target)
        {
          //  for()
            
        }
    }
}





/*
 * 
 *          give me a few practice problems to help me understand for loops in c#
 *          
            Problem 1: Print Numbers
            Task: Write a C# program that prints numbers from 1 to 10.

            Problem 2:
            Task: Write a C# program to calculate the factorial of a number. The factorial of a number n is given by: n! = n * (n-1) * (n-2) ... * 1
            Ex: factorial of 5 = 12345

            Problem 3: Sum of Array
            Task: Write a C# program to calculate the sum of all elements in an integer array.

            Problem 4: Reverse String
            Task: Write a C# program to reverse a string.

            Problem 5: Print Multiplication Table
            Task: Write a C# program that prints the multiplication table for a given number,( up to 10 for simplicity sake)
*/