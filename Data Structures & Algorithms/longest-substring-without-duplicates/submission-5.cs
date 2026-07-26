public class Solution {
    public int LengthOfLongestSubstring(string s) {
        //sliding window
        var window = new HashSet<char>();
        int left = 0;
        int best = 0;

        for (int right = 0; right<s.Length; right++)
        {
            //on check si right est dans le dictionnaire
            while(window.Contains(s[right]))
            {
                //tant que right est dans le dictionnaire alors, on enleve left de la window eton avance left pour retrecir
                window.Remove(s[left]);
                left++;
            }
            
            //ici il n'est pas dans le dictionnaire donc on l'ajoute au dictionnaire
            window.Add(s[right]);

            //on calcul le best
            best = Math.Max(best, window.Count);
        }

        return best;
    }
}
