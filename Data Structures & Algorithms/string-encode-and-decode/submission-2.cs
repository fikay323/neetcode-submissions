public class Solution {

    public string Encode(IList<string> strs) {
        var sb = new StringBuilder();

        foreach (var str in strs) {
            var strCount = str.Length;
            sb.Append($"{strCount}#{str}");
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {
        var list = new List<string>();
        
        var nextIndex = 0;
        while(nextIndex < s.Length) {
            var indexOfNextLimiter = s.IndexOf('#', nextIndex);

            if(indexOfNextLimiter == -1) return list;

            var wordLength = indexOfNextLimiter - nextIndex;
            var parsedNum = int.Parse(s.Substring(nextIndex, wordLength));

            var word = s.Substring(indexOfNextLimiter + 1, parsedNum);
            list.Add(word);
            nextIndex = indexOfNextLimiter + 1 + parsedNum;
        }

        return list;
   }
}
