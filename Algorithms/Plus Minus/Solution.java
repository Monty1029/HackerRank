import java.io.*;
import java.util.*;

public class Solution {

    public Solution() {
        
    }
    
    public void calculateFractions(ArrayList<Integer> numbers) {
    	
    	double positive = 0;
    	double negative = 0;
    	double zeroes = 0;
    	int size = numbers.size();
    	
        for (Integer n : numbers) {
            if (n > 0) {
            	positive++;
            }
            else if (n < 0) {
            	negative++;
            }
            else {
            	zeroes++;
            }
        }
        printPositive(positive, size);
        printPositive(negative, size);
        printPositive(zeroes, size);
    }
    
    public double printPositive(double positive, int size) {
    	System.out.println(positive/size);
    	return positive/size;
    }
    
    public double printNegative(double negative, int size) {
    	System.out.println(negative/size);
    	return negative/size;
    }
    
    public double printZeroes(double zeroes, int size) {
    	System.out.println(zeroes/size);
    	return zeroes/size;
    }
    
    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner in = new Scanner(System.in);
        String size = in.nextLine();
        String s = in.nextLine();
        Solution sol = new Solution();
        ArrayList<Integer> numbers = new ArrayList<Integer>();
        String[] input = new String[1024];
        input = s.split(" ");
        for (String n : input) {
            numbers.add(Integer.parseInt(n));
        }
        sol.calculateFractions(numbers);
    }
}