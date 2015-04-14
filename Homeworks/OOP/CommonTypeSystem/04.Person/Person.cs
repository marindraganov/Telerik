namespace _04.Person
{
    using System;

    public class Person
    {
        public Person(string name)
        {
            this.Name = name;
        }

        public Person(string name, int age)
            : this(name)
        {
            this.Age = age;
        }

        public int? Age { get; private set; }

        public string Name { get; private set; }

        public override string ToString()
        {
            string personInfo = string.Format("Name: {0}, Age: {1}", this.Name, this.Age == null ? "not specified" : this.Age.ToString());
           
            return personInfo;
        }
    }
}