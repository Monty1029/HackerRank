import java.util.*;

public class Solution {

	private List<String> result;
	
	public Solution() {
		result = new ArrayList<String>();
	}

	public void balancedParentheses(String parentheses) {
		Stack<String> stack = new Stack<String>();
		String[] splitParentheses = parentheses.split("");
		if (splitParentheses[0].equals(")") || splitParentheses[0].equals("]") || splitParentheses[0].equals("}")) {
			result.add("NO");
			return;
		}
		for (int i = 0; i < splitParentheses.length; i++) {
			if (splitParentheses[i].equals("(") || splitParentheses[i].equals("[") || splitParentheses[i].equals("{")){
				stack.push(splitParentheses[i]);
			}
			
			else if (splitParentheses[i].equals(")") && stack.size() > 0){
				String parenthesis = stack.pop();
				if (!parenthesis.equals("(")) {
					result.add("NO");
					return;
				}
			}
			else if (splitParentheses[i].equals("]") && stack.size() > 0){
				String parenthesis = stack.pop();
				if (!parenthesis.equals("[")) {
					result.add("NO");
					return;
				}
			}
			else if (splitParentheses[i].equals("}") && stack.size() > 0){
				String parenthesis = stack.pop();
				if (!parenthesis.equals("{")) {
					result.add("NO");
					return;
				}
			}
		}
		if (stack.size() > 0) {
			result.add("NO");
			return;
		}
		result.add("YES");
    }

	public void print() {
		for (String s : result) {
			System.out.println(s);
		}
	}

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int t = sc.nextInt();
		String a = sc.nextLine();
		Solution s = new Solution();
		for (int i = 0; i < t; i++) {
			String parentheses = sc.nextLine();
			s.balancedParentheses(parentheses);
		}
		s.print();
	}
}
