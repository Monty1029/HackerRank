using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int migratoryBirds(int n, int[] ar) {
        Array.Sort(ar);
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < n; i++) {
            if (!dict.ContainsKey(ar[i])) {
                dict.Add(ar[i], 1);
            }
            else {
                dict[ar[i]] = dict[ar[i]] + 1;
            }
        }
        int highest = 0;
        foreach (var k in dict.Keys) {
            if (dict[k] > highest) {
                highest = dict[k];
            }
        }
        foreach (var k in dict.Keys) {
            if (dict[k] == highest) {
                return k;
            }
        }
        return 0;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
        int result = migratoryBirds(n, ar);
        Console.WriteLine(result);
    }
}