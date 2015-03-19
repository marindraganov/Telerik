namespace _01.SBExtension
{
    using System;
    using System.Text;

    public class ConsoleApp
    {
        public static void Main()
        {
            StringBuilder letters = new StringBuilder("absdefghijklmnop");
            Console.WriteLine(letters.Substring(3, 4));
        }
    }
}
