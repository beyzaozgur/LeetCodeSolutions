public class Solution {
    public int NumIdenticalPairs(int[] nums) {

        int counter = 0;

        for(int i = 0; i < nums.Length; i++) {
            for(int j = 0; j < nums.Length; j++) {
                if( (i < j) && nums[i] == nums[j]) {
                    counter++;
                }
            }
        }

        return counter;
    }
}