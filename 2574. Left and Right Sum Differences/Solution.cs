public class Solution {
    public int[] LeftRightDifference(int[] nums) {
        int[] answer = new int[nums.Length];

        if(nums.Length < 2) {
            return [0];
        }

        int leftSum = 0;
        int rightSum = 0;

        for(int i = 0; i < nums.Length; i++) {
            for(int j = 0; j < nums.Length; j++) {

                if(j<i) {
                    leftSum += nums[j];
                }
                else if(j>i) {
                    rightSum += nums[j];
                }
            }

            answer[i] = Math.Abs(leftSum - rightSum);
            leftSum = 0;
            rightSum = 0;
        }

        return answer;
    }
}