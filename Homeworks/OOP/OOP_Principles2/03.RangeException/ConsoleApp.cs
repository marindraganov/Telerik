namespace _03.RangeException
{
    using System;

    public class ConsoleApp
    {
        public static void Main()
        {
            int startLimit = 1;
            int endLimit = 100;
            int inputNumber;

            Console.Write("Enter number in range [{0}...{1}] : ", startLimit, endLimit);

            if (!int.TryParse(Console.ReadLine(), out inputNumber))
            {
                throw new ArgumentException("You didn't enter a valid number!");
            }
            else if (inputNumber < startLimit || inputNumber > endLimit)
            {
                throw new InvalidRangeException<int>(startLimit, endLimit);
            }

            Console.WriteLine("Thank you!");

            DateTime startDate = new DateTime(1980, 1, 1);
            DateTime endDate = new DateTime(2013, 12, 31);
            DateTime inputDate;

            Console.WriteLine("Now please enter date in format dd/MM/yyyy and in range [{0:dd/MM/yyyy}...{1:dd/MM/yyyy}] : ", startDate, endDate);

            if (!DateTime.TryParse(Console.ReadLine(), out inputDate))
            {
                throw new ArgumentException("You didn't enter a valid date in a valid format!");
            }
            else if (inputDate < startDate || inputDate > endDate)
            {
                throw new InvalidRangeException<DateTime>(startDate, endDate);
            }
        }
    }
}
