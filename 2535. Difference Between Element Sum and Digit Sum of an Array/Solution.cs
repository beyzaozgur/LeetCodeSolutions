public class Solution {
    // Solution 1 - String conversion
    public int DifferenceOfSum1(int[] nums) {
        int elementSum = 0;
        for(int i = 0; i < nums.Length; i++) {
            elementSum += nums[i];
        }

        string numbers = "";
        foreach(int i in nums) {
            numbers += i.ToString();
        }

        int digitSum = 0;
        foreach(char c in numbers) {
            digitSum += c - '0';
        }

        return Math.Abs(elementSum-digitSum);

    }

    // Solution 2
    public int DifferenceOfSum2(int[] nums) {
        int elementSum = 0;
        int digitSum = 0;

        for(int i = 0; i < nums.Length; i++) {
            elementSum += nums[i];

            int temp = nums[i];
            while(temp > 0) {
                digitSum += temp % 10;
                temp = temp/10;
            }
           
        }

        return Math.Abs(elementSum-digitSum);

    }
}