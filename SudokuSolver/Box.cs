using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{

    class Box
    {
        public int[] possValues;
        public int value;
        int col;
        int row;
        int bRow;
        int bCol;


        public Box(int x, int r, int c)
        {
            value = x;
            if (x != -1)
                possValues = new int[9];
            else
                possValues = new int[9] { 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            row = r;
            col = c;
            bRow = (row / 3) * 3;
            bCol = (col / 3) * 3;
        }

        public void CheckValidBoxes()
        {
            if (value != -1)
                return;


            for (int i = 0; i < 9; i++)
            {
                int y = Grid.currentGrid[row, i];
                if (y != -1)
                    possValues[y - 1] = 0;
                y = Grid.currentGrid[i, col];
                if (y != -1)
                    possValues[y - 1] = 0;
                y = Grid.currentGrid[bRow + i / 3, bCol + i % 3];
                if (y != -1)
                    possValues[y - 1] = 0;
            }
        }

        public void OnePossVal()
        {
            if (value != -1)
                return;
            int x = -1;
            for (int i = 0; i < 9; i++)
            {
                if (possValues[i] == 1 && x != -1)
                    return;
                if (possValues[i] == 1)
                    x = i;
            }
            if (x == -1)
                return;
            value = x + 1;
            Grid.changed = true;
        }

        public bool ContainsPosValue(int x)
        {
            if (value != -1)
                return false;
            if (possValues[x] == 1)
                return true;
            return false;
        }

        public void RemovePosValue(int x)
        {
            possValues[x] = 0;
        }

        public void SetOnlyPosValues(int[] vals, int len)
        {
            possValues = new int[9];
            for (int i = 0; i < len; i++)
                possValues[vals[i]] = 1;
        }

        public void SetValue(int x)
        {
            value = x;
        }


        public static bool IsEqual(Box b1, Box b2)
        {
            for (int i = 0; i < 9; i++)
                if (b1.possValues[i] != b2.possValues[i])
                    return false;
            return true;
        }

        public List<int> ReturnList()
        {
            List<int> vals = new List<int>();
            for (int i = 0; i < 9; i++)
            {
                if (possValues[i] == 1)
                    vals.Add(i + 1);
            }
            return vals;
        }
    }
}