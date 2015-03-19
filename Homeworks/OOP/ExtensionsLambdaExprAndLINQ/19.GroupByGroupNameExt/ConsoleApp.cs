namespace _19.GroupByGroupNameExt
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ConsoleApp
    {
        public static void Main()
        {
            var listOfStudents = Student.CreateTestStudents();

            var groupedByGroupnumber = listOfStudents
                .GroupBy(st => st.GroupName);               

            foreach (var gr in groupedByGroupnumber)
            {
                Console.WriteLine("---Group {0}---", gr.Key);
                
                foreach (var student in gr)
                {
                    Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
                }

                Console.WriteLine();
            }
        }
    }
}
