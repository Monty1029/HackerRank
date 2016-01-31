using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Solution
    {
        private int limit;
        public Solution(int input)
        {
            limit = input;
        }

        public void appendString(int n)
        {
            if (n > 0)
            {
                string s = "";
                for (int i = 0; i < limit; i++)
                {
                    if (i < (n-1))
                    {
                        s += " ";
                    }
                    else
                    {
                        s += "#";
                    }

                }
                Console.WriteLine(s);
                appendString(n - 1);
            }
        }

        static void Main()
        {
            int input = Convert.ToInt32(Console.ReadLine());
            Solution s = new Solution(input);
            s.appendString(input);
            Console.ReadKey();
        }
    }
}