using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SmartFiles
{
    public static class myExtensions //extension methods must exist in static class
    {
        //the first parameter indicates theTypes which you couwld like to extend
        public static void PrintList<T>(this List<T> inputList, Action<T> toPerform)
        {

            foreach (var item in inputList)
            {
                toPerform(item);
            }
        }


        public static List<T> Filter<T>(this List<T> input, Func<T, bool> predicate)
        {
            List<T> result = new();
            foreach (var item in input)
            {
                if (predicate.Invoke(item)) { result.Add(item); }
            }
            return result;
        }
    }
}



