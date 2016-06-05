import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {
    
    public Solution() {
        
    }
    
    public void arraysds(int n, int[] arr) {
        int[] result = new int[n];
        for (int i = 0; i < n; i++) {
            result[i] = arr[n-1-i];
        }
        for (int j = 0; j < n; j++) {
            System.out.print(result[j] + " ");
        }
    }

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int arr[] = new int[n];
        for(int arr_i=0; arr_i < n; arr_i++){
            arr[arr_i] = in.nextInt();
        }
        Solution s = new Solution();
        s.arraysds(n, arr);
    }
}
