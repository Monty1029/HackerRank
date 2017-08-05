using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        string[] input_string = Console.ReadLine().Split(' ');
        int[] input = Array.ConvertAll(input_string, int.Parse);
        int i = input[0];
        int j = input[1];
        int k = input[2];
        
        int beautiful = 0;
        
        while (i <= j) {
            char[] reverse = i.ToString().ToCharArray();
            Array.Reverse(reverse);
            int r = Convert.ToInt32(new String(reverse));
            if (Math.Abs(i-r) == 0) {
                beautiful++;
            }
            else if ((Math.Abs(i-r)) % k == 0) {
                beautiful++;
            }
            i++;
        }
        Console.WriteLine(beautiful.ToString());        
    }
}