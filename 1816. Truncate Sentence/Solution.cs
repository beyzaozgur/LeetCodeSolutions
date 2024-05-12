public class Solution {
    // Solution 1
    public string TruncateSentence1(string s, int k) {
        string[] words = s.Split(" ");
        string truncatedSentence = "";
        for(int i = 0; i < k; i++) {
            if(i == k - 1) {
                truncatedSentence += words[i];
                return truncatedSentence;
            }
            truncatedSentence += (words[i] + " ");
        }

        return truncatedSentence;
    }

    // Solution 2 - good memory
    public string TruncateSentence2(string s, int k) {
        return string.Join(" ", s.Split(" "). Take(k));
    }

    // Solution 3 - without built-in functions - good runtime
    public string TruncateSentence3(string s, int k) {
        string truncatedSentence = "";
        for(int i = 0; i < s.Length; i++) {
            if(s[i] == ' ') {
                k--;
            }

            if(k == 0) {
                break;
            }

            truncatedSentence += (s[i]);
        }

        return truncatedSentence;
    }
}