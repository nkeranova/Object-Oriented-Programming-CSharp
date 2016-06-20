
namespace IEnumerableExtensions.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtensions
    {
        public static decimal Sum<T>(this IEnumerable<T> collection) //where T : IConvertible
        {
            var sum = 0M;

            var decCollection = collection.Select(x => Convert.ToDecimal(x));

            foreach (var number in decCollection)
            {
                sum += (decimal)number;
            }

            return sum;
        }

        public static decimal Product<T>(this IEnumerable<T> collection)
        {
            var decCollection = collection.Select(x => Convert.ToDecimal(x));

            var product = 1m;

            foreach (var number in decCollection)
            {
                product *= number;
            }

            return product;
        }

        public static decimal Min<T>(this IEnumerable<T> collection)
        {
            var decCollection = collection.Select(x => Convert.ToDecimal(x)).ToList();

            var min = decCollection.Min(); //decimal.MinValue;

            return min;
        }

        public static decimal Max<T>(this IEnumerable<T> collection)
        {
            var decCollection = collection.Select(x => Convert.ToDecimal(x)).ToList();

            var max = decCollection.Max();

            return max;
        }

        public static decimal Avarage<T>(this IEnumerable<T> collection)
        {
            var avarage = 0M;

            var decCollection = collection.Select(x => Convert.ToDecimal(x)).ToList();

            var sum = decCollection.Sum();

            avarage = sum / decCollection.Count();

            return avarage;
        }
    }
}
