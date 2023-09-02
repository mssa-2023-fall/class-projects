using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;
using Kata2;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Debugger

{
    class Program
    {
        static void Main(string[] args)
        {
        string someString = "a backwords list of the digits with the second characters of";

            var someReversedString = 
            someString.Select(s => s)
            from b in someReversedString.Where (w=> w)

        
        Console.WriteLine(someReversedString);
        }
    }
}




































/*
         * Return the number (count) of vowels in the given string.

        We will consider a, e, i, o, u as vowels for this Kata (but not y).

        The input string will only consist of lower case letters and/or spaces.
*/

/*                                                              TESTS
                                                public class KataTests
                                                {
                                                    [Test]
                                                    public void TestCase1()
                                                    {
                                                        Assert.AreEqual(5, Kata.GetVowelCount("abracadabra"), "Nope!");
                                                    }
                                                }

*/


























/*
        static void Main(string[] args)
        {
            GetVowelCount("I owe my family a vacation.");

            Console.ReadLine();
        }
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;
            string vowels = "a e i o u A E I O U ";


            foreach (char v in vowels)
            {
                if (str.Contains(v))
                { 
                    vowelCount++; 
                }
            }
            return vowelCount;
        }
    }
}
*/