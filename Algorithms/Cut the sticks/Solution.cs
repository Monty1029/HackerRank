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

        public bool allSame(int[] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] == arr[i+1])
                {
                    counter++;
                }
            }
            if (counter == arr.Length-1)
            {
                return true;
            }
            return false;
        }

        public void cutTheSticks(int n, int[] arr)
        {
            int smallestStick = 1001;
            while (arr.Length > 0)
            {
                Console.WriteLine(arr.Length);
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < smallestStick)
                    {
                        smallestStick = arr[i];
                    }
                }

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] -= smallestStick;
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] <= 0)
                    {
                        for (int j = i; j < arr.Length - 1; j++)
                        {
                            arr[j] = arr[j + 1];
                        }
                        arr = arr.Take(arr.Count() - 1).ToArray();
                        i--;
                    }
                }
                
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr.Length == 1)
                    {
                        Console.WriteLine(1);
                        return;
                    }
                    else if (allSame(arr))
                    {
                        Console.WriteLine(arr.Length);
                        return;
                    }
                }
                smallestStick = 1001;
            }
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
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            p.cutTheSticks(n, arr);
            p.printResult();
            Console.ReadKey();
        }
    }
}
