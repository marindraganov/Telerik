namespace _01.School
{
    using System;
    using System.Collections.Generic;

    public class Class : ICommentable
    {
        public Class(string textIdentifier)
        {
            this.Teachers = new HashSet<Teacher>();
            this.Students = new Dictionary<int, Student>();
            this.TextIdentifier = textIdentifier;
        }

        public string TextIdentifier { get; private set; }

        public HashSet<Teacher> Teachers { get; set; }

        public Dictionary<int, Student> Students { get; private set; }

        public List<string> Comments { get; set; }

        public int AddStudent(Student student)
        {
            int studentNumber = 0;

            while (this.Students.ContainsKey(studentNumber))
            {
                studentNumber++;
            }

            student.ClassNumber = studentNumber;
            this.Students.Add(student.ClassNumber, student);

            return studentNumber;
        }
    }
}
