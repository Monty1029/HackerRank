using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        char[] chars = Console.ReadLine().ToCharArray();
        int level = 0;
        int valleys = 0;
        int pass = 0;
        
        if (chars[0] == 'D') {
            level--;
            pass = 1;
        }
        else {
            level++;
        }
        
        for (int i = 1; i < n; i++) {
            if (chars[i] == 'U') {
                level++;
            }
            else {
                level--;
            }
            
            if (level == 0) {
                if ((pass == 0 && chars[i] == 'D') || (pass == 1 && chars[i] == 'U')) {
                    pass++;
                }
                if (pass == 2) {
                    valleys++;
                    pass = 0;
                    if (i < n-1 && chars[i+1] == 'D') {
                        pass++;
                    }
                }
            }
        }
        Console.WriteLine(valleys.ToString());
    }
}