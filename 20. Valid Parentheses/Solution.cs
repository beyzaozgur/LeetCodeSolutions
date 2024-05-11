public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();

        foreach(char c in s) {
            if(c == '(' || c == '[' || c == '{') {
                stack.Push(c);
            }
            else {
                if(stack.Count <= 0) {
                    return false;
                }

                char lastCharInStack = stack.Pop();

                if(lastCharInStack == '(' && c != ')') {
                    return false;
                }
                else if(lastCharInStack == '[' && c != ']') {
                    return false;
                }
                else if(lastCharInStack == '{' && c != '}') {
                    return false;
                }
            }
        }
        if(stack.Count != 0) { // check if there is an unmatched parenthesis
            return false;
        }
        return true;
    }
}