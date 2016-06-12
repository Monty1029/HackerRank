import java.util.*;
import java.util.stream.Collectors;
import java.util.stream.IntStream;

public class Solution {
     private static int lonelyInteger(int[] a) {
        List<Integer> aList = IntStream.of(a).boxed().collect(Collectors.toList());
        for (Integer i : aList) {
            if (Collections.frequency(aList, i) == 1) {
                return i;
            }
        }
        return 0;
    }
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int[] a = new int[n];
        for (int i = 0; i < n; i++) {
            a[i] = in.nextInt();
        }
        System.out.println(lonelyInteger(a));
    }

}
