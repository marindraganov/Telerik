namespace _01.School
{
    using System.Collections.Generic;

    public class Teacher : Human, ICommentable
    {
        public Teacher(string name)
            : base(name)
        {
        }

        public HashSet<Discipline> Disciplines { get; set; }
    }
}
