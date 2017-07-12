using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        Array.Sort(arr);
        long smallest = 0;
        long largest = 0;
        for (int i=1; i<arr.Length; i++) {
            largest += arr[i];
        }
        for (int i=0; i<arr.Length-1; i++) {
            smallest += arr[i];
        }
        Console.Write(smallest + " " + largest);
    }
}
