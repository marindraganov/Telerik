namespace _04.AgeRange
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
                new Student("Pesho", "Todorov", 12),
                new Student("Deni", "Popova", 20),
                new Student("Hitar", "Petar", 24),
                new Student("Arnold", "Andonov", 46),
                new Student("Bobi", "Bobchev", 25),
                new Student("Donka", "Sexyto", 20),
            };

            // Extensions
            //var filteredByAge = students
            //    .Where(st => st.Age >= 18 && st.Age <= 24)
            //    .Select(st => new
            //    {
            //        FirstName = st.FirstName,
            //        LastName = st.LastName
            //    });

            // LINQ 
            var filteredByAge =
                from st in students
                where st.Age >= 18 && st.Age <= 24
                select new
                {
                    FirstName = st.FirstName,
                    LastName = st.LastName
                };

            foreach (var student in filteredByAge)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}