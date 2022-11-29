using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV4
{
    public static class ExtensionGenericList
    {
        public static void RemoveRepetidos<T>(this GenericList<T> entity) where T : notnull
        {

        }
    }
}


//REFERENCIAS 
//https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.where?view=net-7.0
//https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/generics