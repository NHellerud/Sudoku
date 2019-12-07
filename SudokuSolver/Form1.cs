using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuSolver
{

    public partial class Form1 : Form
    {
        ComboBox[,] GridBoxes;
        string[,] Input;
        List<int[,]> solved;
        int index = 0;

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
        int[,] test5 = {
                {6, -1, -1, -1, -1, -1, 5, 3, -1},
                {-1, -1, -1, -1, -1, 2, 7, -1, -1},
                {5, -1, 7, -1, 9, 6, -1, 1, 8},
                {-1, -1, 6, -1, -1, 1, -1, 8, -1},
                {-1, 9, 8, -1, -1, -1, -1, -1, -1},
                {-1, -1, -1, -1, 2, -1, -1, -1, -1},
                {-1, -1, -1 ,-1, -1, -1, 9, -1, -1},
                {-1, -1, -1, 2, -1, -1, -1, 4, 3},
                {3, 1, -1, -1, -1, 9, -1, 6, 2} };


        public Form1()
        {
             
            InitializeComponent();
            setGrid(test4);
        }     


        public int CountGrid(int[,] A)
        {
            int count = 0;
            for (int i = 0; i < 9; i++)
                for (int k = 0; k < 9; k++)
                    if (A[i, k] != -1)
                        count++;
            return count;
        }
        
        //display values of param on the form
        public void setGrid(int[,] boxes)
        {
            box11.Text = boxes[0, 0].ToString();
            box12.Text = boxes[0, 1].ToString();
            box13.Text = boxes[0, 2].ToString();
            box14.Text = boxes[0, 3].ToString();
            box15.Text = boxes[0, 4].ToString();
            box16.Text = boxes[0, 5].ToString();
            box17.Text = boxes[0, 6].ToString();
            box18.Text = boxes[0, 7].ToString();
            box19.Text = boxes[0, 8].ToString();
            box21.Text = boxes[1, 0].ToString();
            box22.Text = boxes[1, 1].ToString();
            box23.Text = boxes[1, 2].ToString();
            box24.Text = boxes[1, 3].ToString();
            box25.Text = boxes[1, 4].ToString();
            box26.Text = boxes[1, 5].ToString();
            box27.Text = boxes[1, 6].ToString();
            box28.Text = boxes[1, 7].ToString();
            box29.Text = boxes[1, 8].ToString();
            box31.Text = boxes[2, 0].ToString();
            box32.Text = boxes[2, 1].ToString();
            box33.Text = boxes[2, 2].ToString();
            box34.Text = boxes[2, 3].ToString();
            box35.Text = boxes[2, 4].ToString();
            box36.Text = boxes[2, 5].ToString();
            box37.Text = boxes[2, 6].ToString();
            box38.Text = boxes[2, 7].ToString();
            box39.Text = boxes[2, 8].ToString();
            box41.Text = boxes[3, 0].ToString();
            box42.Text = boxes[3, 1].ToString();
            box43.Text = boxes[3, 2].ToString();
            box44.Text = boxes[3, 3].ToString();
            box45.Text = boxes[3, 4].ToString();
            box46.Text = boxes[3, 5].ToString();
            box47.Text = boxes[3, 6].ToString();
            box48.Text = boxes[3, 7].ToString();
            box49.Text = boxes[3, 8].ToString();
            box51.Text = boxes[4, 0].ToString();
            box52.Text = boxes[4, 1].ToString();
            box53.Text = boxes[4, 2].ToString();
            box54.Text = boxes[4, 3].ToString();
            box55.Text = boxes[4, 4].ToString();
            box56.Text = boxes[4, 5].ToString();
            box57.Text = boxes[4, 6].ToString();
            box58.Text = boxes[4, 7].ToString();
            box59.Text = boxes[4, 8].ToString();
            box61.Text = boxes[5, 0].ToString();
            box62.Text = boxes[5, 1].ToString();
            box63.Text = boxes[5, 2].ToString();
            box64.Text = boxes[5, 3].ToString();
            box65.Text = boxes[5, 4].ToString();
            box66.Text = boxes[5, 5].ToString();
            box67.Text = boxes[5, 6].ToString();
            box68.Text = boxes[5, 7].ToString();
            box69.Text = boxes[5, 8].ToString();
            box71.Text = boxes[6, 0].ToString();
            box72.Text = boxes[6, 1].ToString();
            box73.Text = boxes[6, 2].ToString();
            box74.Text = boxes[6, 3].ToString();
            box75.Text = boxes[6, 4].ToString();
            box76.Text = boxes[6, 5].ToString();
            box77.Text = boxes[6, 6].ToString();
            box78.Text = boxes[6, 7].ToString();
            box79.Text = boxes[6, 8].ToString();
            box81.Text = boxes[7, 0].ToString();
            box82.Text = boxes[7, 1].ToString();
            box83.Text = boxes[7, 2].ToString();
            box84.Text = boxes[7, 3].ToString();
            box85.Text = boxes[7, 4].ToString();
            box86.Text = boxes[7, 5].ToString();
            box87.Text = boxes[7, 6].ToString();
            box88.Text = boxes[7, 7].ToString();
            box89.Text = boxes[7, 8].ToString();
            box91.Text = boxes[8, 0].ToString();
            box92.Text = boxes[8, 1].ToString();
            box93.Text = boxes[8, 2].ToString();
            box94.Text = boxes[8, 3].ToString();
            box95.Text = boxes[8, 4].ToString();
            box96.Text = boxes[8, 5].ToString();
            box97.Text = boxes[8, 6].ToString();
            box98.Text = boxes[8, 7].ToString();
            box99.Text = boxes[8, 8].ToString();

        }

        public int[,] GetGrid()
        {
            int[,] A = new int[9,9];

            A[0, 0] = int.Parse(box11.Text);
            A[0, 1] = int.Parse(box12.Text);
            A[0, 2] = int.Parse(box13.Text);
            A[0, 3] = int.Parse(box14.Text);
            A[0, 4] = int.Parse(box15.Text);
            A[0, 5] = int.Parse(box16.Text);
            A[0, 6] = int.Parse(box17.Text);
            A[0, 7] = int.Parse(box18.Text);
            A[0, 8] = int.Parse(box19.Text);
            A[1, 0] = int.Parse(box21.Text);
            A[1, 1] = int.Parse(box22.Text);
            A[1, 2] = int.Parse(box23.Text);
            A[1, 3] = int.Parse(box24.Text);
            A[1, 4] = int.Parse(box25.Text);
            A[1, 5] = int.Parse(box26.Text);
            A[1, 6] = int.Parse(box27.Text);
            A[1, 7] = int.Parse(box28.Text);
            A[1, 8] = int.Parse(box29.Text);
            A[2, 0] = int.Parse(box31.Text);
            A[2, 1] = int.Parse(box32.Text);
            A[2, 2] = int.Parse(box33.Text);
            A[2, 3] = int.Parse(box34.Text);
            A[2, 4] = int.Parse(box35.Text);
            A[2, 5] = int.Parse(box36.Text);
            A[2, 6] = int.Parse(box37.Text);
            A[2, 7] = int.Parse(box38.Text);
            A[2, 8] = int.Parse(box39.Text);
            A[3, 0] = int.Parse(box41.Text);
            A[3, 1] = int.Parse(box42.Text);
            A[3, 2] = int.Parse(box43.Text);
            A[3, 3] = int.Parse(box44.Text);
            A[3, 4] = int.Parse(box45.Text);
            A[3, 5] = int.Parse(box46.Text);
            A[3, 6] = int.Parse(box47.Text);
            A[3, 7] = int.Parse(box48.Text);
            A[3, 8] = int.Parse(box49.Text);
            A[4, 0] = int.Parse(box51.Text);
            A[4, 1] = int.Parse(box52.Text);
            A[4, 2] = int.Parse(box53.Text);
            A[4, 3] = int.Parse(box54.Text);
            A[4, 4] = int.Parse(box55.Text);
            A[4, 5] = int.Parse(box56.Text);
            A[4, 6] = int.Parse(box57.Text);
            A[4, 7] = int.Parse(box58.Text);
            A[4, 8] = int.Parse(box59.Text);
            A[5, 0] = int.Parse(box61.Text);
            A[5, 1] = int.Parse(box62.Text);
            A[5, 2] = int.Parse(box63.Text);
            A[5, 3] = int.Parse(box64.Text);
            A[5, 4] = int.Parse(box65.Text);
            A[5, 5] = int.Parse(box66.Text);
            A[5, 6] = int.Parse(box67.Text);
            A[5, 7] = int.Parse(box68.Text);
            A[5, 8] = int.Parse(box69.Text);
            A[6, 0] = int.Parse(box71.Text);
            A[6, 1] = int.Parse(box72.Text);
            A[6, 2] = int.Parse(box73.Text);
            A[6, 3] = int.Parse(box74.Text);
            A[6, 4] = int.Parse(box75.Text);
            A[6, 5] = int.Parse(box76.Text);
            A[6, 6] = int.Parse(box77.Text);
            A[6, 7] = int.Parse(box78.Text);
            A[6, 8] = int.Parse(box79.Text);
            A[7, 0] = int.Parse(box81.Text);
            A[7, 1] = int.Parse(box82.Text);
            A[7, 2] = int.Parse(box83.Text);
            A[7, 3] = int.Parse(box84.Text);
            A[7, 4] = int.Parse(box85.Text);
            A[7, 5] = int.Parse(box86.Text);
            A[7, 6] = int.Parse(box87.Text);
            A[7, 7] = int.Parse(box88.Text);
            A[7, 8] = int.Parse(box89.Text);
            A[8, 0] = int.Parse(box91.Text);
            A[8, 1] = int.Parse(box92.Text);
            A[8, 2] = int.Parse(box93.Text);
            A[8, 3] = int.Parse(box94.Text);
            A[8, 4] = int.Parse(box95.Text);
            A[8, 5] = int.Parse(box96.Text);
            A[8, 6] = int.Parse(box97.Text);
            A[8, 7] = int.Parse(box98.Text);
            A[8, 8] = int.Parse(box99.Text);

            return A;
        }

        private void solveButton_Click(object sender, EventArgs e)
        {
            if (CountGrid(GetGrid()) < 10)
            {
                MessageBox.Show("Please fill in atleast 10 fields. The program would run with less but would take an extremely long time", "Too few inputs", MessageBoxButtons.OK);
                return;
            }
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Grid grid = new Grid(GetGrid(), parallelCheckBox.Checked);
            
            grid.Solve();

            setGrid(Grid.currentGrid);

            if (!Grid.IsValidGrid(Grid.currentGrid))
            {
                solved = grid.BruteForceSolve();
                if(solved.Count > 0)
                {
                    setGrid(solved[0]);
                    if(solved.Count > 1)
                        NextButton.Enabled = true;
                    index = 0;
                }
                
                CountLabel.Text = solved.Count.ToString();
               

            }
            else
            {
                CountLabel.Text = "1";
            }
            sw.Stop();
            timeLabel.Text = sw.Elapsed.ToString();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //initialize the grid array with the form boxes
            GridBoxes = new ComboBox[9, 9]{
                {box11, box12, box13, box14, box15, box16, box17, box18, box19},
                {box21, box22, box23, box24, box25, box26, box27, box28, box29},
                {box31, box32, box33, box34, box35, box36, box37, box38, box39},
                {box41, box42, box43, box44, box45, box46, box47, box48, box49},
                {box51, box52, box53, box54, box55, box56, box57, box58, box59},
                {box61, box62, box63, box64, box65, box66, box67, box68, box69},
                {box71, box72, box73, box74, box75, box76, box77, box78, box79},
                {box81, box82, box83, box84, box85, box86, box87, box88, box89},
                {box91, box92, box93, box94, box95, box96, box97, box98, box99} };
            Input = new string[9, 9]{
               {"11", "12", "13", "14", "15", "16", "17", "18", "19"},
                {"21", "22", "23", "24", "25", "26", "27", "28", "29"},
                {"31", "32", "33", "34", "35", "36", "37", "38", "39"},
                {"41", "42", "43", "44", "45", "46", "47", "48", "49"},
                {"51", "52", "53", "54", "55", "56", "57", "58", "59"},
                {"61", "62", "63", "64", "65", "66", "67", "68", "69"},
                {"71", "72", "73", "74", "75", "76", "77", "78", "79"},
                {"81", "82", "83", "84", "85", "86", "87", "88", "89"},
                {"91", "92", "93", "94", "95", "96", "97", "98", "99"}

            };
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            setGrid(testNul);
            NextButton.Enabled = false;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            setGrid(solved[++index % solved.Count]);
        }

        private void Preset1Button_Click(object sender, EventArgs e)
        {
            setGrid(test2);
        }

        private void Preset2Button_Click(object sender, EventArgs e)
        {
            setGrid(test3);
        }

        private void Preset3Button_Click(object sender, EventArgs e)
        {
            setGrid(test4);
        }

        private void Preset4Button_Click(object sender, EventArgs e)
        {
            setGrid(test5);
        }
    }
}
