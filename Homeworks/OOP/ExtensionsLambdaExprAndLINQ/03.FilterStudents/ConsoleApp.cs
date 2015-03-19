namespace _03.FilterStudents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ConsoleApp
    {
        public static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student("Pesho", "Todorov"),
                new Student("Deni", "Popova"),
                new Student("Hitar", "Petar"),
                new Student("Arnold", "Andonov"),
            };

            students = Student.FilterStudentsByName(students);

            foreach (var student in students)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}
