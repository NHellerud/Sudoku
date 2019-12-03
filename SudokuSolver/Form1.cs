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
       
        public Form1()
        {
            ComboBox[,] Grid = new ComboBox[9,9]{
                {box11, box12, box13, box14, box15, box16, box17, box18, box19},
                {box21, box22, box23, box24, box25, box26, box27, box28, box29},
                {box31, box32, box33, box34, box35, box36, box37, box38, box39},
                {box41, box42, box43, box44, box45, box46, box47, box48, box49},
                {box51, box52, box53, box54, box55, box56, box57, box58, box59},
                {box61, box62, box63, box64, box65, box66, box67, box68, box69},
                {box71, box72, box73, box74, box75, box76, box77, box78, box79},
                {box81, box82, box83, box84, box85, box86, box87, box88, box89},
                {box91, box92, box93, box94, box95, box96, box97, box98, box99} };

           



            InitializeComponent();
        }

   
    }
}
