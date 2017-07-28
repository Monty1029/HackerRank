using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int[] getRecord(int[] s){
        int best = s[0];
        int worst = s[0];
        int bestTimes = 0;
        int worstTimes = 0;
        for (int i = 1; i < s.Length; i++) {
            if (s[i] > best) {
                best = s[i];
                bestTimes++;
            }
            else if (s[i] < worst) {
                worst = s[i];
                worstTimes++;
            }
        }
        return new int[]{bestTimes, worstTimes};
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] s_temp = Console.ReadLine().Split(' ');
        int[] s = Array.ConvertAll(s_temp,Int32.Parse);
        int[] result = getRecord(s);
        Console.WriteLine(String.Join(" ", result));
    }
}
