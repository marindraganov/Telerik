namespace _15.ExtractMarks
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
                    FN = 131309,
                    Tel = "02 987 55 55",
                    Email = "vanko1@abv.bg",
                    Marks = new List<int> { 2, 3, 4 },
                    GroupNumber = 1
                },
                new Student
                {
                    FirstName = "Ana",
                    LastName = "Doncheva",
                    FN = 131410,
                    Tel = "056 812 218",
                    Email = "anito@mail.bg",
                    Marks = new List<int> { },
                    GroupNumber = 1
                },
                new Student
                {
                    FirstName = "Pesho",
                    LastName = "Bagera",
                    FN = 151406,
                    Tel = "02/342 21 32",
                    Email = "pe@gmail.com",
                    Marks = new List<int> { 4, 5, 5 },
                    GroupNumber = 2
                },
                new Student
                {
                    FirstName = "Vesko",
                    LastName = "Choveka",
                    FN = 135409,
                    Tel = "0883 333 444",
                    Email = "choveka@abv.bg",
                    Marks = new List<int> { 6, 6, 6, 6 },
                    GroupNumber = 2
                },
                new Student
                {
                    FirstName = "Poli",
                    LastName = "Gorcheva",
                    FN = 154406,
                    Tel = "0431 725 25",
                    Email = "polence@abv.bg",
                    Marks = new List<int> { 5, 5, 6 },
                    GroupNumber = 3
                },
                new Student
                {
                    FirstName = "Dilqna",
                    LastName = "Gorcheva",
                    FN = 150011,
                    Tel = "*88",
                    Email = "di_gorcheva@yahoo.com",
                    Marks = new List<int> { 2, 3, 2 },
                    GroupNumber = 4
                },
                new Student
                {
                    FirstName = "Toshko",
                    LastName = "Slabakov",
                    FN = 150306,
                    Tel = "0900 000 111",
                    Email = "toshko_hubaveca@gmail.com",
                    Marks = new List<int> { 2, 2 },
                    GroupNumber = 2
                },
            };

            return studentList;
        }
    }
}