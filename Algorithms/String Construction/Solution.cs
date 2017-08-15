using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int stringConstruction(string s) {
        Dictionary<char,int> dict = new Dictionary<char,int>();
        int counter = 0;
        for (int i = 0; i < s.Length; i++) {
            if (!dict.ContainsKey(s[i])) {
                dict.Add(s[i], 1);
                counter++;
            }
            else {
                dict[s[i]] = dict[s[i]] + 1;
            }
        }
        return counter;
    }

    static void Main(String[] args) {
        int q = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < q; a0++){
            string s = Console.ReadLine();
            int result = stringConstruction(s);
            Console.WriteLine(result);
        }
    }
}
