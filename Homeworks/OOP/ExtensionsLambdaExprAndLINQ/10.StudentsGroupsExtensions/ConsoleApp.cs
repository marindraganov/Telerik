using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.StudentsGroupsExtensions
{
    public class ConsoleApp
    {
        static void Main()
        {
            List<Student> studentList = Student.CreateTestStudents();

            var filteredAndSortedList = studentList
                .Where(st => st.GroupNumber == 2)
                .OrderBy(st => st.FirstName);

            foreach (var st in filteredAndSortedList)
            {
                Console.WriteLine("{0} {1}: group {2}", st.FirstName, st.LastName, st.GroupNumber);
            }
        }
    }
}
