namespace _18.GroupByGroupName
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ConsoleApp
    {
        public static void Main()
        {
            var listOfStudents = Student.CreateTestStudents();

            var groupedByGroupnumber =
                from st in listOfStudents
                group st by st.GroupName into gr
                select new { GroupName = gr.Key, Students = gr.ToList() };

            foreach (var gr in groupedByGroupnumber)
            {
                Console.WriteLine("---Group {0}---", gr.GroupName);

                foreach (var student in gr.Students)
                {
                    Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
                }

                Console.WriteLine();
            }
        }
    }
}
