namespace _01.School
{
    using System.Collections.Generic;

    public abstract class Human : ICommentable
    {
        public Human(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public List<string> Comments { get; set; }
    }
}
