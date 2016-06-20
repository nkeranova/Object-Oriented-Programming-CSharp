namespace Students.Extensions
{
    using System.Linq;

    public static class ExtensionsMethods
    {
        public static Students[] OrderStudents(Students[] students)
        {
            var orderedStudents = students
                .OrderByDescending(st => st.FirstName)
                .ThenByDescending(st => st.LastName);

            return orderedStudents.ToArray();
        }
    }
}
