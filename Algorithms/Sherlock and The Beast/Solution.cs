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

        public bool checkNumber(char[] currentNumber)
        {
            int fiveCount = 0;
            int threeCount = 0;
            bool ruleTwo = false;
            bool ruleThree = false;
            for (int i = 0; i < currentNumber.Length; i++)
            {
                if (currentNumber[i] == '5')
                {
                    fiveCount++;
                }
                else if (currentNumber[i] == '3')
                {
                    threeCount++;
                }
            }
            if ((threeCount % 5) == 0)
            {
                ruleTwo = true;
            }
            if ((fiveCount % 3) == 0)
            {
                ruleThree = true;
            }
            fiveCount = 0;
            threeCount = 0;
            if (ruleTwo && ruleThree)
            {
                return true;
            }
            if ((!ruleTwo && ruleThree) || (ruleTwo && !ruleThree))
            {
                ruleTwo = false;
                ruleThree = false;
            }
            return false;
        }

        public void sherlockAndTheBeast(int n)
        {
            char[] currentNumber = new char[n];
            for (int i = 0; i < n; i++)
            {
                currentNumber[i] = '5';
            }
            for (int i = currentNumber.Length - 1; i >= -1; i--)
            {
                if (!checkNumber(currentNumber))
                {
                    if (i == -1)
                    {
                        break;
                    }
                    currentNumber[i] = '3';
                }
                else {
                    results.Add(new string(currentNumber));
                    break;
                }
            }
            if (!checkNumber(currentNumber))
            {
                string s = "-1";
                results.Add(s);
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
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                p.sherlockAndTheBeast(n);
            }
            p.printResult();
            Console.ReadKey();
        }
    }
}
