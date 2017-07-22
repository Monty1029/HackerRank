using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string S = Console.ReadLine();
        char[] arr = S.ToCharArray();
        int altered = 0;
        for (int i = 0; i < arr.Length; i++) {
            if ((i%3 == 1 && arr[i] != 'O') || (i%3 == 2 && arr[i] != 'S') || (i%3 == 0 && arr[i] != 'S')) {
                altered++;
            }
        }
        Console.WriteLine(altered.ToString());
    }
}
