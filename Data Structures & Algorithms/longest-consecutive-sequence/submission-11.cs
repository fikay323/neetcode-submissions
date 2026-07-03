public class Solution {
    public int LongestConsecutive(int[] nums) {
        var hash = new HashSet<int>(nums);

        if(hash.Count == 1) return 1;

        var longestConsecutive = 0;
        foreach(var num in hash) {
            var rollingCurrent = 1;
            var min = num;
            if(!hash.Contains(min - 1)) {
                while(hash.Contains(min + 1)) {
                    rollingCurrent++;
                    min++;
                }

                longestConsecutive = Math.Max(longestConsecutive, rollingCurrent);
            }
        }

        return longestConsecutive;
    }
}
