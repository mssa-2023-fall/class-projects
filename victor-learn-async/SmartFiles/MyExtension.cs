using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SmartFiles
{
    public static class MyExtension //extension methods must exist in static class
    {
        //the first parameter indicates the Type which you would like to extend
        public static void ProcessList<T>(this List<T> inputList, Action<T> toPerform) { 
            foreach (var item in inputList)
            {
                toPerform(item);
            }
        }
        
    }
}
