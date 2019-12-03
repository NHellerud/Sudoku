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
        ComboBox[,] Grid;
        string[,] Input;

        public Form1()
        {
             
            InitializeComponent();
        }     
        
        //display values of param on the form
        public void setGrid(string[,] boxes)
        {
            box11.Text = boxes[0, 0];
            box12.Text = boxes[0, 1];
            box13.Text = boxes[0, 2];
            box14.Text = boxes[0, 3];
            box15.Text = boxes[0, 4];
            box16.Text = boxes[0, 5];
            box17.Text = boxes[0, 6];
            box18.Text = boxes[0, 7];
            box19.Text = boxes[0, 8];
            box21.Text = boxes[1, 0];
            box22.Text = boxes[1, 1];
            box23.Text = boxes[1, 2];
            box24.Text = boxes[1, 3];
            box25.Text = boxes[1, 4];
            box26.Text = boxes[1, 5];
            box27.Text = boxes[1, 6];
            box28.Text = boxes[1, 7];
            box29.Text = boxes[1, 8];
            box31.Text = boxes[2, 0];
            box32.Text = boxes[2, 1];
            box33.Text = boxes[2, 2];
            box34.Text = boxes[2, 3];
            box35.Text = boxes[2, 4];
            box36.Text = boxes[2, 5];
            box37.Text = boxes[2, 6];
            box38.Text = boxes[2, 7];
            box39.Text = boxes[2, 8];
            box41.Text = boxes[3, 0];
            box42.Text = boxes[3, 1];
            box43.Text = boxes[3, 2];
            box44.Text = boxes[3, 3];
            box45.Text = boxes[3, 4];
            box46.Text = boxes[3, 5];
            box47.Text = boxes[3, 6];
            box48.Text = boxes[3, 7];
            box49.Text = boxes[3, 8];
            box51.Text = boxes[4, 0];
            box52.Text = boxes[4, 1];
            box53.Text = boxes[4, 2];
            box54.Text = boxes[4, 3];
            box55.Text = boxes[4, 4];
            box56.Text = boxes[4, 5];
            box57.Text = boxes[4, 6];
            box58.Text = boxes[4, 7];
            box59.Text = boxes[4, 8];
            box61.Text = boxes[5, 0];
            box62.Text = boxes[5, 1];
            box63.Text = boxes[5, 2];
            box64.Text = boxes[5, 3];
            box65.Text = boxes[5, 4];
            box66.Text = boxes[5, 5];
            box67.Text = boxes[5, 6];
            box68.Text = boxes[5, 7];
            box69.Text = boxes[5, 8];
            box71.Text = boxes[6, 0];
            box72.Text = boxes[6, 1];
            box73.Text = boxes[6, 2];
            box74.Text = boxes[6, 3];
            box75.Text = boxes[6, 4];
            box76.Text = boxes[6, 5];
            box77.Text = boxes[6, 6];
            box78.Text = boxes[6, 7];
            box79.Text = boxes[6, 8];
            box81.Text = boxes[7, 0];
            box82.Text = boxes[7, 1];
            box83.Text = boxes[7, 2];
            box84.Text = boxes[7, 3];
            box85.Text = boxes[7, 4];
            box86.Text = boxes[7, 5];
            box87.Text = boxes[7, 6];
            box88.Text = boxes[7, 7];
            box89.Text = boxes[7, 8];
            box91.Text = boxes[8, 0];
            box92.Text = boxes[8, 1];
            box93.Text = boxes[8, 2];
            box94.Text = boxes[8, 3];
            box95.Text = boxes[8, 4];
            box96.Text = boxes[8, 5];
            box97.Text = boxes[8, 6];
            box98.Text = boxes[8, 7];
            box99.Text = boxes[8, 8];

        }

        private void solveButton_Click(object sender, EventArgs e)
        {
            setGrid(Input);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //initialize the grid array with the form boxes
            Grid = new ComboBox[9, 9]{
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
    }
}
