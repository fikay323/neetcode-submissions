public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        if(strs.Length == 0) return [];

        var dictionary = new Dictionary<(
            int v1, int v2, int v3, int v4, int v5,
            int v6, int v7, int v8, int v9, int v10,
            int v11, int v12, int v13, int v14, int v15,
            int v16, int v17, int v18, int v19, int v20,
            int v21, int v22, int v23, int v24, int v25,
            int v26
        ), List<string>>();
        for(int i = 0; i < strs.Length; i++) {
            var str = strs[i];
            var arr = new int[26];

            ReadOnlySpan<char> span = str.AsSpan();
            foreach(char charact in span) {
                arr[charact - 'a'] = arr[charact - 'a'] + 1;
            }
            var tupleKey = (
                arr[0],  arr[1],  arr[2],  arr[3],  arr[4],  arr[5],  arr[6],  arr[7],  arr[8],  arr[9],
                arr[10], arr[11], arr[12], arr[13], arr[14], arr[15], arr[16], arr[17], arr[18], arr[19],
                arr[20], arr[21], arr[22], arr[23], arr[24], arr[25]
            );

            if(!dictionary.TryGetValue(tupleKey, out var existingList)) {
                existingList = new List<string>();
                dictionary[tupleKey] = existingList;
            }

            existingList.Add(str);
        }

        return dictionary.Values.ToList();
        // string[][] jaggedArray = dictionary.Values.Select(d => d.ToArray()).ToArray();
        // return jaggedArray;
    }
}
