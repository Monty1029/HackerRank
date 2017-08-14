using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string super_reduced_string(string s){
        List<string> al = s.Select(c => c.ToString()).ToList();
        bool done = false;
        int prev_size = al.Count();
        while (!done) {
            prev_size = al.Count();
            for (int i = 0; i < al.Count()-1; i++) {
                if (al.ElementAt(i).Equals(al.ElementAt(i+1), StringComparison.Ordinal)) {
                    al.RemoveAt(i+1);
                    al.RemoveAt(i);
                }
            }            
            if (al.Count() == 1 || al.Count() == 0 || prev_size == al.Count()) {
                done = true;
            }
        }
        string result = string.Join("", al);
        if (result.Length == 0) {
            result = "Empty String";
        }
        return result;
    }

    static void Main(String[] args) {
        string s = Console.ReadLine();
        string result = super_reduced_string(s);
        Console.WriteLine(result);
    }
}
