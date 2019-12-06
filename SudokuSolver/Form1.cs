using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuSolver
{
    public partial class Form1 : Form
    {

        Grid grid;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[,] test = { 
                {-1,2,3,4,5,6,7,8,9},
                {7,8,9,1,2,3,4,5,6},
                {4,5,6,7,8,9,1,2,3}, 
                {3,1,2,8,4,5,9,6,7},
                {6,9,7,3,1,2,8,4,5},
                {8,4,5,6,9,7,3,1,2},
                {2,3,1,5,7,4,6,9,8},
                {9,6,8,2,3,1,5,7,4},
                {5,7,4,9,6,8,2,3,1} };

            int[,] testNul = {
                {-1, -1, -1, -1, -1, -1, -1, -1, -1},
                {-1, -1, -1, -1, -1, -1, -1, -1, -1},
                {-1, -1, -1, -1, -1, -1, -1, -1, -1},
                {-1, -1, -1, -1, -1, -1, -1, -1, -1},
                {-1, -1, -1, -1, -1, -1, -1, -1, -1},
                {-1, -1, -1, -1, -1, -1, -1, -1, -1},
                {-1, -1, -1, -1, -1, -1, -1, -1, -1},
                {-1, -1, -1, -1, -1, -1, -1, -1, -1},
                {-1, -1, -1, -1, -1, -1, -1, -1, -1},
            };

            int[,] test2 = {
                {-1,-1,-1,-1,-1,3,6,-1,-1},
                {-1,-1,-1,-1,2,-1,-1,-1,-1},
                {-1,3,9,8,-1,-1,-1,-1,1},
                {9,-1,-1,-1,4,-1,-1,-1,3},
                {3,4,-1,6,-1,2,-1,8,-1},
                {-1,6,-1,-1,1,-1,9,-1,-1},
                {-1,8,-1,-1,-1,-1,2,-1,-1},
                {-1,5,6,1,3,-1,4,-1,-1},
                {4,-1,-1,-1,8,7,-1,-1,-1} };

            int[,] test3 = {
                {-1, 5, 3, -1, -1, -1, 7, 9, -1},
                {-1, -1, 9, 7, 8, 2, 6, -1, -1},
                {-1, -1, -1, 5, -1, 3, -1, -1, -1},
                {-1, -1, -1, 4, -1, 6, -1, -1, -1},
                {-1, 4, -1, -1, -1, -1, -1, 6, -1},
                {8, -1, 5, 1, -1, 9, 3, -1, 2},
                {-1, -1, 8, 9, 3, 1, 4, -1, -1},
                {9, -1, -1, -1, -1, -1, -1, -1, 6},
                {-1, -1, 4, -1, -1, -1, 8, -1, -1} };

            int[,] test4 = {
                {-1, -1, -1, 5, 4, -1, -1, -1, 8},
                {6, -1, -1, -1, -1, 2, 3, -1, -1},
                {-1, -1, 7, -1, -1, 3, -1, 9, -1},
                {-1, 3, 1, -1, 5, -1, -1, 2, -1},
                {-1, -1, -1, -1, -1, -1, -1, -1, -1},
                {-1, 4, -1, -1, 3, -1, 7, 1, -1},
                {-1, 9, -1, 7, -1, -1, 2, -1, -1},
                {-1, -1, 8, 6, -1, -1, -1, -1,5},
                {1, -1, -1, -1, 2, 4, -1, -1, -1} };


            grid = new Grid(test4);
            PrintLabel(Grid.currentGrid);
            textBox2.Text = Grid.IsValidGridNull(Grid.currentGrid).ToString();
            
            
        }

        public void PrintLabel(int[,] A)
        {
            testLabel.Text = "";
            for (int i = 0; i < 9; i++)
            {
                for (int k = 0; k < 9; k++)
                {
                    if (A[i, k] < 10 && A[i,k] > 0)
                        testLabel.Text += " ";
                    testLabel.Text += A[i, k].ToString() + " ";
                    
                }
                testLabel.Text += "\n";
            }
        }

        public void PrintPoss(int r, int c)
        {
            testLabel2.Text = Grid.GetBoxPoss(r, c);

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            grid.Solve();
            PrintLabel(Grid.currentGrid);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            testLabel2.Text = grid.BruteForceSolve().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            testLabel2.Text = Grid.GetBoxPoss(int.Parse(textBox1.Text),int.Parse(textBox2.Text));
        }
    }
}
