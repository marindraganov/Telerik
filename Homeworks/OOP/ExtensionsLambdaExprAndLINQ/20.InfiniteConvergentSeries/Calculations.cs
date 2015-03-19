namespace _20.InfiniteConvergentSeries
{
    using System;

    public static class Calculations
    {
        public delegate double NthMember<T>(T firstMember, int i);

        public static double CalculateConvergentSerieSum<T>(NthMember<T> nextMemberFormula, T firsMember, int precision)
        {
            double precisionPoint = 1 / (10 * (precision + 1));
            double firstMemberAsDecimal = (dynamic)firsMember;
            double currMember = firstMemberAsDecimal;
            double sum = currMember;

            for (int i = 1; Math.Abs(currMember) > precisionPoint; i++)
            {
                currMember = nextMemberFormula(firsMember, i);
                sum += currMember;
            }

            return Math.Round(sum, precision);
        }

        public static int Factorial(int number)
        {
            int answer = 1;

            for (int i = 1; i < number; i++)
            {
                answer *= i;
            }

            return answer;
        }
    }
}
