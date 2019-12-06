using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    class Grid
    {
        public static int[,] currentGrid;
        public static int[,] newGrid;
        private static Box[,] boxs;
        public const int GRID_SIZE = 81;
        public static int[] possGrids = new int[9];
        public static bool changed = true;

       

        public Grid(int[,] grid)
        {
            currentGrid = grid;
            newGrid = new int[9, 9];
            boxs = new Box[9,9];

            CreateBoxes();
            
        }

        private void CreateBoxes()
        {
            for (int i = 0; i < 9; i++)
                for (int k = 0; k < 9; k++)
                    boxs[i, k] = new Box(currentGrid[i, k], i, k);
            for (int i = 0; i < 9; i++)
                for (int k = 0; k < 9; k++)
                    boxs[i, k].CheckValidBoxes();


        }

        private void GatherBoxes()
        {
            for (int i = 0; i < 9; i++)
                for (int k = 0; k < 9; k++)
                    newGrid[i, k] = boxs[i, k].value;
        }

        public bool AnyChangesMade(int[,] A, int[,] B)
        {
            for (int i = 0; i < GRID_SIZE; i++)
                if (A[i / 9, i % 9] != B[i / 9, i % 9])
                    return false;
            return true;
        }

        public void Solve()
        {
            while (changed)
            { 
                changed = false;
                for (int i = 0; i < 3; i++)
                    for (int k = 0; k < 3; k++)
                        SolveSection(i * 3, k * 3);
                GatherBoxes();
            CopyGrid(currentGrid, newGrid, 9);
            }

           

      
        }

        public void CopyGrid(int[,] A, int[,] B, int l)
        {
            for (int i = 0; i < l; i++)
                for (int k = 0; k < l; k++)
                    A[i, k] = B[i, k];
        }

        public void SolveSection(int r, int c)
        {
            for (int i = 0; i < 3; i++)
                for (int k = 0; k < 3; k++)
                    boxs[i + r, k + c].CheckValidBoxes();
            
            
            //singles
            for (int i = 0; i < 3; i++)
                for (int k = 0; k < 3; k++)
                    boxs[i, k].OnePossVal();


            //hidden singles
            FindHiddenSingles(r, c);

           

        }

        public int BruteForceSolve()
        {
            return BruteForceSolveSection(6, 6);
        }

        public int BruteForceSolveSection(int r, int c)
        {
            List<int[,]> possSolutions = new List<int[,]>();
            int[,] skeleton = new int[3,3];
            int emptyCount = 0;
            List<List<int>> possibleValues = new List<List<int>>();
            List<int> loc = new List<int>();
            for(int i = 0; i < 9; i++)
            {
                int val = boxs[i / 3 + r, i % 3 + c].value;
                skeleton[i / 3,i % 3] = val;
                if (val == -1)
                {
                    emptyCount++;
                    possibleValues.Add(boxs[i / 3 + r, i % 3 + c].ReturnList());
                    loc.Add(i);
                }
            }
            
            int sums = 1;
            for (int i = 0; i < possibleValues.Count; i++)
                sums *= possibleValues[i].Count;
            
            for (int i = 0; i < sums;i++)
            {
                int[,] testCase = new int[3,3];
                CopyGrid(testCase, skeleton, 3);
                int sum = 1;
                for(int k = 0; k < emptyCount;k++)
                {
                    int x = possibleValues[k][(i / sum) % possibleValues[k].Count];
                    testCase[loc[k] / 3, loc[k] % 3 ] = x;
                    sum *= possibleValues[k].Count;
                }
                if(ValidateSection(testCase))
                {
                    possSolutions.Add(testCase);
                }
            }
            return possSolutions.Count;
        }

        public bool ValidateSection(int[,] A)
        {
            int[] values = new int[10];
            for(int i = 0; i < 9;i++)
            {
                if (values[A[i / 3, i % 3]] == 1)
                    return false;
                values[A[i / 3, i % 3]] = 1;
            }
            return true;
        }

        private void FindHiddenSingles(int r, int c)
        {
            for (int i = 0; i < 9; i++)
            {
                int x = -1;
                int y = -1;
                for (int n = 0; n < 3; n++)
                    for (int k = 0; k < 3; k++)
                    {
                        if (boxs[r + n, c + k].ContainsPosValue(i))
                        {
                            if (x == -1)
                            {
                                x = n;
                                y = k;
                            }
                            else
                            {
                                x = -2;
                                y = -2;
                            }
                        }
                    }

                if (x > -1)
                {
                    boxs[r + x, c + y].SetValue(i + 1);
                    changed = true;
                    return;
                }

            }
        }

        private void FindHiddenRow(int r, int c)
        {
            for (int i = 0; i < 9; i++)
            {
                int x = -1;
                int y = -1;
                for (int n = 0; n < 3; n++)
                    for (int k = 0; k < 3; k++)
                    {
                        if (boxs[r + n, c + k].ContainsPosValue(i))
                        {
                            if (x == -1)
                            {
                                x = n;
                                y = k;
                            }
                            else
                            {
                                x = -2;
                                y = -2;
                            }
                        }
                    }

                if (x > -1)
                {
                    boxs[r + x, c + y].SetValue(i + 1);
                    return;
                }

            }
        }


        public static string GetBoxPoss(int r, int c)
        {
            string s = "";
            for (int i = 0; i < 9; i++)
                s += boxs[r, c].possValues[i].ToString();
            return s;
        }
      

        public static bool IsValidGrid(int[,] A)
        {
            
            for(int i = 0; i < 9; i++)
            {
                int[] seen = new int[9];
                for (int k = 0; k < 9; k++)
                {
                    if (boxs[i, k].value == -1 || seen[boxs[i, k].value - 1] == 1)
                        return false;
                    seen[boxs[i, k].value - 1] = 1;
                }
            }

            for (int i = 0; i < 9; i++)
            {
                int[] seen = new int[9];
                for (int k = 0; k < 9; k++)
                {
                    if (boxs[i, k].value == -1 || seen[boxs[k,i].value - 1] == 1)
                        return false;
                    seen[boxs[k, i].value - 1] = 1;
                }
            }

            for (int i = 0; i < 3; i++)
                for (int k = 0; k < 3; k++)
                {
                    int[] seen = new int[9];
                    for (int n = 0; n < 9; n++)
                    {
                        if (boxs[i, k].value == -1 || seen[boxs[k * 3 + n /3,  i * 3 + n % 3].value - 1] == 1)
                            return false;
                        seen[boxs[k * 3 + n / 3, i * 3 + n % 3].value - 1] = 1;
                    }
                }
            return true;
        }
        public static bool IsValidGridNull(int[,] A)
        {

            for (int i = 0; i < 9; i++)
            {
                int[] seen = new int[9];
                for (int k = 0; k < 9; k++)
                {
                    if (boxs[i, k].value == -1)
                        continue;
                    if (seen[boxs[i, k].value - 1] == 1)
                        return false;
                    seen[boxs[i, k].value - 1] = 1;
                }
            }

            for (int i = 0; i < 9; i++)
            {
                int[] seen = new int[9];
                for (int k = 0; k < 9; k++)
                {
                    if (boxs[k, i].value == -1)
                        continue;
                    if (seen[boxs[k, i].value - 1] == 1)
                        return false;
                    seen[boxs[k, i].value - 1] = 1;
                }
            }

            for (int i = 0; i < 3; i++)
                for (int k = 0; k < 3; k++)
                {
                    int[] seen = new int[9];
                    for (int n = 0; n < 9; n++)
                    {
                        if (boxs[k * 3 + n / 3, i * 3 + n % 3].value == -1)
                            continue;
                        if ( seen[boxs[k * 3 + n / 3, i * 3 + n % 3].value - 1] == 1)
                            return false;
                        seen[boxs[k * 3 + n / 3, i * 3 + n % 3].value - 1] = 1;
                    }
                }
            return true;
        }
    }

    

}

