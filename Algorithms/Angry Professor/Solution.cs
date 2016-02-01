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

        public void angryProfessor(int n, int k, int[] a)
        {
            int onTime = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] <= 0)
                {
                    onTime++;
                }
            }
            if (onTime >= k)
            {
                results.Add("NO");
            }
            else
            {
                results.Add("YES");
            }
        }

        public void printResult()
        {
            foreach (string s in results)
            {
                Console.WriteLine(s);
            }
        }

        static void Main()
        {
            Solution p = new Solution();
            int t = Convert.ToInt32(Console.ReadLine());
            string[] tokens_n;
            int n = 0;
            int k = 0;
            string[] a_temp;
            int[] a = null;
            for (int a0 = 0; a0 < t; a0++)
            {
                tokens_n = Console.ReadLine().Split(' ');
                n = Convert.ToInt32(tokens_n[0]);
                k = Convert.ToInt32(tokens_n[1]);
                a_temp = Console.ReadLine().Split(' ');
                a = Array.ConvertAll(a_temp, Int32.Parse);
                p.angryProfessor(n, k, a);
            }
            p.printResult();
            Console.ReadKey();
        }
    }
}
