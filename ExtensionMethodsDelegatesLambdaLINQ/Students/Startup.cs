/// <summary>
/// Problem 3. First before last Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
/// Use LINQ query operators.
/// 
/// Problem 4. Age range
/// Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
/// 
/// Problem 5. Order students
/// Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
/// Rewrite the same with LINQ.
/// </summary>
///

namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        static void Main()
        {
            var students = new List<Student>()
            {
                new Student("Pesho","Peshev",21),
                new Student("Maria","Petkova",34),
                new Student("Pesho","Stoqnov",54),
                new Student("Sonq","Kolqnova",23),
                new Student("Polq","Pesheva",12),
                new Student("Pesho","Petrov",20),
                new Student("Ivan","Toshev",43),
                new Student("Gosho","Peshev",33),
                new Student("Dragan","Kirov",18),
                new Student("Maria","Paraskeva",24),
            };

            //Task 3
            // Lambda and linq
            var sort = students
                .Where(st => st.FirstName.CompareTo(st.LastName) < 0);

            Print(sort);
            Console.WriteLine();

            // Linq only
            var sortLinqOnly =
                from st in students
                where st.FirstName.CompareTo(st.LastName) < 0
                select st;

            Print(sortLinqOnly);
            Console.WriteLine();

            // Task 4
            // Lambda and linq
            var sortBetweenAge = students
                .Where(st => st.Age >= 18 && st.Age <= 24);

            Print(sortBetweenAge);
            Console.WriteLine();

            // linq only
            var sortAgainBetweenAge =
                from st in students
                where st.Age >= 18 && st.Age <= 24
                select st;

            Print(sortAgainBetweenAge);
            Console.WriteLine();

            // Task 5
            // Lambda and linq
            var sortDescending = students
                .OrderByDescending(st => st.FirstName)
                .ThenByDescending(st => st.LastName);

            Print(sortDescending);
            Console.WriteLine();

            // linq only
            var sordDescendingAgain =
                from st in students
                orderby st.FirstName descending,
                st.LastName descending
                select st;

            Print(sordDescendingAgain);
        }

        public static void Print(IEnumerable<Student> students)
        {
            foreach (var st in students)
            {
                Console.WriteLine(st);
            }
        }
    }
}