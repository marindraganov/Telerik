namespace _01.School
{
    using System.Collections.Generic;

    public class Discipline : ICommentable
    {
        public Discipline(int numberOfLectures, int numberOfExercises)
        {
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }

        public string Name { get; set; }

        public int NumberOfLectures { get; set; }

        public int NumberOfExercises { get; set; }

        public List<string> Comments { get; set; }
    }
}
