using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] s_ar = Console.ReadLine().Split(' ');
        int[] ar = new int[s_ar.Length];
        Dictionary<int,int> dict = new Dictionary<int,int>();
        int highest = 0;
        for (int i = 0; i < s_ar.Length; i++) {
            ar[i] = Convert.ToInt32(s_ar[i]);
        }
        for (int i = 0; i < ar.Length; i++) {
            if (!dict.ContainsKey(ar[i])) {
                dict.Add(ar[i], 1);
            }
            else {
                dict[ar[i]] = dict[ar[i]] + 1;
            }
        }
        foreach (var d in dict) {
            if (d.Value > highest) {
                highest = d.Value;
            }
        }
        Console.WriteLine((ar.Length-highest).ToString());
    }
}