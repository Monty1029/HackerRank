using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string gameOfThrones(string s){
        Dictionary<char,int> dict = new Dictionary<char,int>();
        for (int i = 0; i < s.Length; i++) {
            if (!dict.ContainsKey(s[i])) {
                dict.Add(s[i], 1);
            }
            else {
                dict[s[i]]++;
            }
        }
        int odd = 0;
        foreach (var d in dict) {
            if (d.Value % 2 != 0) {
                odd++;
            }
        }
        if (odd > 1) {
            return "NO";
        }
        return "YES";
    }

    static void Main(String[] args) {
        string s = Console.ReadLine();
        string result = gameOfThrones(s);
        Console.WriteLine(result);
    }
}
