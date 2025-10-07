using System;
using System.Drawing;
using System.Windows.Forms;

namespace MatrixCalculator
{
    public partial class MainForm : Form
    {
        private Matrix matrixA;
        private Matrix matrixB;
        private TextBox[,] matrixAInputs;
        private TextBox[,] matrixBInputs;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCreateMatrices_Click(object sender, EventArgs e)
        {
            CreateMatrices();
        }

        private void CreateMatrices()
        {
            try
            {
                int rows = int.Parse(txtRows.Text);
                int cols = int.Parse(txtCols.Text);

                if (rows <= 0 || cols <= 0)
                {
                    MessageBox.Show("Размеры матрицы должны быть положительными числами.");
                    return;
                }

                matrixA = new Matrix(rows, cols);
                matrixB = new Matrix(rows, cols);

                CreateMatrixInputs(panelMatrixA, rows, cols, 'A');
                CreateMatrixInputs(panelMatrixB, rows, cols, 'B');
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные числовые значения для размеров матрицы.");
            }
        }

        private void CreateMatrixInputs(Panel panel, int rows, int cols, char matrixName)
        {
            panel.Controls.Clear();
            TextBox[,] inputs = new TextBox[rows, cols];
            int cellWidth = 40;
            int cellHeight = 20;
            int spacing = 5;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    TextBox txt = new TextBox
                    {
                        Location = new Point(j * (cellWidth + spacing), i * (cellHeight + spacing)),
                        Size = new Size(cellWidth, cellHeight),
                        Text = "0",
                        Tag = (i, j)
                    };

                    txt.TextChanged += (s, ev) => UpdateMatrixFromInputs(matrixName);
                    inputs[i, j] = txt;
                    panel.Controls.Add(txt);
                }
            }

