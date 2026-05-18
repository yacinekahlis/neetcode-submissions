public class Solution {
    public bool IsPalindrome(string s) {
        //1. nuke tout les non alphanumerique avec une regex
        //2. tout mettre en majuscule
        //3. checker si s = s.reverse
        var pattern = "[^a-zA-Z0-9]";
        s = Regex.Replace(s, pattern, "");

        s = s.ToLower();

        char[] chars = s.ToCharArray();
        Array.Reverse(chars);

        string reversed = new string(chars);

        return reversed == s;
    }
}
