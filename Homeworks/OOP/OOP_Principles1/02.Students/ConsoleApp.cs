namespace _02.Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ConsoleApp
    {
        private static Random rnd = new Random();

        public static void Main()
        {
            // students
            List<Student> students = new List<Student>();

            for (int i = 0; i < 10; i++)
            {
                Student student = new Student("Pesho" + i, "Genchev", rnd.Next(1, 13));
                students.Add(student);
            }

            var sortedStudents = students.OrderBy(st => st.Grade);

            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("---------------------------------");

            // workers
            List<Worker> workers = new List<Worker>();

            for (int i = 0; i < 10; i++)
            {
                Worker worker = new Worker("Toshko" + i, "Worker", rnd.Next(8, 12), rnd.Next(500, 800));
                workers.Add(worker);
            }

            var sortedWorkers = workers.OrderBy(wk => wk.MoneyPerHour());

            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine(worker);
            }
        }
    }
}
