using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyUniqueElements
{
    public class UniqueItems
    {
        public static T[] OnlyReturnUniqueItems<T>(T[] array)
        {
            var uniqueItems = new HashSet<T>();
            var sortedResult = new List<T>();

            foreach (var item in array) 
            {
                if (uniqueItems.Add(item))
                {
                    sortedResult.Add(item);
                }
            }

            return sortedResult.ToArray();
        }
    }
}
