namespace _03.FilterStudents
{
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public static List<Student> FilterStudentsByName(List<Student> students)
        {
            // LINQ wtih Lambda
            //var filteredStudents = students.Where(st => st.FirstName.CompareTo(st.LastName) == -1);

            // LINQ old school
            var filteredStudents =
                from st in students
                where st.FirstName.CompareTo(st.LastName) == -1
                select st;

            return filteredStudents.ToList();
        }
    }
}
