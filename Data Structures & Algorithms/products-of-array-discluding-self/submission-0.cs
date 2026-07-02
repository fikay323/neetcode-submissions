public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var prefix = new int[nums.Length];
        var suffix = new int[nums.Length];
        var product = new int[nums.Length];

        for(int i = 0; i < nums.Length; i++) {
            if(i == 0) {
                prefix[i] = 1;
                continue;
            }

            prefix[i] = prefix[i - 1] * nums[i - 1];
        }

        for(int i = nums.Length - 1; i >= 0; i--) {
            if(i == nums.Length - 1) {
                suffix[i] = 1;
                continue;
            }

            suffix[i] = suffix[i + 1] * nums[i + 1];
        }

        for(int i = 0; i < nums.Length; i++) {
            product[i] = prefix[i] * suffix[i];
        }

        return product;
    }
}
