public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var seen = new HashSet<char>();
        int left = 0;
        int longestSubstring = 0;

        for(int right = 0; right < s.Length; right++)
        {
            while(seen.Contains(s[right])){
                seen.Remove(s[left]);
                left++;
            }

            seen.Add(s[right]);

            longestSubstring = Math.Max(longestSubstring, right - left + 1);
        }

        return longestSubstring;
    }
}
