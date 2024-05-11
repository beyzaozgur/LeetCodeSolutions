public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {

        int[] numArray = new int[nums.Length];
        int counter = 0;

        for(int i = 0; i < nums.Length; i++) {
            for(int j = 0; j < nums.Length; j++) {
                if(i != j && nums[i] > nums[j]) {
                    counter++;
                }
            }
            numArray[i] = counter;
            counter = 0;
        }

        return numArray;
    }
}