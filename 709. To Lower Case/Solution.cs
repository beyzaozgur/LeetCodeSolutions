public class Solution {
    public string ToLowerCase(string s) {

        string lower = "";

        for(int i = 0; i < s.Length; i++) {
            if(s[i] >= 65 && s[i] <= 90) {
                lower += (char)(s[i] + 32);
            }
            else
            {
                lower += s[i];
            }
        }

        return lower;
    }
}