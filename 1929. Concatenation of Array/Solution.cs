public class Solution {
    public int[] GetConcatenation(int[] nums) {

        int[] ans = new int[2*nums.Length];

        int k = 0;

        for(int i = 0; i < 2*nums.Length; i++) {

            if(i == nums.Length) {
                k = 0;
            }

            ans[i] = nums[k];  

            k++;
        }

         return ans;
    }
}