/*Problem 3. First before last
Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
Use LINQ query operators.

Problem 4. Age range
Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

Problem 5. Order students
Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
Rewrite the same with LINQ.
 */

namespace Students
{
    using System;
    using System.Linq;

    public class Startup
    {
        static void Main()
        {
            var students = new Students []
            {
                new Students("Petar", "Petrov", 33),
                new Students("Toshko", "Toshev", 22),
                new Students("Gosho", "Goshev", 29),
                new Students("Andrea", "Andreeva", 25),
                new Students("Blagoi", "Blagoev", 24),
                new Students("Ani", "Nikolova", 27)
            };              

            //Test: print all students with names
            var studentsNames = FindStudenstWithFirstName(students);

            foreach (var student in studentsNames)
            {
                Console.WriteLine(string.Join(", ", student));
            }
        }

        public static Students[] FindStudenstWithFirstName(Students [] students)
        {
            var newStudents = from student in students
                              where student.FirstName.CompareTo(student.LastName) < 0
                              select student;

            return newStudents.ToArray();
        }

        public static Students[] FindAllStudentsWithAge(Students[] students)
        {
            var newStudents = from student in students
                              where student.Age >= 18 && student.Age <= 24
                              select student;

            return newStudents.ToArray();
        }
    }
}
/*
            var newStudents = students
                .Where(st => string.Compare(st.FirstName, st.LastName) < 0)
                .ToArray();
*/