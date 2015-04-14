namespace _01.School
{
    using System.Collections.Generic;

    public class School
    {
        public School()
        {
            this.Classes = new Dictionary<string, Class>();
        }

        public Dictionary<string, Class> Classes { get; set; }

        public void AddClass(Class classToBeAdd)
        {
            if (this.Classes.ContainsKey(classToBeAdd.TextIdentifier))
            {
                System.Console.WriteLine("Class with identifier {0} already exist!", classToBeAdd.TextIdentifier);
            }
            else
            {
                this.Classes.Add(classToBeAdd.TextIdentifier, classToBeAdd);
            }
        }
    }
}
