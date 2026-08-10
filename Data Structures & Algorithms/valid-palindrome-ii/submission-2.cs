public class Solution {
    public bool ValidPalindrome(string s) {
        int left = 0;
        int right = s.Length -1;

        while(left<right){
            //on check si pas alphanum  on bouge le truc fec faut bouvler genre tant que c'est pas alphanum
            while(left<right && !IsAlphanum(s[left]))left++;
            while(left<right && !IsAlphanum(s[right])) right--;

            //on compare en minusucle si != il faut reculer la lettre qui match pas en verifiant la lettre d'apres
            if(char.ToLower(s[left]) != char.ToLower(s[right])){
                return IsPalindrome(s, left + 1, right) || IsPalindrome(s, left, right - 1);
            } 

            right--;
            left++;

        }

        return true;
    }

    private bool IsPalindrome(string s, int left, int right) {
        while (left < right) {
            if (s[left] != s[right]) {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }

    private bool IsAlphanum(char c){
        bool isDigit = c>= '0' && c<= '9';
        bool isUpperLetter = c>= 'A' && c<= 'Z';
        bool isLowerLetter = c>= 'a' && c<= 'z';

        return isDigit || isUpperLetter || isLowerLetter;
    }
}