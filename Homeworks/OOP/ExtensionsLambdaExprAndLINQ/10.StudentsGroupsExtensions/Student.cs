namespace _10.StudentsGroupsExtensions
{
    using System.Collections.Generic;

    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int FN { get; set; }

        public string Tel { get; set; }

        public string Email { get; set; }

        public List<int> Marks { get; set; }

        public int GroupNumber { get; set; }

        public static List<Student> CreateTestStudents()
        {
            List<Student> studentList = new List<Student>
            {
                new Student
                {
                    FirstName = "Ivan",
                    LastName = "Ivanov",
                    FN = 1313,
                    Email = "vanko1@abv.bg",
                    Marks = new List<int> { 2, 3, 4 },
                    GroupNumber = 1
                },
                new Student
                {
                    FirstName = "Ana",
                    LastName = "Doncheva",
                    FN = 1314,
                    GroupNumber = 1
                },
                new Student
                {
                    FirstName = "Pesho",
                    LastName = "Bagera",
                    FN = 1514,
                    GroupNumber = 2
                },
                new Student
                {
                    FirstName = "Vesko",
                    LastName = "Choveka",
                    FN = 1354,
                    GroupNumber = 2
                },
                new Student
                {
                    FirstName = "Poli",
                    LastName = "Gorcheva",
                    FN = 1544,
                    GroupNumber = 3
                },
                new Student
                {
                    FirstName = "Dilqna",
                    LastName = "Gorcheva",
                    FN = 1500,
                    GroupNumber = 2
                },
            };

            return studentList;
        }
    }
}
