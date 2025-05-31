using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public static class FilterExtenstion
    {
        public static List<T> Filter<T>(this List<T> records, Func<T, bool> func)
        { 
          List<T> filterlist = new();
            foreach (T record in records)
            {
                if (func(record))
                {
                    filterlist.Add(record);
                }
            }
            return filterlist;
        }
    }
}
