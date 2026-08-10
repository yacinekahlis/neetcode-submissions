public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char, int> window = new Dictionary<char, int>();
        int left = 0;
        int maxFreq = 0;
        int maxLength = 0;

        for (int right = 0; right < s.Length; right++) {
            char rightChar = s[right];

            // 1. Ajouter ou incrémenter le caractère courant dans le dictionnaire
            if (!window.ContainsKey(rightChar)) {
                window[rightChar] = 0;
            }
            window[rightChar]++;

            // 2. Mettre à jour la fréquence du caractère le plus présent
            maxFreq = Math.Max(maxFreq, window[rightChar]);

            // 3. Si la fenêtre nécessite plus de 'k' remplacements, on la réduit par la gauche
            while ((right - left + 1) - maxFreq > k) {
                char leftChar = s[left];
                window[leftChar]--;
                left++;
            }

            // 4. Mettre à jour la taille maximale
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
        
    }
}
