namespace MatrixCalculator
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblRows = new System.Windows.Forms.Label();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.lblCols = new System.Windows.Forms.Label();
            this.txtCols = new System.Windows.Forms.TextBox();
            this.btnCreateMatrices = new System.Windows.Forms.Button();
            this.lblMin = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.lblMax = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.btnRandomA = new System.Windows.Forms.Button();
            this.btnRandomB = new System.Windows.Forms.Button();
            this.panelMatrixA = new System.Windows.Forms.Panel();
            this.panelMatrixB = new System.Windows.Forms.Panel();
            this.lblMatrixA = new System.Windows.Forms.Label();
            this.lblMatrixB = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDeterminantA = new System.Windows.Forms.Button();
            this.btnDeterminantB = new System.Windows.Forms.Button();
            this.btnInverseA = new System.Windows.Forms.Button();
            this.btnTransposeA = new System.Windows.Forms.Button();
            this.btnTransposeB = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnTestAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(12, 15);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(72, 13);
            this.lblRows.TabIndex = 0;
            this.lblRows.Text = "Строки (n):";
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(90, 12);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(50, 20);
            this.txtRows.TabIndex = 1;
            this.txtRows.Text = "3";
            // 
            // lblCols
            // 
            this.lblCols.AutoSize = true;
            this.lblCols.Location = new System.Drawing.Point(146, 15);
            this.lblCols.Name = "lblCols";
            this.lblCols.Size = new System.Drawing.Size(83, 13);
            this.lblCols.TabIndex = 2;
            this.lblCols.Text = "Столбцы (m):";
            // 
            // txtCols
            // 
            this.txtCols.Location = new System.Drawing.Point(235, 12);
            this.txtCols.Name = "txtCols";
            this.txtCols.Size = new System.Drawing.Size(50, 20);
            this.txtCols.TabIndex = 3;
            this.txtCols.Text = "3";
            // 
            // btnCreateMatrices
            // 
            this.btnCreateMatrices.Location = new System.Drawing.Point(291, 10);
            this.btnCreateMatrices.Name = "btnCreateMatrices";
            this.btnCreateMatrices.Size = new System.Drawing.Size(100, 23);
            this.btnCreateMatrices.TabIndex = 4;
            this.btnCreateMatrices.Text = "Создать матрицы";
            this.btnCreateMatrices.UseVisualStyleBackColor = true;
            this.btnCreateMatrices.Click += new System.EventHandler(this.btnCreateMatrices_Click);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(397, 15);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(30, 13);
            this.lblMin.TabIndex = 5;
            this.lblMin.Text = "Min:";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(433, 12);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(50, 20);
            this.txtMin.TabIndex = 6;
            this.txtMin.Text = "0";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(489, 15);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(33, 13);
            this.lblMax.TabIndex = 7;
            this.lblMax.Text = "Max:";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(528, 12);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(50, 20);
            this.txtMax.TabIndex = 8;
            this.txtMax.Text = "10";
            // 
            // btnRandomA
            // 
            this.btnRandomA.Location = new System.Drawing.Point(584, 10);
            this.btnRandomA.Name = "btnRandomA";
            this.btnRandomA.Size = new System.Drawing.Size(80, 23);
            this.btnRandomA.TabIndex = 9;
            this.btnRandomA.Text = "Случайно A";
            this.btnRandomA.UseVisualStyleBackColor = true;
            this.btnRandomA.Click += new System.EventHandler(this.btnRandomA_Click);
            // 
            // btnRandomB
            // 
            this.btnRandomB.Location = new System.Drawing.Point(670, 10);
            this.btnRandomB.Name = "btnRandomB";
            this.btnRandomB.Size = new System.Drawing.Size(80, 23);
            this.btnRandomB.TabIndex = 10;
            this.btnRandomB.Text = "Случайно B";
            this.btnRandomB.UseVisualStyleBackColor = true;
            this.btnRandomB.Click += new System.EventHandler(this.btnRandomB_Click);
            // 
            // panelMatrixA
            // 
            this.panelMatrixA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMatrixA.Location = new System.Drawing.Point(12, 42);
            this.panelMatrixA.Name = "panelMatrixA";
            this.panelMatrixA.Size = new System.Drawing.Size(350, 200);
            this.panelMatrixA.TabIndex = 11;
            // 
            // panelMatrixB
            // 
            this.panelMatrixB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMatrixB.Location = new System.Drawing.Point(372, 42);
            this.panelMatrixB.Name = "panelMatrixB";
            this.panelMatrixB.Size = new System.Drawing.Size(350, 200);
            this.panelMatrixB.TabIndex = 12;
            // 
            // lblMatrixA
            // 
            this.lblMatrixA.AutoSize = true;
            this.lblMatrixA.Location = new System.Drawing.Point(12, 245);
            this.lblMatrixA.Name = "lblMatrixA";
            this.lblMatrixA.Size = new System.Drawing.Size(59, 13);
            this.lblMatrixA.TabIndex = 13;
            this.lblMatrixA.Text = "Матрица A";
            // 
            // lblMatrixB
            // 
            this.lblMatrixB.AutoSize = true;
            this.lblMatrixB.Location = new System.Drawing.Point(369, 245);
            this.lblMatrixB.Name = "lblMatrixB";
            this.lblMatrixB.Size = new System.Drawing.Size(59, 13);
            this.lblMatrixB.TabIndex = 14;
            this.lblMatrixB.Text = "Матрица B";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 265);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 30);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Сложение (A+B)";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(138, 265);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(120, 30);
            this.btnMultiply.TabIndex = 16;
            this.btnMultiply.Text = "Умножение (A×B)";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDeterminantA
            // 
            this.btnDeterminantA.Location = new System.Drawing.Point(264, 265);
            this.btnDeterminantA.Name = "btnDeterminantA";
            this.btnDeterminantA.Size = new System.Drawing.Size(120, 30);
            this.btnDeterminantA.TabIndex = 17;
            this.btnDeterminantA.Text = "Детерминант A";
            this.btnDeterminantA.UseVisualStyleBackColor = true;
            this.btnDeterminantA.Click += new System.EventHandler(this.btnDeterminantA_Click);
            // 
            // btnDeterminantB
            // 
            this.btnDeterminantB.Location = new System.Drawing.Point(390, 265);
            this.btnDeterminantB.Name = "btnDeterminantB";
            this.btnDeterminantB.Size = new System.Drawing.Size(120, 30);
            this.btnDeterminantB.TabIndex = 18;
            this.btnDeterminantB.Text = "Детерминант B";
            this.btnDeterminantB.UseVisualStyleBackColor = true;
            this.btnDeterminantB.Click += new System.EventHandler(this.btnDeterminantB_Click);
            // 
            // btnInverseA
            // 
            this.btnInverseA.Location = new System.Drawing.Point(516, 265);
            this.btnInverseA.Name = "btnInverseA";
            this.btnInverseA.Size = new System.Drawing.Size(120, 30);
            this.btnInverseA.TabIndex = 19;
            this.btnInverseA.Text = "Обратная A";
            this.btnInverseA.UseVisualStyleBackColor = true;
            this.btnInverseA.Click += new System.EventHandler(this.btnInverseA_Click);
            // 
            // btnTransposeA
            // 
            this.btnTransposeA.Location = new System.Drawing.Point(12, 301);
            this.btnTransposeA.Name = "btnTransposeA";
            this.btnTransposeA.Size = new System.Drawing.Size(120, 30);
            this.btnTransposeA.TabIndex = 20;
            this.btnTransposeA.Text = "Транспонировать A";
            this.btnTransposeA.UseVisualStyleBackColor = true;
            this.btnTransposeA.Click += new System.EventHandler(this.btnTransposeA_Click);
            // 
            // btnTransposeB
            // 
            this.btnTransposeB.Location = new System.Drawing.Point(138, 301);
            this.btnTransposeB.Name = "btnTransposeB";
            this.btnTransposeB.Size = new System.Drawing.Size(120, 30);
            this.btnTransposeB.TabIndex = 21;
            this.btnTransposeB.Text = "Транспонировать B";
            this.btnTransposeB.UseVisualStyleBackColor = true;
            this.btnTransposeB.Click += new System.EventHandler(this.btnTransposeB_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 337);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(760, 150);
            this.txtResult.TabIndex = 22;
            // 
            // btnTestAll
            // 
            this.btnTestAll.Location = new System.Drawing.Point(300, 493);
            this.btnTestAll.Name = "btnTestAll";
            this.btnTestAll.Size = new System.Drawing.Size(200, 30);
            this.btnTestAll.TabIndex = 23;
            this.btnTestAll.Text = "Тестирование всех сценариев";
            this.btnTestAll.UseVisualStyleBackColor = true;
            this.btnTestAll.Click += new System.EventHandler(this.btnTestAll_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 535);
            this.Controls.Add(this.btnTestAll);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnTransposeB);
            this.Controls.Add(this.btnTransposeA);
            this.Controls.Add(this.btnInverseA);
            this.Controls.Add(this.btnDeterminantB);
            this.Controls.Add(this.btnDeterminantA);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblMatrixB);
            this.Controls.Add(this.lblMatrixA);
            this.Controls.Add(this.panelMatrixB);
            this.Controls.Add(this.panelMatrixA);
            this.Controls.Add(this.btnRandomB);
            this.Controls.Add(this.btnRandomA);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.btnCreateMatrices);
            this.Controls.Add(this.txtCols);
            this.Controls.Add(this.lblCols);
            this.Controls.Add(this.txtRows);
            this.Controls.Add(this.lblRows);
            this.Text = "Калькулятор матриц";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.Label lblCols;
        private System.Windows.Forms.TextBox txtCols;
        private System.Windows.Forms.Button btnCreateMatrices;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Button btnRandomA;
        private System.Windows.Forms.Button btnRandomB;
        private System.Windows.Forms.Panel panelMatrixA;
        private System.Windows.Forms.Panel panelMatrixB;
        private System.Windows.Forms.Label lblMatrixA;
        private System.Windows.Forms.Label lblMatrixB;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDeterminantA;
        private System.Windows.Forms.Button btnDeterminantB;
        private System.Windows.Forms.Button btnInverseA;
        private System.Windows.Forms.Button btnTransposeA;
        private System.Windows.Forms.Button btnTransposeB;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnTestAll;
    }
}