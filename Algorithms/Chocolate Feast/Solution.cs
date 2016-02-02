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

        public void chocolateFeast(int money, int price, int wrappers)
        {
            int chocolates = 0;
            while (money > -1)
            {
                money -= price;
                if (money >= 0)
                {
                    chocolates++;
                }

                if (chocolates >= wrappers && chocolates % wrappers == 0)
                {
                    chocolates++;
                }
            }
            results.Add(chocolates);
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
                string[] tokens_n = Console.ReadLine().Split(' ');
                int money = Convert.ToInt32(tokens_n[0]);
                int price = Convert.ToInt32(tokens_n[1]);
                int wrappers = Convert.ToInt32(tokens_n[2]);
                p.chocolateFeast(money, price, wrappers);
            }
            p.printResult();
            Console.ReadKey();
        }
    }
}
