public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var longestStr = 0;
        var currentStr = 0;
        var left = 0;
        var right = 0;
        var n = s.Length;
        var set = new HashSet<char>();

        while(right < n) {
            // while(right < n && !set.Contains(s[right])) {
            //     Console.WriteLine(string.Join(", ", set));
            //     currentStr++;
            //     longestStr = Math.Max(longestStr, currentStr);
            //     set.Add(s[right]);
            //     right++;
            // }

            if(right < n && set.Contains(s[right])) {
                set.Remove(s[left]);
                left++;
                currentStr--;
            } else {
                Console.WriteLine(string.Join(", ", set));
                currentStr++;
                longestStr = Math.Max(longestStr, currentStr);
                set.Add(s[right]);
                right++;
            }

            // right++;
        }

        return longestStr;
    }
}
