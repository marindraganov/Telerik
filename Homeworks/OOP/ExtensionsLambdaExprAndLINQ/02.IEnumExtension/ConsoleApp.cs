namespace _02.IEnumExtension
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ConsoleApp
    {
        public static void Main()
        {
            List<int> list = new List<int> { 1, -3, 2, 5 };

            Console.WriteLine(list.ExtendedToString());
            Console.WriteLine("Sum: {0}", list.Sum());
            Console.WriteLine("Average: {0}", list.Average());
            Console.WriteLine("Min: {0}", list.Min());
            Console.WriteLine("Max: {0}", list.Max());
        }
    }
}
