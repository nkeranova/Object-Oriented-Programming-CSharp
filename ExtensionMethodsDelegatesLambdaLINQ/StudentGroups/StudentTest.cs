/// <summary>
/// Problem 9. Student groups
/// Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
/// Create a List<Student> with sample students. Select only the students that are from group number 2.
/// Use LINQ query. Order the students by FirstName.
/// 
/// Problem 10. Student groups extensions
/// Implement the previous using the same query expressed with extension methods.
/// 
/// Problem 11. Extract students by email
/// Extract all students that have email in abv.bg.
/// Use string methods and LINQ.
/// 
/// Problem 12. Extract students by phone
/// Extract all students with phones in Sofia.
/// Use LINQ.
/// 
/// Problem 13. Extract students by marks
/// Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
/// Use LINQ.
/// 
/// Problem 14. Extract students with two marks
/// Write down a similar program that extracts the students with exactly two marks "2".
/// Use extension methods.
/// 
/// Problem 15. Extract marks
/// Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
/// 
/// Problem 16.* Groups
/// Create a class Group with properties GroupNumber and DepartmentName.
/// Introduce a property GroupNumber in the Student class.
/// Extract all students from "Mathematics" department.
/// Use the Join operator.
/// </summary>
/// 

namespace StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentTest
    {
        public static readonly List<Student> students = new List<Student>
		{
			new Student("Nikolay", "Kostov", "23340606","0299999999", "ivan@abv.bg", 3,           3, 3, 3, 5, 4, 1),
			new Student("Evlogi", "Georgiev", "11111105", "+359212345123", "g@G.G", 2,              1, 1, 1, 1),
			new Student("Ivo", "Kenov", "23361406","+359877333444", "baaaaan@abv.bg", 2,   6, 6, 6, 6),
			new Student("Doncho", "Minkov", "12310608","+359874334144", "gorilaz@gmail.bg", 3, 6, 6, 6, 4, 6, 1),
			new Student("Sava", "Rakovski", "88888844","07333441114", "baven@abv.bg", 2,       2, 2, 3, 4),
			new Student("Vasil", "Levski", "14514506","+359211434442", "please@abv.bg", 2,     6, 6, 6, 4, 6, 1),
			new Student("Doncho", "Minkov", "12345608","+359874334442", "gorilaz@gmail.bg", 3, 3, 3, 3, 4, 3, 1)
		};

        public static void Main()
        {
            SolveProblemNo9();
            SolveProblemNo10();
            SolveProblemNo11();
            SolveProblemNo12();
            SolveProblemNo13();
            SolveProblemNo14();
            SolveProblemNo15();
            SolveProblemNo16();
        }

        private static void SolveProblemNo9()
        {
            Console.WriteLine("Problem 9:");
            Console.WriteLine(new string('=', 70));

            var studentsFromSecondGroup =
                from student in students
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;

            foreach (var student in studentsFromSecondGroup)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            Console.WriteLine(new string('=', 70));
        }

        private static void SolveProblemNo10()
        {
            Console.WriteLine("Problem 10:");
            Console.WriteLine(new string('=', 70));

            var studentsFromSecondGroup = students.Where(st => st.GroupNumber == 2)
                                                  .OrderBy(st => st.FirstName);

            foreach (var student in studentsFromSecondGroup)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            Console.WriteLine(new string('=', 70));
        }

        private static void SolveProblemNo11()
        {
            Console.WriteLine("Problem 11:");
            Console.WriteLine(new string('=', 70));

            var selectedStudents =
                from student in students
                where student.Email.Substring(student.Email.IndexOf("@") + 1) == "abv.bg"
                select student;

            foreach (var student in selectedStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            Console.WriteLine(new string('=', 70));
        }

        private static void SolveProblemNo12()
        {
            Console.WriteLine("Problem 12:");
            Console.WriteLine(new string('=', 70));

            var selectedStudents =
                from student in students
                where student.Telephone.StartsWith("+3592") || student.Telephone.StartsWith("02")
                select student;

            foreach (var student in selectedStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            Console.WriteLine(new string('=', 70));
        }

        private static void SolveProblemNo13()
        {
            Console.WriteLine("Problem 13:");
            Console.WriteLine(new string('=', 70));

            var selectedStudents =
                from student in students
                where student.Marks.Contains(6)
                select student;

            foreach (var student in selectedStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            Console.WriteLine(new string('=', 70));
        }

        private static void SolveProblemNo14()
        {
            Console.WriteLine("Problem 14:");
            Console.WriteLine(new string('=', 70));

            var selectedStudents = students.Where(st => st.Marks.Count(x => Math.Abs(x - 2) < 0.4) == 2);

            foreach (var student in selectedStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            Console.WriteLine(new string('=', 70));
        }

        private static void SolveProblemNo15()
        {
            Console.WriteLine("Problem 15:");
            Console.WriteLine(new string('=', 70));

            var selectedStudents = students.Where(st => st.FacultyNumber[4] == '0' && st.FacultyNumber[5] == '6');

            foreach (var student in selectedStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            Console.WriteLine(new string('=', 70));
        }

        private static void SolveProblemNo16()
        {
            Console.WriteLine("Problem 16:");
            Console.WriteLine(new string('=', 70));

            var groups = new List<Group>
			             {
							 new Group(1, "Physics"),
							 new Group(2, "Arts"),
							 new Group(3, "Mathematics"),
							 new Group(4, "Law"),
							 new Group(5, "Medicine"),
							 new Group(6, "Biology")
			             };

            var selectedStudents =
                from student in students
                join grp in groups on student.GroupNumber equals grp.GroupNumber
                where grp.DepartmentName == "Mathematics"
                select student;

            foreach (var student in selectedStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            Console.WriteLine(new string('=', 70));
        }
    }
}