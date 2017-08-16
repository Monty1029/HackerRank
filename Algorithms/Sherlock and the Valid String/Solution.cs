using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string isValid(string s){
        Dictionary<char,int> dict = new Dictionary<char,int>();
        for (int i = 0; i < s.Length; i++) {
            if (!dict.ContainsKey(s[i])) {
                dict.Add(s[i], 1);
            }
            else {
                dict[s[i]]++;
            }
        }
        int different = 0;
        int prev = dict[s[0]];
        int highest = 0;
        int smallest = dict[s[0]];
        int smallest_occurrences = 0;
        foreach(var d in dict) {
            if (d.Value > highest) {
                highest = d.Value;
            }
            if (d.Value < smallest) {
                smallest = d.Value;
            }
            if (prev != d.Value && Math.Abs(prev-d.Value) == 1) {
                different++;
            }                        
        }
        foreach(var d in dict) {
            if (d.Value == smallest) {
                smallest_occurrences++;
            }
        }
        
        if (different > 1 || ((highest-1) > smallest && smallest != 1) || (smallest_occurrences > 1 && (highest-smallest) > 1)) {
            return "NO";
        }
        if (smallest == 1 && highest > 1) {
            return "YES";
        }
        return "YES";
    }

    static void Main(String[] args) {
        string s = Console.ReadLine();
        string result = isValid(s);
        Console.WriteLine(result);
    }
}