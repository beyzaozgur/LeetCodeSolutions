public class Solution {
    public int[] Shuffle(int[] nums, int n) {

        int[] shuffledArray = new int[2*n];
        int k = 0;

        for(int i = 0; i<n; i++) {
            shuffledArray[k] = nums[i];
            shuffledArray[k+1] = nums[i+n];
            k = k+2;
        }

        return shuffledArray;
    }
}