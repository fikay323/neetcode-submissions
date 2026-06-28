public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, int>();

        for(var i = 0; i < nums.Length; i++) {
            var balance = target - nums[i];
            
            if(dict.ContainsKey(balance)) {
                var j = dict[balance];
                var arr = new int[] {i, j};
                Array.Sort(arr);

                return arr;
            }

            dict[nums[i]] = i;
        } 
        return [];
    }
}
