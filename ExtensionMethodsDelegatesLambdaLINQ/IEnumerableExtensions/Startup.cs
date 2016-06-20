/* Problem 2. IEnumerable extensions
Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
 */

using IEnumerableExtensions.Extensions;

namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Startup
    {
        public static void Main()
        {
            var collection = new List<int> { 1, 3, 5, 7, 9 };

            //some tests
            Console.WriteLine("Sum: " + collection.Sum());
            Console.WriteLine("Average: " + collection.Average());
            Console.WriteLine("Product: " + collection.Product());
            Console.WriteLine("Min: " + collection.Min());
            Console.WriteLine("Max: " + collection.Max());

        }
    }
}
