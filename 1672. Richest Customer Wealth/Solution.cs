public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int sum = 0;
        int[] wealthArray = new int[accounts.Length];

        for(int i = 0; i < accounts.Length; i++) {
            foreach(int num in accounts[i]) {
                sum += num;
            }
            wealthArray[i] = sum;
            sum = 0;
        }

        return wealthArray.Max();
    }
}