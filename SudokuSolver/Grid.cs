using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        static List<int[,]>[] poss = new List<int[,]>[9];



        public Grid(int[,] grid)
        {
            currentGrid = grid;
            newGrid = new int[9, 9];
            boxs = new Box[9, 9];

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

        public static void CopyGrid(int[,] A, int[,] B, int l)
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

        public List<int[,]> BruteForceSolve()
        {
            List<int[,]> firstStage = new List<int[,]>();
            List<int[,]> secondStage = new List<int[,]>();
            Thread[] threads = new Thread[3];

            threads[0] = new Thread(() => BruteForceRow(0));
            threads[1] = new Thread(() => BruteForceRow(3));
            threads[2] = new Thread(() => BruteForceRow(6));

            for (int i = 0; i < 3; i++)
            {
                threads[i].Start();
            }

            for (int i = 0; i < 3; i++)
            {
                threads[i].Join();
            }
            foreach (int[,] sec1 in poss[0])
                foreach (int[,] sec2 in poss[1])
                {
                    int[,] arr = MergeArrays(sec1, sec2);
                    if (IsValidGridNull(arr))
                    {
                        firstStage.Add(arr);
                    }
                }

            foreach (int[,] sec1 in firstStage)
                foreach (int[,] sec2 in poss[2])
                {
                    int[,] arr = MergeArrays(sec1, sec2);
                    if (IsValidGridNull(arr))
                    {
                        secondStage.Add(arr);
                    }
                }
            return secondStage;
        }


        public static void BruteForceRow(int r)
        {
            List<int[,]>[] sections = new List<int[,]>[3];
            List<int[,]> finishedProducts = new List<int[,]>();
            List<int[,]> possible = new List<int[,]>();

            for (int i = 0; i < 3; i++)
            {
                sections[i] = BruteForceSolveSection(r, i * 3);
            }

            foreach (int[,] section in sections[0])
            {
                foreach (int[,] otherSection in sections[1])
                {
                    int[,] arr = CombineArrays(section, r, 0, 3, 3, otherSection, r, 3, 3, 3);
                    if (IsValidGridNull(arr))
                    {

                        possible.Add(arr);
                    }
                }
            }

            foreach (int[,] section in possible)
            {
                foreach (int[,] otherSection in sections[2])
                {

                    int[,] arr = CombineArrays(section, 0, 0, 9, 9, otherSection, r, 6, 3, 3);
                    if (IsValidGridNull(arr))
                    {

                        finishedProducts.Add(arr);
                    }
                }
            }
            poss[r / 3] = finishedProducts;

        }

        public static int[,] MergeArrays(int[,] arr1, int[,] arr2)
        {
            int[,] sharedGrid = new int[9, 9];

            for (int i = 0; i < 9; i++)
                for (int k = 0; k < 9; k++)
                {
                    sharedGrid[i, k] = -1;
                }

            for (int i = 0; i < 9; i++)
                for (int k = 0; k < 9; k++)
                {
                    if (arr1[i, k] != -1)
                        sharedGrid[i, k] = arr1[i, k];
                }

            for (int i = 0; i < 9; i++)
                for (int k = 0; k < 9; k++)
                {
                    if (arr2[i, k] != -1)
                        sharedGrid[i, k] = arr2[i, k];
                }


            return sharedGrid;
        }

        public static int[,] CombineArrays(int[,] arr1, int row1, int col1, int h, int l, int[,] arr2, int row2, int col2, int h2, int l2)
        {
            int[,] sharedGrid = new int[9, 9];

            for (int i = 0; i < 9; i++)
                for (int k = 0; k < 9; k++)
                {
                    sharedGrid[i, k] = -1;
                }

            for (int i = 0; i < h; i++)
                for (int k = 0; k < l; k++)
                {
                    sharedGrid[i + row1, k + col1] = arr1[i, k];
                }

            for (int i = 0; i < h2; i++)
                for (int k = 0; k < l2; k++)
                {

                    sharedGrid[i + row2, k + col2] = arr2[i, k];
                }


            return sharedGrid;
        }

        public static List<int[,]> BruteForceSolveSection(int r, int c)
        {
            List<int[,]> possSolutions = new List<int[,]>();
            int[,] skeleton = new int[3, 3];
            int emptyCount = 0;
            List<List<int>> possibleValues = new List<List<int>>();
            List<int> loc = new List<int>();
            for (int i = 0; i < 9; i++)
            {
                int val = boxs[i / 3 + r, i % 3 + c].value;
                skeleton[i / 3, i % 3] = val;
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

            for (int i = 0; i < sums; i++)
            {
                int[,] testCase = new int[3, 3];
                CopyGrid(testCase, skeleton, 3);
                int sum = 1;
                for (int k = 0; k < emptyCount; k++)
                {
                    int x = possibleValues[k][(i / sum) % possibleValues[k].Count];
                    testCase[loc[k] / 3, loc[k] % 3] = x;
                    sum *= possibleValues[k].Count;
                }
                if (ValidateSection(testCase))
                {
                    possSolutions.Add(testCase);
                }
            }
            return possSolutions;
        }

        public static bool ValidateSection(int[,] A)
        {
            int[] values = new int[10];
            for (int i = 0; i < 9; i++)
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

            for (int i = 0; i < 9; i++)
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
                    if (boxs[i, k].value == -1 || seen[boxs[k, i].value - 1] == 1)
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
                        if (boxs[i, k].value == -1 || seen[boxs[k * 3 + n / 3, i * 3 + n % 3].value - 1] == 1)
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
                    if (A[i, k] == -1 || A[i, k] == 0)
                        continue;
                    if (seen[A[i, k] - 1] == 1)
                        return false;
                    seen[A[i, k] - 1] = 1;
                }
            }

            for (int i = 0; i < 9; i++)
            {
                int[] seen = new int[9];
                for (int k = 0; k < 9; k++)
                {
                    if (A[k, i] == -1 || A[k, i] == 0)
                        continue;
                    if (seen[A[k, i] - 1] == 1)
                        return false;
                    seen[A[k, i] - 1] = 1;
                }
            }

            for (int i = 0; i < 3; i++)
                for (int k = 0; k < 3; k++)
                {
                    int[] seen = new int[9];
                    for (int n = 0; n < 9; n++)
                    {
                        if (A[k * 3 + n / 3, i * 3 + n % 3] == -1 || A[k * 3 + n / 3, i * 3 + n % 3] == 0)
                            continue;
                        if (seen[A[k * 3 + n / 3, i * 3 + n % 3] - 1] == 1)
                            return false;
                        seen[A[k * 3 + n / 3, i * 3 + n % 3] - 1] = 1;
                    }
                }
            return true;
        }
    }



}
