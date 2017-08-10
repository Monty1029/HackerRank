using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int getMoneySpent(int[] keyboards, int[] drives, int s){
        Array.Sort(keyboards);
        Array.Sort(drives);
        
        int highest = 0;
        
        if (keyboards.Min() >= s || drives.Min() >= s) {
            return -1;
        }
        
        for (int i = 0; i < keyboards.Length; i++) {
            for (int j = 0; j < drives.Length; j++) {
                if ((highest <= (keyboards[i] + drives[j])) && (s >= (keyboards[i] + drives[j]))) {
                    highest = keyboards[i] + drives[j];
                }
            }
        }
        if (highest == 0) {
            return -1;
        }
        return highest;
    }

    static void Main(String[] args) {
        string[] tokens_s = Console.ReadLine().Split(' ');
        int s = Convert.ToInt32(tokens_s[0]);
        int n = Convert.ToInt32(tokens_s[1]);
        int m = Convert.ToInt32(tokens_s[2]);
        string[] keyboards_temp = Console.ReadLine().Split(' ');
        int[] keyboards = Array.ConvertAll(keyboards_temp,Int32.Parse);
        string[] drives_temp = Console.ReadLine().Split(' ');
        int[] drives = Array.ConvertAll(drives_temp,Int32.Parse);
        //  The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
        int moneySpent = getMoneySpent(keyboards, drives, s);
        Console.WriteLine(moneySpent);
    }
}
