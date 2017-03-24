using System.Collections.Generic;
using System.Linq;

namespace JasonetteDotNet
{
    internal static class EnumerableExtensions
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> e)
        {
            if(e == null)
                return true;

            return !e.Any();
        }
    }
}
