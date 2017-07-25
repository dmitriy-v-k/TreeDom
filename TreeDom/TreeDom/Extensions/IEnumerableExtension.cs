using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDom.Extensions
{
    public static class IEnumerableExtension
    {
        public static IEnumerable<T> Add<T>(this IEnumerable<T> iEnumerable, T item) where T : class
        {
            var temp = iEnumerable.ToList();
            temp.Add(item);
            return temp;
        }
    }
}
