using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Solution
    {
        private ArrayList results;
        public Solution()
        {
            results = new ArrayList();
        }
        
        public void sherlockAndSquares(int[] input)
        {
            int a = input[0];
            int b = input[1];
            int counter = 0;

            for (int i = (int)Math.Ceiling(Math.Sqrt(a)); i < (int)Math.Floor(Math.Sqrt(b))+1; i++)
            {
                counter++;
            }
            results.Add(counter);
        }

        public void printResult()
        {
            foreach (int n in results)
            {
                Console.WriteLine(n);
            }
        }

        static void Main()
        {
            Solution p = new Solution();
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                int[] input = Array.ConvertAll(a_temp, Int32.Parse);
                p.sherlockAndSquares(input);
            }
            p.printResult();
            Console.ReadKey();
        }
    }
}
