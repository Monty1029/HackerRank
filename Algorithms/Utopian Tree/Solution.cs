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

        public void utopianTree(int n)
        {
            int height = 1;
            if (n == 1)
            {
                height = 2;
            }
            else if (n > 1)
            {
                for (int i = 1; i < n + 1; i++)
                {
                    if (i % 2 == 0)
                    {
                        height++;
                    }
                    else
                    {
                        height *= 2;
                    }

                }
            }
            results.Add(height);
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
                int n = Convert.ToInt32(Console.ReadLine());
                p.utopianTree(n);
            }
            p.printResult();
            Console.ReadKey();
        }
    }
}
