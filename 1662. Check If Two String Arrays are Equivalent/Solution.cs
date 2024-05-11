public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {

        string word1Combined = "";
        string word2Combined = "";

        for(int i=0; i<word1.Length; i++) {
            word1Combined += word1[i];
        }

        for(int i=0; i<word2.Length; i++) {
            word2Combined += word2[i];
        }

        if(word1Combined == word2Combined) {
            return true;
        }
        else {
            return false;
        }
        
    }
}