using System;

namespace MatrixCalculator
{
    public class Matrix
    {
        public double[,] Data { get; set; }
        public int Rows { get; private set; }
        public int Cols { get; private set; }

        public Matrix(int rows, int cols)
        {
            if (rows <= 0 || cols <= 0)
                throw new ArgumentException("Размеры матрицы должны быть положительными.");

            Rows = rows;
            Cols = cols;
            Data = new double[rows, cols];
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    result += $"{Data[i, j],8:F2}";
                }
                result += "\r\n";
            }
            return result;
        }
    }
}