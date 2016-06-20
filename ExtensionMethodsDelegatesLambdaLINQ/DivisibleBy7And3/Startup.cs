/*
Problem 6. Divisible by 7 and 3
Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
 */
namespace DivisibleBy7And3
{
    using DivisibleBy7And3.Extensions;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Startup
    {
        static void Main()
        {
            int[] numbers = new int[] { 1, 3, 5, 7, 14, 18, 19, 27, 30, 80 };

            //extension method
            var newNumbers = ExtensionMethod.PrintDivisibleNumbers(numbers);

            Console.WriteLine(string.Join(", ", newNumbers));

            //LINQ query
            var sortedNumbers = from number in numbers
                                where number % 7 == 0 && number % 3 == 0
                                select number;

            Console.WriteLine(string.Join(", ", sortedNumbers.ToArray()));
        }
    }
}
