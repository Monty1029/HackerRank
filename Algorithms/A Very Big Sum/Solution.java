import java.io.*;
import java.util.*;

public class Solution {

    public Solution() {
        
    }
    
    public long calculateSum(ArrayList<Long> n) {
        long sum = 0;
        for (Long num : n) {
            sum += num;
        }
        System.out.println(sum);
        return sum;
    }
    
    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner in = new Scanner(System.in);
        String a = in.nextLine();
        String s = in.nextLine();
        Solution sol = new Solution();
        ArrayList<Long> numbers = new ArrayList<Long>();
        String[] input = new String[1024];
        input = s.split(" ");
        for (String n : input) {
            numbers.add(Long.parseLong(n));
        }
        sol.calculateSum(numbers);
    }
}