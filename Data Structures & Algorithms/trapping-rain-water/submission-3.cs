public class Solution {
    public int Trap(int[] height) {
        var n = height.Length;
        if(n == 0) return 0;

        var left = 0;
        var right = n - 1;
        var leftMax = 0;
        var rightMax = 0;
        var total = 0;

        while(left < right) {
            if(height[left] < height[right]) {
                leftMax = Math.Max(height[left], leftMax);
                total += (leftMax - height[left]);
                left++;
            } else {
                rightMax = Math.Max(height[right], rightMax);
                total += (rightMax - height[right]);
                right--;
            }
        }

        return total;
    }
}
