using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int solve(int n, int p){
        if ((n/2) >= p) {
            return p/2;
        }
        else {
            if ((n%2 == 1 & n-p == 1) || (n-p == 0)) {
                return 0;
            }
            else if ((n%2 == 0 & n-p == 1)) {
                return 1;
            }
            else {
                return (n-p)/2;
            }
        }
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int p = Convert.ToInt32(Console.ReadLine());
        int result = solve(n, p);
        Console.WriteLine(result);
    }
}
