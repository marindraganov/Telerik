namespace _03.Animals
{
    using System;

    public class ConsoleApp
    {
        public static void Main()
        {
            Animal[] animals = new Animal[]
            {
                new Dog("Sharo", 5, Sex.Male),
                new Frog("Pesho", 4, Sex.Male),
                new Cat("Amanda", 2, Sex.Female),
                new Kitten("Kitty", 2),
                new TomCat("Boncho", 4)
            };

            foreach (var animal in animals)
            {
                Console.Write(animal.Name + "-");
                animal.MakeSound();
            }

            Console.WriteLine("average age is " + Animal.AverageAge(animals));
        }
    }
}
