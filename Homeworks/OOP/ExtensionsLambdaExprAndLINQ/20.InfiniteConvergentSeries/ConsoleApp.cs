namespace _20.InfiniteConvergentSeries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    public class ConsoleApp
    {
        public static void Main()
        {
            // 1 + 1/2 + 1/4 + 1/8 + 1/16 + …
            double firstSeqSum = Calculations.CalculateConvergentSerieSum(
                (n, i) => n / Math.Pow(2, i),
                1,
                2);

            Console.WriteLine("1 + 1/2 + 1/4 + 1/8 + 1/16 + ...");
            Console.WriteLine(firstSeqSum);
            Console.WriteLine();

            // 1/2 - 1/4 + 1/8 - 1/16 - …
            double secondSeqSum = Calculations.CalculateConvergentSerieSum(
                (n, i) => n * Math.Pow(-1, i % 2) / Math.Pow(2, i),
                0.5,
                2);

            Console.WriteLine("1 - 1/2 + 1/4 - 1/8 + 1/16 - ...");
            Console.WriteLine(secondSeqSum);
            Console.WriteLine();

            // 1 + 1/2! + 1/3! + 1/4! + 1/5! + …
            double thirdSeqSum = Calculations.CalculateConvergentSerieSum(
                (n, i) => n / Calculations.Factorial(i),
                1,
                0);

            Console.WriteLine("1 + 1/2! + 1/3! + 1/4! + 1/5! + ...");
            Console.WriteLine(thirdSeqSum);
            Console.WriteLine();

            // 1 + 1/2 - 1/4 + 1/8 - 1/16 + ...
            double fourthSeqSum = Calculations.CalculateConvergentSerieSum(
                (n, i) => n * ((i % 2 == 1 && i > 0) ? 1 : -1) / Math.Pow(2, i),
                1,
                2);

            Console.WriteLine("1 + 1/2 - 1/4 + 1/8 - 1/16 + ...");
            Console.WriteLine(fourthSeqSum);
            Console.WriteLine();
        }
    }
}
