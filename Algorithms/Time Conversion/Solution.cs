using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Solution
    {
        public Solution()
        {

        }

        public void convertTime(string time)
        {
            char[] charArray = time.ToCharArray();
            int firstDigit = (int)Char.GetNumericValue(charArray[0]);
            int secondDigit = (int)Char.GetNumericValue(charArray[1]);
            if (charArray[time.Length - 2] == 'P')
            {
                int newTime = ((firstDigit * 10) + secondDigit) + 12;
                char[] newTimeCharArray = newTime.ToString().ToCharArray();
                if (newTime == 24)
                {
                    newTimeCharArray[0] = '1';
                    newTimeCharArray[1] = '2';
                }
                charArray[0] = newTimeCharArray[0];
                charArray[1] = newTimeCharArray[1];
                string output = new string(charArray);
                Console.WriteLine(output.Remove(time.Length - 2, 2));
            }
            else
            {
                if (firstDigit == 1 && secondDigit == 2)
                {
                    charArray[0] = '0';
                    charArray[1] = '0';
                }
                string output = new string(charArray);
                Console.WriteLine(output.Remove(time.Length - 2, 2));
            }
        }

        static void Main()
        {
            string input = Console.ReadLine();
            Solution p = new Solution();
            p.convertTime(input);
            Console.ReadKey();
        }
    }
}