public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        
        List<bool> results = new List<bool>();

        int max = candies.Max();
        int greatestSum = 0;

        for(int i=0; i<candies.Length; i++) {

            int total = candies[i] + extraCandies;

            if(total > max) {
                results.Add(true);
            }
            else if(total == max) {
                results.Add(true);
            }
            else {
                results.Add(false);
            }
        }

        return results;
    }
}