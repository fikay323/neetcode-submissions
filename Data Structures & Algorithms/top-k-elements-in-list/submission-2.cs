public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, List<int>> freq = nums.GroupBy(num => num)
            .GroupBy(g => g.Count(), g => g.Key)
            .ToDictionary(g => g.Key, g => g.ToList());

        var listToReturn = new int[k];
        var insertionTracker = 0;

        for(var i = nums.Length; i > 0; i--) {
            if(k == 0) return listToReturn;

            if(freq.TryGetValue(i, out var groupedNums)) {
                var length = groupedNums.Count;
                int[] newArr;

                if(length >= k) {
                    newArr = groupedNums.Take(k).ToArray();
                } else {
                    newArr = groupedNums.ToArray();
                }

                Array.Copy(newArr, 0, listToReturn, insertionTracker, newArr.Length);
                insertionTracker += newArr.Length;
                k -= newArr.Length;
            }
        }

        return listToReturn;
    }
}
