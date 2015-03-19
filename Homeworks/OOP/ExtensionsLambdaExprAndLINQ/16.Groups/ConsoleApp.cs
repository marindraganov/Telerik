namespace _16.Groups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ConsoleApp
    {
        public static void Main()
        {
            List<Group> groups = new List<Group>
            { 
                new Group(1, "Biology"),
                new Group(2, "Mathematics"),
                new Group(3, "Mathematics"),
                new Group(4, "IT")
            };

            List<Student> studentList = Student.CreateTestStudents();

            var studentsWithDepartments =
                from st in studentList
                join gr in groups on st.GroupNumber equals gr.GroupNumber
                where gr.DepartmentName == "Mathematics"
                select new 
                { 
                    st.FirstName, 
                    st.LastName, 
                    st.GroupNumber, 
                    gr.DepartmentName
                };

            foreach (var st in studentsWithDepartments)
            {
                Console.WriteLine(
                    "{0} {1} group: {2}, department: {3}", 
                    st.FirstName, 
                    st.LastName, 
                    st.GroupNumber, 
                    st.DepartmentName);
            }
        }
    }
}
