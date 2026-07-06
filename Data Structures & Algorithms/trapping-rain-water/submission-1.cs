public class Solution {
    public int Trap(int[] height) {
        var n = height.Length;
        if(n == 0) return 0;

        var leftMax = new int[n];
        var rightMax = new int[n];
        for(int i = 0; i < n; i++) {
            if(i == 0) {
                leftMax[0] = height[0];
                continue;
            }

            leftMax[i] = Math.Max(leftMax[i - 1], height[i]);
        }
        for(int i = n - 1; i >= 0; i--) {
            if(i == n - 1) {
                rightMax[i] = height[i];
                continue;
            }

            rightMax[i] = Math.Max(rightMax[i + 1], height[i]);
        }

        var total = 0;
        for(int i = 0; i < n; i++) {
            total += Math.Min(leftMax[i], rightMax[i]) - height[i];
        }

        return total;
    }
}
