using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int sockMerchant(int n, int[] ar) {
        Dictionary<int,int> dict = new Dictionary<int, int>();
        int pairs = 0;
        for (int i = 0; i < n; i++) {
            if (dict.ContainsKey(ar[i])) {
                dict[ar[i]]++;
            }
            else {
                dict.Add(ar[i], 1);
            }
        }
        foreach (int i in dict.Keys) {
            pairs += dict[i]/2;
        }
        return pairs;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
        int result = sockMerchant(n, ar);
        Console.WriteLine(result);
    }
}
