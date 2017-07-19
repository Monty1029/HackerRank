using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int[] solve(int[] grades){
        int[] result = new int[grades.Length];
        for (int i = 0; i < grades.Length; i++) {
            if (grades[i] <= 37) {
                result[i] = grades[i];
            }
            else if (grades[i]%5 < 3) {
                result[i] = grades[i];
            }
            else {
                result[i] = (grades[i]+(5-grades[i]%5));
            }
        }
        return result;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] grades = new int[n];
        for(int grades_i = 0; grades_i < n; grades_i++){
           grades[grades_i] = Convert.ToInt32(Console.ReadLine());   
        }
        int[] result = solve(grades);
        Console.WriteLine(String.Join("\n", result));
        

    }
}