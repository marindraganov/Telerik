namespace _12.ExtractByPhone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ConsoleApp
    {
        public static void Main()
        {
            List<Student> studentList = Student.CreateTestStudents();

            var filteredByMail =
                from st in studentList
                where st.Tel.StartsWith("02")
                select st;

            foreach (var st in filteredByMail)
            {
                Console.WriteLine("{0} {1} - phone: {2}", st.FirstName, st.LastName, st.Tel);
            }
        }
    }
}
