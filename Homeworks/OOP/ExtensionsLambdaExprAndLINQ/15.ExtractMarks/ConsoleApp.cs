namespace _15.ExtractMarks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ConsoleApp
    {
        public static void Main()
        {
            List<Student> studentList = Student.CreateTestStudents();

            var enrolled06 = studentList.Where(st =>
            {
                string fnAsString = st.FN.ToString();

                if (fnAsString[4] == '0' && fnAsString[5] == '6')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });

            foreach (var st in enrolled06)
            {
                Console.WriteLine("{0} {1} FN: {2}", st.FirstName, st.LastName, st.FN);
            }
        }
    }
}
