namespace _04.Person
{
    using System;
    using System.Text;

    public class ConsoleApp
    {
        public static void Main()
        {
            Person pesho = new Person("Pesho");
            Person gosho = new Person("Gosho", 20);

            Console.WriteLine(pesho);
            Console.WriteLine(gosho);
        }
    }
}