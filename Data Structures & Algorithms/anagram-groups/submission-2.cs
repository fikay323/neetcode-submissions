public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        if(strs.Length == 0) return [];

        var dictionary = new Dictionary<string, List<string>>();
        for(int i = 0; i < strs.Length; i++) {
            var str = strs[i];
            var arr = new int[26];

            ReadOnlySpan<char> span = str.AsSpan();
            foreach(char charact in span) {
                arr[charact - 'a'] = arr[charact - 'a'] + 1;
            }
            var key = string.Join(',', arr);

            if(!dictionary.TryGetValue(key, out var existingList)) {
                existingList = new List<string>();
                dictionary[key] = existingList;
            }

            existingList.Add(str);
        }

        return dictionary.Values.ToList();
        // string[][] jaggedArray = dictionary.Values.Select(d => d.ToArray()).ToArray();
        // return jaggedArray;
    }
}
