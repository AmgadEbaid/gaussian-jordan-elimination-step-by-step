namespace linear_equation_gui
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.matRow = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.solve = new System.Windows.Forms.Button();
            this.rowCount = new System.Windows.Forms.NumericUpDown();
            this.colCount = new System.Windows.Forms.NumericUpDown();
            this.mat = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colCount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(49, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "enter the matrix";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(528, 256);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // matRow
            // 
            this.matRow.AutoSize = true;
            this.matRow.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.matRow.Location = new System.Drawing.Point(49, 27);
            this.matRow.Name = "matRow";
            this.matRow.Size = new System.Drawing.Size(149, 38);
            this.matRow.TabIndex = 2;
            this.matRow.Tag = "";
            this.matRow.Text = "matrix size";
            this.matRow.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "x";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // solve
            // 
            this.solve.Location = new System.Drawing.Point(49, 484);
            this.solve.Name = "solve";
            this.solve.Size = new System.Drawing.Size(108, 35);
            this.solve.TabIndex = 4;
            this.solve.Text = "solve";
            this.solve.UseVisualStyleBackColor = true;
            this.solve.Click += new System.EventHandler(this.solve_Click);
            // 
            // rowCount
            // 
            this.rowCount.Location = new System.Drawing.Point(57, 78);
            this.rowCount.Name = "rowCount";
            this.rowCount.Size = new System.Drawing.Size(49, 27);
            this.rowCount.TabIndex = 6;
            this.rowCount.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // colCount
            // 
            this.colCount.Location = new System.Drawing.Point(134, 78);
            this.colCount.Name = "colCount";
            this.colCount.Size = new System.Drawing.Size(47, 27);
            this.colCount.TabIndex = 7;
            this.colCount.ValueChanged += new System.EventHandler(this.colCount_ValueChanged);
            // 
            // mat
            // 
            this.mat.AutoSize = true;
            this.mat.Location = new System.Drawing.Point(49, 179);
            this.mat.Name = "mat";
            this.mat.Size = new System.Drawing.Size(51, 20);
            this.mat.TabIndex = 10;
            this.mat.Text = "Matrix";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(628, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 513);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "results";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 26);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(414, 481);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 537);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mat);
            this.Controls.Add(this.colCount);
            this.Controls.Add(this.rowCount);
            this.Controls.Add(this.solve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.matRow);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colCount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Label matRow;
        private Label label2;
        private Button solve;
        private NumericUpDown rowCount;
        private NumericUpDown colCount;
        private Label mat;
        private GroupBox groupBox1;
        private RichTextBox richTextBox1;
    }
}