namespace _11.ExtractByEmail
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class ConsoleApp
    {
        public static void Main()
        {
            List<Student> studentList = Student.CreateTestStudents();

            var filtereByMail =
                from st in studentList
                where st.Email.Contains("abv.bg")
                select st;

            foreach (var st in filtereByMail)
            {
                Console.WriteLine("{0} {1} - email: {2}", st.FirstName, st.LastName, st.Email);
            }
        }
    }
}