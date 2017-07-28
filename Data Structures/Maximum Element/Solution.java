import java.util.*;

public class Solution {

	private Stack<Integer> stack;
	private Stack<Integer> max;
	private List<Integer> result;

	public Solution() {
		stack = new Stack<Integer>();
		result = new ArrayList<Integer>();
		max = new Stack<Integer>();
	}

	public void maximumElement(String instruction) {
		String[] splitInstruction = new String[3];
		if (instruction.length() > 1) {
			splitInstruction = instruction.split(" ");
		} else {
			splitInstruction[0] = instruction;
		}
		if (splitInstruction[0].equals("1")) {
			stack.push(Integer.parseInt(splitInstruction[1]));
			if (stack.size() == 1) {
				max.push(stack.peek());
			}
			if (stack.peek() >= max.peek()) {
				max.push(stack.peek());
			}
		} else if (splitInstruction[0].equals("2") && stack.size() > 0) {
			if (stack.peek() == max.peek()) {
				max.pop();
			}
			stack.pop();
		} else if (splitInstruction[0].equals("3") && stack.size() > 0) {
			result.add(max.peek());
		}
	}

	public void print() {
		for (Integer i : result) {
			System.out.println(i);
		}
	}

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int n = in.nextInt();
		String a = in.nextLine();
		Solution s = new Solution();
		String[] instruction = new String[3];
		for (int i = 0; i < n; i++) {
			s.maximumElement(in.nextLine());
		}
		s.print();
	}
}