            if (matrixName == 'A')
                matrixAInputs = inputs;
            else
                matrixBInputs = inputs;
        }

        private void UpdateMatrixFromInputs(char matrixName)
        {
            TextBox[,] inputs = matrixName == 'A' ? matrixAInputs : matrixBInputs;
            Matrix matrix = matrixName == 'A' ? matrixA : matrixB;

            if (inputs == null || matrix == null) return;

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (double.TryParse(inputs[i, j].Text, out double value))
                    {
                        matrix.Data[i, j] = value;
                    }
                }
            }
        }

        private void btnRandomA_Click(object sender, EventArgs e)
        {
            FillRandomMatrix('A');
        }

        private void btnRandomB_Click(object sender, EventArgs e)
        {
            FillRandomMatrix('B');
        }

        private void FillRandomMatrix(char matrixName)
        {
            try
            {
                int min = int.Parse(txtMin.Text);
                int max = int.Parse(txtMax.Text);

                Matrix matrix = matrixName == 'A' ? matrixA : matrixB;
                TextBox[,] inputs = matrixName == 'A' ? matrixAInputs : matrixBInputs;

                if (matrix == null || inputs == null)
                {
                    MessageBox.Show("Сначала создайте матрицы.");
                    return;
                }

                Random rand = new Random();
                for (int i = 0; i < matrix.Rows; i++)
                {
                    for (int j = 0; j < matrix.Cols; j++)
                    {
                        double value = rand.Next(min, max + 1);
                        matrix.Data[i, j] = value;
                        inputs[i, j].Text = value.ToString();
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные числовые значения для диапазона.");
            }
        }

        // Пункт 4: Сложение матриц
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddMatrices();
        }

        private void AddMatrices()
        {
            try
            {
                if (matrixA == null || matrixB == null)
                {
                    txtResult.Text = "Ошибка: Матрицы не созданы.";
                    return;
                }

                Matrix result = MatrixCalculator.Add(matrixA, matrixB);
                txtResult.Text = $"Результат сложения матриц A и B:\r\n{result}";
            }
            catch (ArgumentException ex)
            {
                txtResult.Text = $"Ошибка сложения: {ex.Message}";
            }
        }

        // Пункт 5: Умножение матриц
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            MultiplyMatrices();
        }

        private void MultiplyMatrices()
        {
            try
            {
                if (matrixA == null || matrixB == null)
                {
                    txtResult.Text = "Ошибка: Матрицы не созданы.";
                    return;
                }

                Matrix result = MatrixCalculator.Multiply(matrixA, matrixB);
                txtResult.Text = $"Результат умножения матриц A и B:\r\n{result}";
            }
            catch (ArgumentException ex)
            {
                txtResult.Text = $"Ошибка умножения: {ex.Message}";
            }
        }

        private void btnDeterminantA_Click(object sender, EventArgs e)
        {
            CalculateDeterminant('A');
        }

        private void btnDeterminantB_Click(object sender, EventArgs e)
        {
            CalculateDeterminant('B');
        }

        private void CalculateDeterminant(char matrixName)
        {
            try
            {
                Matrix matrix = matrixName == 'A' ? matrixA : matrixB;
                if (matrix == null)
                {
                    txtResult.Text = "Ошибка: Матрица не создана.";
                    return;
                }

                double determinant = MatrixCalculator.Determinant(matrix);
                txtResult.Text = $"Детерминант матрицы {matrixName}: {determinant:F2}";
            }
            catch (ArgumentException ex)
            {
                txtResult.Text = $"Ошибка вычисления детерминанта: {ex.Message}";
            }
        }

        private void btnInverseA_Click(object sender, EventArgs e)
        {
            CalculateInverse('A');
        }

        private void CalculateInverse(char matrixName)
        {
            try
            {
                Matrix matrix = matrixName == 'A' ? matrixA : matrixB;
                if (matrix == null)
                {
                    txtResult.Text = "Ошибка: Матрица не создана.";
                    return;
                }

                Matrix inverse = MatrixCalculator.Inverse(matrix);
                txtResult.Text = $"Обратная матрица {matrixName}:\r\n{inverse}";
            }
            catch (ArgumentException ex)
            {
                txtResult.Text = $"Ошибка вычисления обратной матрицы: {ex.Message}";
            }
        }

        private void btnTransposeA_Click(object sender, EventArgs e)
        {
            TransposeMatrix('A');
        }

        private void btnTransposeB_Click(object sender, EventArgs e)
        {
            TransposeMatrix('B');
        }

        private void TransposeMatrix(char matrixName)
        {
            try
            {
                Matrix matrix = matrixName == 'A' ? matrixA : matrixB;
                if (matrix == null)
                {
                    txtResult.Text = "Ошибка: Матрица не создана.";
                    return;
                }

                Matrix transposed = MatrixCalculator.Transpose(matrix);
                txtResult.Text = $"Транспонированная матрица {matrixName}:\r\n{transposed}";
            }
            catch (Exception ex)
            {
                txtResult.Text = $"Ошибка транспонирования: {ex.Message}";
            }
        }

        private void btnTestAll_Click(object sender, EventArgs e)
        {
            RunAllTests();
        }

        private void RunAllTests()
        {
            txtResult.Clear();
            txtResult.AppendText("=== ТЕСТИРОВАНИЕ ВСЕХ СЦЕНАРИЕВ ===\r\n\r\n");

            TestPositiveScenarios();
            txtResult.AppendText("\r\n");
            TestNegativeScenarios();
        }

        private void TestPositiveScenarios()
        {
            txtResult.AppendText("ПОЛОЖИТЕЛЬНЫЕ СЦЕНАРИИ:\r\n");

            // Тест 1: Успешное сложение
            Matrix testA1 = new Matrix(2, 2);
            testA1.Data[0, 0] = 1; testA1.Data[0, 1] = 2;
            testA1.Data[1, 0] = 3; testA1.Data[1, 1] = 4;

            Matrix testB1 = new Matrix(2, 2);
            testB1.Data[0, 0] = 5; testB1.Data[0, 1] = 6;
            testB1.Data[1, 0] = 7; testB1.Data[1, 1] = 8;

            try
            {
                Matrix result = MatrixCalculator.Add(testA1, testB1);
                txtResult.AppendText("✓ Сложение матриц 2x2: УСПЕХ\r\n");
            }
            catch (Exception ex)
            {
                txtResult.AppendText($"✗ Сложение матриц 2x2: ОШИБКА - {ex.Message}\r\n");
            }

            // Тест 2: Успешное умножение
            Matrix testA2 = new Matrix(2, 3);
            testA2.Data[0, 0] = 1; testA2.Data[0, 1] = 2; testA2.Data[0, 2] = 3;
            testA2.Data[1, 0] = 4; testA2.Data[1, 1] = 5; testA2.Data[1, 2] = 6;

            Matrix testB2 = new Matrix(3, 2);
            testB2.Data[0, 0] = 7; testB2.Data[0, 1] = 8;
            testB2.Data[1, 0] = 9; testB2.Data[1, 1] = 10;
            testB2.Data[2, 0] = 11; testB2.Data[2, 1] = 12;

            try
            {
                Matrix result = MatrixCalculator.Multiply(testA2, testB2);
                txtResult.AppendText("✓ Умножение матриц 2x3 и 3x2: УСПЕХ\r\n");
            }
            catch (Exception ex)
            {
                txtResult.AppendText($"✗ Умножение матриц: ОШИБКА - {ex.Message}\r\n");
            }

            // Тест 3: Детерминант квадратной матрицы
            Matrix testA3 = new Matrix(3, 3);
            testA3.Data[0, 0] = 1; testA3.Data[0, 1] = 2; testA3.Data[0, 2] = 3;
            testA3.Data[1, 0] = 0; testA3.Data[1, 1] = 4; testA3.Data[1, 2] = 5;
            testA3.Data[2, 0] = 1; testA3.Data[2, 1] = 0; testA3.Data[2, 2] = 6;

            try
            {
                double det = MatrixCalculator.Determinant(testA3);
                txtResult.AppendText($"✓ Детерминант 3x3: УСПЕХ ({det:F2})\r\n");
            }
            catch (Exception ex)
            {
                txtResult.AppendText($"✗ Детерминант 3x3: ОШИБКА - {ex.Message}\r\n");
            }
        }

        private void TestNegativeScenarios()
        {
            txtResult.AppendText("НЕГАТИВНЫЕ СЦЕНАРИИ:\r\n");

            // Тест 1: Невозможность сложения
            Matrix testA1 = new Matrix(2, 2);
            Matrix testB1 = new Matrix(3, 3);

            try
            {
                Matrix result = MatrixCalculator.Add(testA1, testB1);
                txtResult.AppendText("✗ Сложение разных размеров: ОШИБКА ПРОВЕРКИ\r\n");
            }
            catch (ArgumentException)
            {
                txtResult.AppendText("✓ Сложение разных размеров: корректная ошибка\r\n");
            }

            // Тест 2: Невозможность умножения
            Matrix testA2 = new Matrix(2, 3);
            Matrix testB2 = new Matrix(2, 3);

            try
            {
                Matrix result = MatrixCalculator.Multiply(testA2, testB2);
                txtResult.AppendText("✗ Умножение несовместимых матриц: ОШИБКА ПРОВЕРКИ\r\n");
            }
            catch (ArgumentException)
            {
                txtResult.AppendText("✓ Умножение несовместимых матриц: корректная ошибка\r\n");
            }

            // Тест 3: Детерминант не квадратной матрицы
            Matrix testA3 = new Matrix(2, 3);

            try
            {
                double det = MatrixCalculator.Determinant(testA3);
                txtResult.AppendText("✗ Детерминант не квадратной матрицы: ОШИБКА ПРОВЕРКИ\r\n");
            }
            catch (ArgumentException)
            {
                txtResult.AppendText("✓ Детерминант не квадратной матрицы: корректная ошибка\r\n");
            }

            // Тест 4: Обратная матрица с нулевым детерминантом
            Matrix testA4 = new Matrix(2, 2);
            testA4.Data[0, 0] = 1; testA4.Data[0, 1] = 2;
            testA4.Data[1, 0] = 2; testA4.Data[1, 1] = 4; // det = 0

            try
            {
                Matrix inverse = MatrixCalculator.Inverse(testA4);
                txtResult.AppendText("✗ Обратная матрица с det=0: ОШИБКА ПРОВЕРКИ\r\n");
            }
            catch (ArgumentException)
            {
                txtResult.AppendText("✓ Обратная матрица с det=0: корректная ошибка\r\n");
            }
        }
    }
}