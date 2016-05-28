import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        Set<String> set = new HashSet<String>(Arrays.asList((in.nextLine().toLowerCase().split(""))));
        if (set.size() > 26) {
            System.out.println("pangram");
        }
        else {
            System.out.println("not pangram");
        }
    }
}