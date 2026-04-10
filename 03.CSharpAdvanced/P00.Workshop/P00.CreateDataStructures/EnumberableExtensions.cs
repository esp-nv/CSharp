using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00.CreateDataStructures
{
    public static class EnumberableExtensions
    {
        public static MyListGeneric<T> ToMyListGeneric<T>(this IEnumerable<T> enumerable)
        {
            var list = new MyListGeneric<T>();
            foreach (var item in enumerable)
            { 
                list.Add(item);
            }
            return list;
        }
    }
}
