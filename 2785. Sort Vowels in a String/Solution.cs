public class Solution {
    public string SortVowels(string s) {

        char[] chars = s.ToCharArray();
         List<char> vowels = new List<char>();

        for(int i=0; i<s.Length; i++) {
            char temp = char.ToLower(s[i]);
            if(temp == 'a' || temp == 'e' || temp == 'i' || temp == 'o' || temp == 'u') {
                vowels.Add(s[i]);
            }
        }

        vowels.Sort();

        int j = 0;
        for(int i=0; i<s.Length; i++) {
            char temp = char.ToLower(s[i]);
            if(temp == 'a' || temp == 'e' || temp == 'i' || temp == 'o' || temp == 'u') {
                chars[i] = (char) vowels[j];
                j++;
            }
        }

        return new string(chars);
    }
}