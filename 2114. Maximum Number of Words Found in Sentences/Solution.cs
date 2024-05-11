public class Solution {
    public int MostWordsFound(string[] sentences) {

        int counter = 0;
        int total = 0;

        for(int i=0; i < sentences.Length; i++) {
            foreach(char c in sentences[i]) {
                if(c == ' ') {
                    counter ++;
                }
            }

            if(counter > total) {
                total = counter;
            }
            counter = 0;
        }

        return total+1;
    }
}