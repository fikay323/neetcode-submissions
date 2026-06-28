public class Solution {
    public bool hasDuplicate(int[] nums) {
        var uniqueNums = new HashSet<int>();

        foreach(var num in nums) {
            if(uniqueNums.Contains(num)) return true;
            uniqueNums.Add(num);
        }

        return false;
    }
}