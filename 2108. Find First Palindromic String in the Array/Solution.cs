public class Solution {
    public string FirstPalindrome(string[] words) {
        string reversedWord = "";
        foreach(string word in words) {
            for(int i = word.Length-1; i>=0; i--) {
                reversedWord += word[i];
            }
            if(word == reversedWord) {
                return word;
            }
            reversedWord = "";
        }
        return "";
    }
}