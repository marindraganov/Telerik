namespace _06.DivisibleBy7And3
{
    using System;
    using System.Collections;
    using System.Linq;

    public class FindDivisibleBy7And3
    {
        public static void PrintNumbers(IEnumerable numbers)
        {
            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
        }

        public static void Main()
        {
            int[] numbers = new[] { 1, -42, 3, 7, 5, 21, 22, 27, };

            // Lambda
            var numbersWithExtAndLambda = numbers.Where(num => num % 3 == 0 && num % 7 == 0);

            PrintNumbers(numbersWithExtAndLambda);

            // LINQ
            var numbersWithLinq =
                from num in numbers
                where num % 3 == 0 && num % 7 == 0
                select num;

            PrintNumbers(numbersWithLinq);
        }
    }
}
