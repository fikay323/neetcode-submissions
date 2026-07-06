public class Solution {
    public int MaxArea(int[] heights) {
        var maxArea = 0;
        var left = 0;
        var right = heights.Length - 1;

        while(left < right) {
            var heightLeft = heights[left];
            var heightRight = heights[right];

            var tempMaxArea = (right - left) * Math.Min(heightLeft, heightRight);
            maxArea = Math.Max(maxArea, tempMaxArea);
            
            if(heightLeft < heightRight) {
                left++;
            } else if(heightLeft > heightRight) {
                right--;
            } else {
                left++;
                // if(right < heights.Length -1) {
                //     right++;
                // }
            }
        }

        return maxArea;
    }
}
