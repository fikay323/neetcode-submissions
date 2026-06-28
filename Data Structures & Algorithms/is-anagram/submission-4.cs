public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        var lowerS = s.ToLower();
        var lowerT = t.ToLower();

        var count = new int[26];
        for(int i = 0; i < lowerS.Length; i++) {
            count[lowerS[i] - 'a'] = count[lowerS[i] - 'a'] + 1;
            count[lowerT[i] - 'a'] = count[lowerT[i] - 'a'] - 1;
        }

        foreach(var num in count) {
            if(num != 0) return false;
        }

        return true;
    }
}
