using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Test
    {
        internal string ReverseString(string s)
        {
            var reversedString = String.Empty;
            for (int i = (s.Length-1); i >= 0; i--)
            {
                reversedString += s[i];
            }
            return reversedString;
        }

        internal int[] TwoSum(int[] input, int sum) {
            int[] result = new int[2] { -1, -1};
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
                for (int j = i+1; j < input.Length; j++)
                {
                    if ((input[i] + input[j]) == sum)
                    {
                        result[0] = input[i];
                        result[1] = input[j];
                        return result;
                    }
                }
            }
            
            return result;
        }

        
    }
}
