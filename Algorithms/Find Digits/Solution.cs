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
        
        public void findDigits(int n)
        {
            int counter = 0;
            string numberString = n.ToString();
            for (int i = 0; i < numberString.Length; i++)
            {
                if (!numberString.ElementAt(i).Equals('0'))
                {
                    if (n % Int32.Parse(numberString.ElementAt(i).ToString()) == 0)
                    {
                        counter++;
                    }
                }
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
                int n = Convert.ToInt32(Console.ReadLine());
                p.findDigits(n);
            }
            p.printResult();
            Console.ReadKey();
        }
    }
}
