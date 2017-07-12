import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    static int birthdayCakeCandles(int n, int[] ar) {
        int highest_number = 0;
        for (int i=0; i<n; i++) {
            if (ar[i] > highest_number) {
                highest_number = ar[i];
            }
        }
        int highest_occurences = 0;
        for (int i=0; i<n; i++) {
            if (ar[i] == highest_number) {
                highest_occurences++;
            }
        }
        return highest_occurences;
    }

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int[] ar = new int[n];
        for(int ar_i = 0; ar_i < n; ar_i++){
            ar[ar_i] = in.nextInt();
        }
        int result = birthdayCakeCandles(n, ar);
        System.out.println(result);
    }
}
