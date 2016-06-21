/// <summary>
///Problem 1. Student class
///Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties.
///Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
///
/// Problem 2. ICloneable
///Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.
///
/// Problem 3. IComparable
///Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) and by social security number (as second criteria, in increasing order).
/// 

namespace StudentClass
{
    using System;
    class TestStudent
    {
        static void Main(string[] args)
        {
            Student student = new Student("Jhon", "M", "Jakson", 10002922, "Telerik", "+359 885", "jakub.jakson@gmail.com");
            student.FillUniversityInfo(Student._University.SofiaUniversity, 4, Student._Faculty.Mathematics, Student._Speciality.IT);
            Console.WriteLine(student.GetHashCode());
            Student student2 = new Student("Mark", "S", "Morison", 10034222, "Telerik", "+359 883", "mark.morison@gmail.com");
            student2.FillUniversityInfo(Student._University.TechnicalUniversity, 4, Student._Faculty.Mathematics, Student._Speciality.IT);
            Console.WriteLine(student2.GetHashCode() + Environment.NewLine);

            Console.WriteLine(student);
            Console.WriteLine(student2);
            Console.WriteLine(student == student2);
            Console.WriteLine(student.Equals(student));
            Console.WriteLine(student.Equals(student2));
            Console.WriteLine(student != student2);
        }
    }
}