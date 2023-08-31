using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFiles
{
    public static class MyExtension
    {

        public static void ProcessList<T>(this List<T> input, Func<T, bool> predicate)
        {
            List<T> result = new();
            foreach (var item in input)
            {
                if (predicate.Invoke(item)) { 
                result.Add(item);}
            }
        }
    }
}
