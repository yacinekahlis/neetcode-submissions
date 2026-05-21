public class Solution {
    public bool IsPalindrome(string s) {

        var left = 0;
        var right = s.Length-1;

        while (left<right)
        {
            while (left < right && !char.IsLetterOrDigit(s[left])) left++;
            while (left < right &&  !char.IsLetterOrDigit(s[right])) right--;

            if(s.ToLower()[left] != s.ToLower()[right]) return false;

            left++;
            right--;
        }

        return true;
    }
}
