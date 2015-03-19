namespace _13_14.ExtractByMarks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ConsoleApp
    {
        public static void Main()
        {
            List<Student> studentList = Student.CreateTestStudents();

            var filteredWithExcellent =
                from st in studentList
                where st.Marks.Contains(6)
                select st;

            Console.WriteLine("Students with at least one excellent mark 6:");
            PrintStudentsWithMarks(filteredWithExcellent.ToList());

            var filteredWithTwoPoorMarks = studentList.Where(st => st.Marks.Count == 2)
                .Where(st =>
                {
                    foreach (var mark in st.Marks)
                    {
                        if (mark != 2) return false;
                    }

                    return true;
                });

            Console.WriteLine("Students with two poor marks:");
            PrintStudentsWithMarks(filteredWithTwoPoorMarks.ToList());
        }

        public static void PrintStudentsWithMarks(List<Student> students)
        {
            foreach (var st in students)
            {
                Console.Write("{0} {1} - marks: ", st.FirstName, st.LastName);

                foreach (var mark in st.Marks)
                {
                    Console.Write("{0}, ", mark);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
