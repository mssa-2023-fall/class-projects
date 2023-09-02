using System.Runtime.CompilerServices;
using System;

namespace Kata1
{
    abstract class Kata
    {
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;
            string vowels = "aeiouAEIOU";

            foreach (var letters in str)
            {
                if (vowels.Contains(letters))
                {
                    vowelCount++;
                }
            }
            return vowelCount;
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

