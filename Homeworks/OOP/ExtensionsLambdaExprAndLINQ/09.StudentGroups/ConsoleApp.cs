namespace _09.StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ConsoleApp
    {
        static void Main()
        {
            List<Student> studentList = Student.CreateTestStudents();

            var filteredAndSortedList =
                from st in studentList
                where st.GroupNumber == 2
                orderby st.FirstName
                select st;

            foreach (var st in filteredAndSortedList)
            {
                Console.WriteLine("{0} {1}: group {2}", st.FirstName, st.LastName, st.GroupNumber);
            }
        }
    }
}
