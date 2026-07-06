public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        var n = nums.Length;
        Array.Sort(nums);

        var list = new List<List<int>>();
        for(var i = 0; i < n; i++) {
            if(i > 0) {
                if(nums[i] == nums[i - 1]) continue;
            }

            var left = i + 1;
            var right = n - 1;
            while(left < right) {
                if(left == i) left++;
                if(right == i) right--;

                var target = -nums[i];
                var sum = nums[left] + nums[right];

                if(sum > target) {
                    right--;
                } else if(sum < target) {
                    left++;
                } else {
                    var numLeft = nums[left];
                    var numRight = nums[right];
                    var numI = nums[i];
                    if((numLeft + numRight) == -numI) {
                        list.Add(new List<int>() { numLeft, numI, numRight});
                        left++;
                        right--;

                        while((nums[left - 1] == nums[left]) && left < right) {
                            left++;
                        }
                }

                }
            }
        }

        return list;
    }
}
