public class Solution {
    public bool IsPalindrome(int x) {
        string stringNumber = x.ToString();
        char[] charArray = stringNumber.ToCharArray();
        for(int i = 0; i < charArray.Length; i++) {
            if(charArray[i] != charArray[charArray.Length-1-i]) {
                return false;
            }
        }
        return true;
    }
}