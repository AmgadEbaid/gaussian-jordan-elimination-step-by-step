using Accord.Math;

namespace linear_equation_gui
{
    public partial class Form1 : Form
    {
        static int M = 10;
        static int count = 0;

        // Function to print the matrix
        static void PrintMatrix(float[,] a, int n,RichTextBox bord)
        {
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= n; j++)
                    if (j==n)
                    bord.AppendText(" |"+a[i, j] + "      ");
                 else
                bord.AppendText(a[i, j] + "      ");
                bord.AppendText("\n");
            }

        }

        // function to reduce matrix to reduced
        // row echelon form.
        static int PerformOperation(float[,] a, int n, RichTextBox bord)
        {


            count++;
            int i, j, k = 0, c, flag = 0;

            // Performing elementary operations
            for (i = 0; i < n; i++)
            {
                bord.AppendText("\n");

                bord.AppendText("=======" + "step:" + count + "=======");
                bord.AppendText("\n");



                if (a[i, i] == 0)
                {

                    c = 1;
                    while ((i + c) < n && a[i + c, i] == 0)
                        c++;
                    bord.AppendText("\n");

                    bord.AppendText("swaping row: " + (i+1) + " with row: " + ((i+1) + c) + " in the matrix");

                    

                    bord.AppendText("\n");

                    if ((i + c) == n)
                    {
                        flag = 1;
                        break;
                    }
                    for (j = i, k = 0; k <= n; k++)
                    {
                        float temp = a[j, k];
                        a[j, k] = a[j + c, k];
                        a[j + c, k] = temp;
                    }


                    PrintMatrix(a, n, bord);



                }

                for (j = 0; j < n; j++)
                {


                    // Excluding all i == j
                    if (i != j)
                    {

                        // Converting Matrix to reduced row
                        // echelon form(diagonal matrix)
                        float p = a[j, i] / a[i, i];
                        bord.AppendText("\n");

                        bord.AppendText(-p + "R" + (i+1) + " + " + "R" + (j+1) + " ---> " + "R" + (j+1));
                        bord.AppendText("\n");

                        for (k = 0; k <= n; k++)
                            a[j, k] = a[j, k] - (a[i, k]) * p;

                    }

                }
                bord.AppendText("\n");

             


                PrintMatrix(a, n,bord);


                bord.AppendText("\n");
                bord.AppendText("\n");







                count++;
            }

            return flag;

        }
        static void getleading(int row, float[,] linear)
        {
            if (linear[row, row] != 1)
            {

                float factor = linear[row, row];

                for (int x = 0; x < linear.GetLength(0) + 1; x++)
                {

                    if (linear.GetLength(0) == linear.GetLength(1))
                    {
                        if (linear[row, x] == linear.GetLength(1) - 1)
                            break;
                    }

                    if (linear[row, x] == 0)
                    {

                        continue;
                    }
                    linear[row, x] = linear[row, x] / factor;


                }
            }
        }

        // Function to print the desired result
        // if unique solutions exists, otherwise
        // prints no solution or infinite solutions
        // depending upon the input given.
        static void PrintResult(float[,] a,
                                int n, int flag, RichTextBox bord)
        {

            bord.AppendText("Result is : ");

            if (flag == 2)
                bord.AppendText("Infinite Solutions Exists");
            else if (flag == 3)
                bord.AppendText("No Solution Exists");

            // Printing the solution by dividing
            // constants by their respective
            // diagonal elements
            else
            {


                for (int i = 0; i < n; i++)
                    bord.AppendText(a[i, n] / a[i, i] + " ");



            }
        }

        // To check whether infinite solutions
        // exists or no solution exists
        static int CheckConsistency(float[,] a,
                                    int n, int flag)
        {
            int i, j;
            float sum;

            // flag == 2 for infinite solution
            // flag == 3 for No solution
            flag = 3;
            for (i = 0; i < n; i++)
            {
                sum = 0;
                for (j = 0; j < n; j++)
                    sum = sum + a[i, j];
                if (sum == a[i, j])
                    flag = 2;
            }
            return flag;
        }

        public static float[,] matrixOf(DataGridView grid1)
        {
            float[,] mat = new float [grid1.RowCount,grid1.ColumnCount];
            for (int i = 0; i < grid1.RowCount; i++)
            {
                for (int x = 0; x < grid1.ColumnCount; x++)
                {

                    mat[i, x] = Convert.ToSingle(grid1.Rows[i].Cells[x].Value);


                }
            }
            return mat;
        }
 
  
        public static void __demo__(DataGridView mat,RichTextBox solveAt)
        {
            mat.RowCount = 3;
            mat.ColumnCount = 3;
            
            
            
            mat.Rows[0].Cells[0].Value = 33;
            mat.Rows[1].Cells[0].Value = 2;
            mat.Rows[2].Cells[0].Value = 4;

            mat.Rows[0].Cells[1].Value = 1;
            mat.Rows[1].Cells[1].Value = -3;
            mat.Rows[2].Cells[1].Value = -5;

            mat.Rows[0].Cells[2].Value = 1;
            mat.Rows[1].Cells[2].Value = -1;
            mat.Rows[2].Cells[2].Value = -1;
           


        
        }

        public static void solveMAt(DataGridView matrix , RichTextBox solveAt)
        {
            float[,] _matrix = matrixOf(matrix);
            // Order of Matrix(n)
            int n = _matrix.GetLength(0), flag = 0;
            PrintMatrix(_matrix, n,solveAt);



            // Performing Matrix transformation
            flag = PerformOperation(_matrix, n,solveAt);

            if (flag == 1)
                flag = CheckConsistency(_matrix, n, flag);



            // Printing Solutions(if exist)
            PrintResult(_matrix, n, flag,solveAt);
            //bool isSingular = Matrix.IsSingular(getMatrix_double(matrix));
            /*if (isSingular)
            {
                solveAt.AppendText(isSingular.ToString());
            }
            else
            {
                //Decimal[,] x = Matrix.Solve(_matrix, _rightSide, leastSquares: isSingular);

                //print(x, solveAt);

            }*/

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount= Convert.ToInt16(rowCount.Value);
            dataGridView1.ColumnCount= Convert.ToInt16( colCount.Value);
           


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = Decimal.ToInt32(rowCount.Value);
            int col = Decimal.ToInt32(colCount.Value);
            int[,] mat = new int[row,col];
           
            



        }

        private void solve_Click(object sender, EventArgs e)
        {
            solveMAt(dataGridView1, richTextBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            __demo__(dataGridView1,richTextBox1);
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        static private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void colCount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

  
}