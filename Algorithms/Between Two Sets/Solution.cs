using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int getTotalX(int[] a, int[] b) {
        int between = 0;
        int total_length = a.Length + b.Length;
        int count = 0;
        for (int i = a.Max(); i <= b.Min(); i++) {
            for (int j = 0; j < a.Length; j++) {
                if (i % a[j] == 0) {
                    count++;                    
                }
            }
            for (int j = 0; j < b.Length; j++) {                
                if (b[j] % i == 0) {
                    count++;                    
                }
            }
            if (count == total_length) {
                between++;                
            }            
            count = 0;
        }
        return between;
    }

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int m = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        string[] b_temp = Console.ReadLine().Split(' ');
        int[] b = Array.ConvertAll(b_temp,Int32.Parse);
        int total = getTotalX(a, b);
        Console.WriteLine(total);
    }
}
