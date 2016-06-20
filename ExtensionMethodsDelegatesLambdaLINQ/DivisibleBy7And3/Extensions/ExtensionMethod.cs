
namespace DivisibleBy7And3.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class ExtensionMethod
    {
        public static int[] PrintDivisibleNumbers(this int[] array)
        {
            var newArr = array
                              .Where(x => x % 3 == 0 && x % 7 == 0)
                              .ToArray();

            return newArr;
        }
    }
}
