public class Solution {
    public int MaxProfit(int[] prices) {
        var n = prices.Length;
        var left = 0;
        var right = left + 1;
        var maxProfit = 0;

        while(right < n) {
            if(prices[right] > prices[left]) {
                maxProfit = Math.Max(maxProfit, prices[right] - prices[left]);
            } else {
                left = right;
            }

            right++;
        }

        return maxProfit;
    }
}
