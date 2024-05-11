public class Solution {
    public int FinalValueAfterOperations(string[] operations) {

        int result = 0;

        foreach(string op in operations) {
            if(op.Contains("-"))
            {
                result--;
            }
            else
            {
                result++;
            }
        }

        return result;
    }
}