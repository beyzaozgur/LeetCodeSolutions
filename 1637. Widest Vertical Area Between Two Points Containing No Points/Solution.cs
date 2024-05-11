public class Solution {
    public int MaxWidthOfVerticalArea(int[][] points) {
        
        int[] xValues = new int[points.Length];

        for(int i = 0; i < points.Length; i++) {
            xValues[i] = points[i][0];
        }

        Array.Sort(xValues);

        int maxValue = 0;

        for(int j = 0; j < xValues.Length; j++) {

            if(j == xValues.Length - 1) {
                break;
            }

            int difference = Math.Abs(xValues[j] - xValues[j+1]);
            
            if(difference > maxValue) {
                maxValue = difference;
            } 
        }

        return maxValue;

    }
}