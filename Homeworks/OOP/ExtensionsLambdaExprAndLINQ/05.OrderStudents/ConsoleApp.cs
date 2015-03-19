namespace _05.OrderStudents
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
                new Student("Hitar", "Petar"),
                new Student("Arnold", "Andonov"),
                new Student("Ani", "First"),
                new Student("Pesho", "Veliki"),
                new Student("Donka", "Sexyto"),
                new Student("Ani", "Second"),
                new Student("Recep", "Ivedik")
            };

            var sortedByNames = students
                .OrderBy(st => st.FirstName)
                .ThenBy(st => st.LastName)
                .Select(st => st);

            Console.WriteLine("Students sorted by first then by second name");

            foreach (var st in sortedByNames)
            {
                Console.WriteLine("{0} {1}", st.FirstName, st.LastName);
            }
        }
    }
}
