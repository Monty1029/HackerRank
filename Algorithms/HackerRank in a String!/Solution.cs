using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int q = Convert.ToInt32(Console.ReadLine());
        string hrs = "hackerrank";
        char[] hrc = hrs.ToCharArray();
        for(int a0 = 0; a0 < q; a0++){
            int ptr = 0;
            string s = Console.ReadLine();
            char[] s_arr = s.ToCharArray();
            for (int i = 0; i < s_arr.Length; i++) {
                if (s_arr[i] == hrc[ptr]) {
                    ptr++;
                    if (ptr == 10) {
                        break;
                    }
                }
            }
            if (ptr == 10) {
                Console.WriteLine("YES");
            }
            else {
                Console.WriteLine("NO");
            }
        }
    }
}