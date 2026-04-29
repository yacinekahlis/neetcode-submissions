class Solution {
    /**
     * @param {string} s
     * @return {boolean}
     */
    isPalindrome(s) {
        let t = s.replace(/[^a-z0-9]/gi, '').toLowerCase();
        
        let i = 0;
        let j = t.length-1;

        while(i<j){
            if(t[i]!=t[j]) return false;
            i++;
            j--;
        }

        return true;
    }
}
