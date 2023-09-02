using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Net;
using Microsoft.VisualBasic;

namespace Kata2
{
public static class Kata
{//FAILED

    public static string HighAndLow(string numbers)
    {
            string numbs = numbers;
            {
                for (int counter = numbs.Length - 1; counter >= 0; counter--)
                {
                    Convert.ToInt32(numbs[counter]);
                    Console.WriteLine(numbs.Max());
                    Console.WriteLine();
                    Console.WriteLine(numbs.Min());
                }
                

            }

            return numbs;

        
    }


}








  /*          public static void TestClass()
{
string test = "1 2 3 4 5 6 7 8 9 10"; //input string
//  var test2 = test.Substring(2);  //Removes indicer [2] from string.
//  Console.WriteLine(test2);
//   Console.WriteLine();
var test3 = test.Replace(" ",","); //Replaces all indications of a SPACE " " into NOSPACE ""
// Console.WriteLine(test3);
Convert.ToInt32(test3);
Console.WriteLine(test3);
Console.ReadLine();
//int[] ints = new int[] {Convert.ToInt32(test3)};

/*
var testConversion = Convert.ToInt32(test3);
.WriteLine(testConversion);

}
*/
}









/*
DESCRIPTION:
In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.

Examples
Kata.HighAndLow("1 2 3 4 5");  // return "5 1"
Kata.HighAndLow("1 2 -3 4 5"); // return "5 -3"
Kata.HighAndLow("1 9 3 4 -5"); // return "9 -5"
Notes
All numbers are valid Int32, no need to validate them.
There will always be at least one number in the input string.
Output string must be two numbers separated by a single space, and highest number is first.
*/