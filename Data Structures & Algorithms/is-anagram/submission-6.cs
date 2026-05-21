public class Solution {
    public bool IsAnagram(string s, string t) {
        var s_chars = s.ToCharArray();
        var t_chars = t.ToCharArray();

        Array.Sort(s_chars);
        Array.Sort(t_chars);

        Console.Write(s_chars);
        Console.Write(t_chars);


        if (s_chars.SequenceEqual(t_chars)) return true;
        
        return false; 
    }
}
