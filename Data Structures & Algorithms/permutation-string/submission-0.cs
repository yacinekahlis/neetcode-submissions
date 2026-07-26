public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        //sliding window variation taille variable

        int left = 0;
        int right = s1.Length - 1;

        while(right<s2.Length){
            //compare s1 en ordre alphabetique à s2 en ordre alphabetique si == return true
            if(string.Concat(s1.OrderBy(c => c)) == string.Concat(s2.Substring(left, s1.Length).OrderBy(c => c))) return true;

            right++;
            left++;
        } 

        return false;
        
    }
}
