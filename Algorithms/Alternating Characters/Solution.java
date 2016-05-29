import java.io.*;
import java.util.*;

public class Solution {
    
    private List<Integer> output;

    public Solution() {
        output = new ArrayList<Integer>();
    }
    
    public void alternatingCharacters(String s) {
        String[] splitString = s.split("");
        int deletions = 0;
        for (int i = 0; i < splitString.length-1; i++) {
            if (splitString[i].equals(splitString[i+1])) {
                deletions++;
            }
        }
        output.add(deletions);
    }
    
    public void print() {
        output.remove(0);
        for(int s : output) {
            System.out.println(s);
        }
    }
    
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int t = in.nextInt();
        Solution s = new Solution();
        for (int i = 0; i <= t; i++) {
            String characters = in.nextLine();
            s.alternatingCharacters(characters);
        }
        s.print();
    }
}