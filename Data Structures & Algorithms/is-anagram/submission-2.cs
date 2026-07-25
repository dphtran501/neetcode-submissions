public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) 
            return false;

        Dictionary<char, int> sCharCount = new();
        Dictionary<char, int> tCharCount = new();
        for (int i = 0; i < s.Length; i++)
        {
           if (sCharCount.ContainsKey(s[i]))
           {
                sCharCount[s[i]]++;
           }
           else 
           {
                sCharCount.Add(s[i], 1);
           }

           if (tCharCount.ContainsKey(t[i]))
           {
                tCharCount[t[i]]++;
           }
           else 
           {
                tCharCount.Add(t[i], 1);
           }
        }

        return sCharCount.Count == tCharCount.Count && !sCharCount.Except(tCharCount).Any();
    }
}
