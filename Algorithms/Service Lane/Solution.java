import java.util.*;

public class Solution {

	private List<Integer> output;

	public Solution() {
		output = new ArrayList<Integer>();
	}

	public void serviceLane(int entry, int exit, int width[]) {
		int smallest = 3;
		for (int j = entry; j <= exit; j++) {
			smallest = Math.min(width[j], smallest);
		}
		output.add(smallest);
	}

	public void print() {
		for (int i : output) {
			System.out.println(i);
		}
	}

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int n = in.nextInt();
		int t = in.nextInt();
		int width[] = new int[n];
		for (int width_i = 0; width_i < n; width_i++) {
			width[width_i] = in.nextInt();
		}
		Solution s = new Solution();
		for (int a0 = 0; a0 < t; a0++) {
			int i = in.nextInt();
			int j = in.nextInt();
			s.serviceLane(i, j, width);
		}
		s.print();
	}
}
