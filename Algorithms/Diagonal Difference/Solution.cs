using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Solution
    {
        private int[][] grid;
        private int n;
        public Solution(int[][] grid, int n)
        {
            this.grid = grid;
            this.n = n;
        }

        public void diagonalDifference()
        {
            int diagonal1Sum = 0;
            int diagonal2Sum = 0;
            for (int i = 0; i < n; i++)
            {
                diagonal1Sum += grid[i][i];
            }
            int j = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                diagonal2Sum += grid[j][i];
                j++;
            }
            Console.WriteLine((Math.Abs(diagonal1Sum - diagonal2Sum)));
        }

        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] grid = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                grid[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }
            Solution s = new Solution(grid, n);
            s.diagonalDifference();
            Console.ReadKey();
        }
    }
}