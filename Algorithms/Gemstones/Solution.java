import java.io.*;
import java.util.*;

public class Solution {
    
    public Solution() {
        
    }
    
    public void gemstones(int n, List<String> characterList) {
        int gemElements = 0;
        int count = 0;
        for (int i = 0; i < characterList.size(); i++) {
            for (int j = i; j < characterList.size(); j++) {
                if (characterList.get(i).equals(characterList.get(j))) {
                    count++;
                }
            }
            if (count == n) {
                gemElements++;
            }
            count = 0;
        }
        System.out.println(gemElements);
    }

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        List<String> characterList = new ArrayList<String>();
        for (int i = 0; i <= n; i++) {
            Set<String> set = new HashSet<String>(Arrays.asList(in.nextLine().split("")));
            characterList.addAll(set);
        }
        Solution s = new Solution();
        s.gemstones(n, characterList);
    }
}