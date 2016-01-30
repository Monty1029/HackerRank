import java.io.*;
import java.util.*;

public class Solution {

    public Solution() {
        
    }
    
    public int calculateSum(ArrayList<Integer> n) {
        int sum = 0;
        for (Integer num : n) {
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
        ArrayList<Integer> numbers = new ArrayList<Integer>();
        String[] input = new String[1024];
        input = s.split(" ");
        for (String number : input) {
            numbers.add(Integer.parseInt(number));
        }
        sol.calculateSum(numbers);
    }
}