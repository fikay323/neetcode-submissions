public class Solution {
    public string MinWindow(string s, string t)
    {
        if (t.Length == 0) return "";

        var countT = new Dictionary<char, int>();
        var window = new Dictionary<char, int>();
        var need = 0;
        var have = 0;
        for (var i = 0; i < t.Length; i++)
        {
            if (!countT.TryGetValue(t[i], out var count))
            {
                need++;
                countT[t[i]] = 0;
                window[t[i]] = 0;
            }

            countT[t[i]]++;
        }

        var l = 0;
        var r = 0;
        var n = s.Length;

        var minWord = "";

        while (r < n)
        {
            Console.WriteLine($"l: {l}, r: {r}, have: {have}, need: {need}");

            var rightChar = s[r];
            if (countT.ContainsKey(rightChar))
            {
                window[rightChar]++;
                if (window[rightChar] == countT[rightChar])
                {
                    have++;
                }
            }

            r++;

            while (have == need)
            {
                var lChar = s[l];
                if (countT.ContainsKey(lChar) && (window[lChar] - 1 < countT[lChar]))
                {
                    Console.WriteLine($"lChar: {lChar}, window[lChar]: {window[lChar]}, countT[lChar]: {countT[lChar]}");
                    var word = s.Substring(l, r - l);
                    if (string.IsNullOrWhiteSpace(minWord))
                    {
                        minWord = word;
                    }
                    else
                    {
                        minWord = word.Length < minWord.Length ? word : minWord;
                    }
                    Console.WriteLine($"minWord: {minWord}, word: {word}");
                    window[lChar]--;
                    have--;
                }
                else if (countT.ContainsKey(lChar))
                {
                    window[lChar]--;
                }

                l++;
            }
        }

        return minWord;
    }
}