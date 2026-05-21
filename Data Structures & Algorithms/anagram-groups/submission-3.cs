public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
       
       var groups = new Dictionary<string, List<string>>();

       foreach (string word in strs)
       {
            char[] chars = word.ToCharArray();
            Array.Sort(chars);

            string key = new string(chars);

            if (!groups.ContainsKey(key))
            {
                groups[key] = new List<string>();
            }

            groups[key].Add(word);

       }

       return groups.Values.ToList();
    }
        
}
