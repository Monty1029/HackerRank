using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string s = Console.ReadLine();
        int words = 1;
        foreach (char c in s) {
            if ((int)c >= 65 && (int)c <= 90) {
                words++;
            }
        }
        Console.WriteLine(words.ToString());
    }
}
