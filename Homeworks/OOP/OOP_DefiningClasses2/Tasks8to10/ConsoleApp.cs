namespace Tasks8to10
{
    using System;

    public class ConsoleApp
    {
        public static void Main()
        {
            Matrix<int> matrixA = new Matrix<int>(new[,]
            { 
                { 1, 2, 3 },
                { -4, 2, 3 },
                { 0, 22, 8 }
            });

            Matrix<int> matrixB = new Matrix<int>(new[,]
            { 
                { 4, 3, 0 }, 
                { 2, -3, 7 },
                { -2, 22, 3 }
            });

            Console.WriteLine("Matrix A");
            Console.WriteLine(matrixA);
            Console.WriteLine("Matrix B");
            Console.WriteLine(matrixB);
            Console.WriteLine("-------------------------");

            Console.WriteLine("Matrix A * A");
            Console.WriteLine(matrixA * matrixA);
            Console.WriteLine("Matrix A - B");
            Console.WriteLine(matrixA - matrixB);
            Console.WriteLine("Matrix A + B");
            Console.WriteLine(matrixA + matrixB);
        }       
    }
}
