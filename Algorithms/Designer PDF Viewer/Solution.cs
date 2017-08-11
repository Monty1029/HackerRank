using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] h_temp = Console.ReadLine().Split(' ');
        int[] h = Array.ConvertAll(h_temp,Int32.Parse);
        string word = Console.ReadLine();
        char[] word_arr = word.ToCharArray();
        
        Dictionary<char,int> dict = new Dictionary<char,int>();
        
        for (int i = 0; i < h.Length; i++) {
            dict.Add((char)(i+97), h[i]);
        }
        int highest = 0;
        for (int i = 0; i < word_arr.Length; i++) {
            if (dict[word_arr[i]] > highest) {
                highest = dict[word_arr[i]];
            }
        }
        Console.WriteLine((highest*word_arr.Length).ToString());
    }
}
