namespace Tasks8to10
{
    using System;
    using System.Collections;
    using System.Text;

    public class Matrix<T> : IEnumerable
        where T : struct
    {
        private T[,] data;

        public Matrix(int raw, int cal)
        {
            this.data = new T[raw, cal];
        }

        public Matrix(T[,] matrix)
        {
            this.data = matrix;
        }

        public int Rows
        {
            get { return this.data.GetLength(0); }
        }

        public int Cols
        {
            get { return this.data.GetLength(1); }
        }

        public T this[int row, int col]
        {
            get
            {
                if (row < 0 || row >= this.Rows
                    || col < 0 || col >= this.Cols)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return this.data[row, col];
            }

            set 
            {
                if (row < 0 || row >= this.Rows
                    || col < 0 || col >= this.Cols)
                {
                    throw new ArgumentOutOfRangeException();
                } 

                this.data[row, col] = value; 
            }
        }

        public static Matrix<T> operator *(int multiplier, Matrix<T> matrix)
        {
            int rowsCount = matrix.Rows;
            int colsCount = matrix.Cols;

            Matrix<T> product = new Matrix<T>(rowsCount, colsCount);

            for (int row = 0; row < rowsCount; row++)
            {
                for (int col = 0; col < colsCount; col++)
                {
                    product[row, col] += (dynamic)matrix[row, col] * (dynamic)multiplier;
                }
            }

            return product;
        }

        public static Matrix<T> operator +(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Cols != matrix2.Cols)
            {
                throw new System.ArgumentException("You can add matrices with same size only");
            }

            int rows = matrix1.Rows;
            int cols = matrix1.Cols;

            Matrix<T> sum = new Matrix<T>(rows, cols);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    sum[row, col] = (dynamic)matrix1[row, col] + (dynamic)matrix2[row, col];
                }
            }

            return sum;
        }

        public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Cols != matrix2.Cols)
            {
                throw new System.ArgumentException("You can subtract matrices with same size only");
            }

            int rows = matrix1.Rows;
            int cols = matrix1.Cols;

            Matrix<T> substraction = new Matrix<T>(rows, cols);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    substraction[row, col] = (dynamic)matrix1[row, col] - (dynamic)matrix2[row, col];
                }
            }

            return substraction;
        }

        public static Matrix<T> operator *(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Rows != matrix2.Cols &&
                matrix1.Cols != matrix2.Rows)
            {
                throw new System.ArgumentException("You can multiply matrix with size MxN with matrix with size NxM only.");
            }

            int biggerSize = Math.Max(matrix1.Rows, matrix1.Cols);
            int smallSize = Math.Min(matrix1.Rows, matrix1.Cols);

            Matrix<T> product = new Matrix<T>(biggerSize, biggerSize);

            for (int row = 0; row < smallSize; row++)
            {
                for (int col = 0; col < smallSize; col++)
                {
                    for (int inner = 0; inner < biggerSize; inner++)
                    {
                        product[row, col] += (dynamic)matrix1[row, inner] * (dynamic)matrix2[inner, col];
                    }
                }
            }

            return product;
        }

        public IEnumerator GetEnumerator()
        {
            return this.data.GetEnumerator();
        }

        public override string ToString()
        {
            StringBuilder matrixInString = new StringBuilder();

            for (int i = 0; i < this.data.GetLength(0); i++)
            {
                for (int j = 0; j < this.data.GetLength(1); j++)
                {
                    matrixInString.Append(Convert.ToString(this.data[i, j]).PadLeft(5, ' '));
                }

                matrixInString.AppendLine();
            }

            return matrixInString.ToString();
        }
    }
}
