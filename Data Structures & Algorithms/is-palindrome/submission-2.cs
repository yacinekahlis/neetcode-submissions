public class Solution {
    public bool IsPalindrome(string s) {
        var chars = s.ToCharArray();
        string cleaned = new string(s.Where(char.IsLetterOrDigit).ToArray()).ToLowerInvariant();

        var left = 0;
        var right = cleaned.Length-1;

        while (left<right)
        {
            if(cleaned[left] != cleaned[right]) return false;
            left++;
            right--;
        }

        return true;
    }
}
