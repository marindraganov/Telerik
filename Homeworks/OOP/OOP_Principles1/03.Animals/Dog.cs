namespace _03.Animals
{
    public class Dog : Animal
    {
        public Dog(string name, int age, Sex sex)
            : base(name, age, sex)
        {
        }

        public override void MakeSound()
        {
            System.Console.WriteLine(".=Yo man! I am speaking dog=.");
        }
    }
}
