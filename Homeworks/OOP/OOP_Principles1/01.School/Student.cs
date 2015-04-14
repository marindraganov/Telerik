namespace _01.School
{
    using System.Collections.Generic;

    public class Student : Human, ICommentable
    {
        public Student(string name)
            : base(name)
        {
        }

        public int ClassNumber { get; set; }
    }
}
