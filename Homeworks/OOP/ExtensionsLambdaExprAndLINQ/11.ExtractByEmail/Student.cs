namespace _11.ExtractByEmail
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
                    Tel = "02 987 55 55",
                    Email = "vanko1@abv.bg",
                    Marks = new List<int> { 2, 3, 4 },
                    GroupNumber = 1
                },
                new Student
                {
                    FirstName = "Ana",
                    LastName = "Doncheva",
                    FN = 1314,
                    Tel = "056 812 218",
                    Email = "anito@mail.bg",
                    GroupNumber = 1
                },
                new Student
                {
                    FirstName = "Pesho",
                    LastName = "Bagera",
                    FN = 1514,
                    Tel = "02/342 21 32",
                    Email = "pe@gmail.com",
                    GroupNumber = 2
                },
                new Student
                {
                    FirstName = "Vesko",
                    LastName = "Choveka",
                    FN = 1354,
                    Tel = "0883 333 444",
                    Email = "choveka@abv.bg",
                    GroupNumber = 2
                },
                new Student
                {
                    FirstName = "Poli",
                    LastName = "Gorcheva",
                    FN = 1544,
                    Tel = "0431 725 25",
                    Email = "polence@abv.bg",
                    GroupNumber = 3
                },
                new Student
                {
                    FirstName = "Dilqna",
                    LastName = "Gorcheva",
                    FN = 1500,
                    Tel = "*88",
                    Email = "di_gorcheva@yahoo.com",
                    GroupNumber = 2
                },
            };

            return studentList;
        }
    }
}