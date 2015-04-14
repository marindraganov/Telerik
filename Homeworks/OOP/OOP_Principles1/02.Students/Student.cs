namespace _02.Students
{
    using System.Text;

    public class Student : Human
    {
        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public int Grade { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} grade - {2}", this.FirstName, this.LastName, this.Grade);
        }
    }
}
