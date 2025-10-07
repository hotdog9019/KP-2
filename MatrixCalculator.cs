using System;

namespace MatrixCalculator
{
    public static class MatrixCalculator
    {
        // Пункт 4: Сложение матриц
        public static Matrix Add(Matrix a, Matrix b)
        {
            if (a.Rows != b.Rows || a.Cols != b.Cols)
                throw new ArgumentException("Для сложения матрицы должны иметь одинаковые размеры.");

            Matrix result = new Matrix(a.Rows, a.Cols);

            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Cols; j++)
                {
                    result.Data[i, j] = a.Data[i, j] + b.Data[i, j];
                }
            }

            return result;
        }

        // Пункт 5: Умножение матриц
        public static Matrix Multiply(Matrix a, Matrix b)
        {
            if (a.Cols != b.Rows)
                throw new ArgumentException("Для умножения количество столбцов первой матрицы должно равняться количеству строк второй матрицы.");

            Matrix result = new Matrix(a.Rows, b.Cols);

            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < b.Cols; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < a.Cols; k++)
                    {
                        sum += a.Data[i, k] * b.Data[k, j];
                    }
                    result.Data[i, j] = sum;
                }
            }

            return result;
        }

        // Детерминант матрицы
        public static double Determinant(Matrix matrix)
        {
            if (matrix.Rows != matrix.Cols)
                throw new ArgumentException("Детерминант можно вычислить только для квадратных матриц.");

            return CalculateDeterminant(matrix.Data, matrix.Rows);
        }

        private static double CalculateDeterminant(double[,] matrix, int n)
        {
            if (n == 1) return matrix[0, 0];
            if (n == 2) return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];

            double det = 0;
            for (int j = 0; j < n; j++)
            {
                double[,] minor = GetMinor(matrix, 0, j, n);
                det += (j % 2 == 0 ? 1 : -1) * matrix[0, j] * CalculateDeterminant(minor, n - 1);
            }
            return det;
        }

        private static double[,] GetMinor(double[,] matrix, int row, int col, int n)
        {
            double[,] minor = new double[n - 1, n - 1];
            int minorRow = 0;

            for (int i = 0; i < n; i++)
            {
                if (i == row) continue;
                int minorCol = 0;
                for (int j = 0; j < n; j++)
                {
                    if (j == col) continue;
                    minor[minorRow, minorCol] = matrix[i, j];
                    minorCol++;
                }
                minorRow++;
            }
            return minor;
        }

        // Обратная матрица
        public static Matrix Inverse(Matrix matrix)
        {
            if (matrix.Rows != matrix.Cols)
                throw new ArgumentException("Обратная матрица существует только для квадратных матриц.");

            double det = Determinant(matrix);
            if (Math.Abs(det) < 1e-10)
                throw new ArgumentException("Обратная матрица не существует, так как детерминант равен нулю.");

            int n = matrix.Rows;
            Matrix inverse = new Matrix(n, n);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    double[,] minor = GetMinor(matrix.Data, i, j, n);
                    double cofactor = ((i + j) % 2 == 0 ? 1 : -1) * CalculateDeterminant(minor, n - 1);
                    inverse.Data[j, i] = cofactor / det; // транспонирование
                }
            }

            return inverse;
        }

        // Транспонирование матрицы
        public static Matrix Transpose(Matrix matrix)
        {
            Matrix result = new Matrix(matrix.Cols, matrix.Rows);

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    result.Data[j, i] = matrix.Data[i, j];
                }
            }

            return result;
        }
    }
}